using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Function;
using Function.Db;
using System.Data;

namespace GM_Torqu_Tool_IF
{
	/// <summary>
	/// db 처리 관리 class
	/// </summary>
	class dba
	{
		/// <summary>
		/// tcode 테이블에 데이터 존재 여부를 체크한다.
		/// </summary>
		public static void code_chk()
		{
			MsSQL sql = new MsSQL(vari.conn);

			string qry = string.Format("SELECT COUNT(*) CNT FROM T_CODE WHERE COMPANY_ID = 'GM' AND PROG_ID = 'TORQUE' AND CODE = 'TOOL_NAME'");

			using (DataSet ds = sql.Excute_Query(qry, "cnt"))
			{
				if(Fnc.obj2int(ds.Tables[0].Rows[0]["cnt"]) < 1)
				{
					qry = "Insert into T_CODE (COMPANY_ID, PROG_ID, CODE, CODENAME, CODETYPE ) values ( 'GM', 'TORQUE', 'TOOL_NAME', '툴 이름', 'S')";
					sql.Excute_Query(qry, "");
				}
			}

			qry = string.Format("SELECT COUNT(*) CNT FROM T_CODE WHERE COMPANY_ID = 'GM' AND PROG_ID = 'TORQUE' AND CODE = 'RST_NAME'");

			using (DataSet ds = sql.Excute_Query(qry, "cnt"))
			{
				if (Fnc.obj2int(ds.Tables[0].Rows[0]["cnt"]) < 1)
				{
					qry = "Insert into T_CODE (COMPANY_ID, PROG_ID, CODE, CODENAME, CODETYPE ) values ( 'GM', 'TORQUE', 'RST_NAME', '결과 이름', 'S')";
					sql.Excute_Query(qry, "");
				}
			}


		}


		/// <summary>
		/// sql db연결 체크용 시간조회
		/// </summary>
		/// <returns></returns>
		public static DateTime date_get()
		{
			MsSQL sql = new MsSQL(vari.conn);

			string qry = string.Format("SELECT GETDATE()");

			DataTable dt = sql.Excute_Query(qry, "").Tables[0];

			return (DateTime)dt.Rows[0][0];
		}


		public static DataTable codedetail_get(string codename)
		{
			MsSQL sql = new MsSQL(vari.conn);

			string qry = string.Format("SELECT CODEVALUE, CODEVALUENAME FROM T_CODEDETAIL WHERE COMPANY_ID = 'GM' AND PROG_ID = 'TORQUE' AND CODE = '{0}'", codename);

			return sql.Excute_Query(qry, "").Tables[0];
		}

		public static void codedetail_save(string code, DataTable dt)
		{
			MsSQL sql = new MsSQL(vari.conn);

			try
			{
				sql.BeginTransaction();

				foreach(DataRow r in dt.Rows)
				{
					string qry = string.Format(@"
DECLARE 
	@CNT int,	
	@CODE nvarchar(10),
	@CODEVALUE NVARCHAR(10),
	@CODEVALUENAME NVARCHAR(10)
BEGIN
	set @code = '{0}';
	SET @CODEVALUE = '{1}';
	SET @CODEVALUENAME = '{2}';

	SELECT @CNT =COUNT(*)
	FROM T_CODEDETAIL
	WHERE COMPANY_ID = 'GM'
		AND PROG_ID = 'TORQUE'
		AND CODE = @CODE
		AND CODEVALUE = @CODEVALUE;

	IF(@CNT > 0)
	BEGIN
		--UPDATE
		UPDATE T_CODEDETAIL
			SET CODEVALUENAME = @CODEVALUENAME,
				LASTUPDATEDATE = GETDATE()
		WHERE COMPANY_ID = 'GM'
			AND PROG_ID = 'TORQUE'
			AND CODE = @CODE
			AND CODEVALUE = @CODEVALUE;

	END;
	ELSE
	BEGIN
		--INSERT
		Insert into T_CODEDETAIL (COMPANY_ID, PROG_ID, CODE, CODEVALUE, CODEVALUENAME, LASTUPDATEDATE  ) 
			values 
				( 'GM', 'TORQUE', @code, @CODEVALUE, @CODEVALUENAME, GETDATE());
	END;

END;
", code, r["codevalue"], r["codevaluename"] );

					sql.Excute_Query(qry, string.Empty);

				}

				sql.CommitTransaction();


			}
			catch(Exception ex)
			{
				sql.RollBackTransaction();
				throw ex;
			}

		}


		public static void Data_Insert(string vin, string trimin, string pono, string cartype, string rst, string stationid, string data)
		{
			MsSQL sql = new MsSQL(vari.conn);

			string fld = string.Empty;
			string vals = string.Empty;
			
			int[] toolLength = new int[] { 4, 4, 2 };


			for(int t=1; t <= vari.tool_max_lenth; t++)
			{
				for(int n=1; n <= vari.rst_max_lenth; n++)
				{					
					fld += $", T{t:D2}_N{n:D2}";
					vals += $", '{Fnc.StringGet(ref data,toolLength[n-1])}'";					
				}

				if (data.Length < 1) break;
			}

			string qry = string.Format(@"
DECLARE 
	@dtNow DATETIME
BEGIN

	SET @dtNow = GETDATE();

	INSERT INTO T_RESULT 
		(CREATEDATE, PONO, TRIMINSEQ, VIN, CARTYPE, TOTALRESULT, STATION_ID
		{0}	)
	VALUES
		(@dtNow, '{1}', '{2}', '{3}', '{4}', '{5}', '{7}'
		{6} );

END;

", fld, pono, trimin, vin, cartype, rst, vals, stationid);

			sql.Excute_Query(qry, "");

		}


		public static DataTable Data_Search(DateTime dtFrom, DateTime dtTo, string cartype, string pono, string vin, string trimin, string rst, string stationid)
		{
			MsSQL sql = new MsSQL(vari.conn);

			string col;
			string nm = string.Empty;
			string cols = string.Empty;
			string where = string.Empty;
			DataRow[] rows;
			
			//조회 컬럼 이름 변경
			for (int t = 1; t <= vari.tool_max_lenth; t++)
			{
				for (int n = 1; n <= vari.rst_max_lenth; n++)
				{
					nm = string.Empty;

					col = $"T{t:D2}";

					rows = vari.dt_tool_name.Select($"CODEVALUE = '{col}'");

					if (rows.Length > 0) nm = Fnc.obj2String(rows[0]["CODEVALUENAME"]);

					if (!nm.Equals(string.Empty))
					{
						col = $"N{n:D2}";

						rows = vari.dt_rst_name.Select($"CODEVALUE = '{col}'");

						if (rows.Length > 0)
							nm = $"'{nm}[{rows[0]["CODEVALUENAME"]}]'";
						else
							nm = string.Empty;
					}

					if (nm.Equals(string.Empty)) break;

					cols += $", T{t:D2}_N{n:D2} {nm}";
				}

				if (nm.Equals(string.Empty)) break;
			}


			//조회 조건 만듦
			where = string.Format("AND CreateDate between  CONVERT(datetime,'{0}') and CONVERT(datetime,'{1}')", Fnc.Date2String(dtFrom, Fnc.enDateType.DateTime), Fnc.Date2String(dtTo, Fnc.enDateType.DateTime));
			
			if (!cartype.Equals(string.Empty)) where += $"\r\n\t AND CARTYPE = '{cartype}' ";
			if (!pono.Equals(string.Empty)) where += $"\r\n\t AND PONO = '{pono}' ";
			if (!vin.Equals(string.Empty)) where += $"\r\n\t AND VIN = '{vin}' ";
			if (!trimin.Equals(string.Empty)) where += $"\r\n\t AND TRIMINSEQ = '{trimin}' ";
			if (!rst.Equals(string.Empty)) where += $"\r\n\t AND TOTALRESULT = '{cartype}' ";
			if (!stationid.Equals(string.Empty)) where += $"\r\n\t AND STATION_ID = '{stationid}' ";
			

			string qry = string.Format(@"
SELECT TOP {2}  CONVERT(nvarchar,CreateDate,120) 작업시간, PONO, TrimInSeq, VIN, CarType--, TotalResult 'FASTENING FINAL'  
	{0}
FROM     T_Result
WHERE 1=1
{1}	
ORDER BY CreateDate
", cols, where, vari.Search_Max_Row);

			return sql.Excute_Query(qry, "").Tables[0];

		}


		/// <summary>
		/// 마지막 작업내역을 조회 한다.
		/// </summary>
		/// <param name="cnt"></param>
		/// <returns></returns>

		public static DataTable Data_LastWork(int cnt, string dev)
		{
			MsSQL sql = new MsSQL(vari.conn);

			string qry = string.Format(@"
SELECT TOP {0}  CreateDate, PONO, TrimInSeq, VIN, CarType, TotalResult 
FROM     T_Result
WHERE STATION_ID = '{1}'
ORDER BY CreateDate DESC
", cnt, dev);

			return sql.Excute_Query(qry, "").Tables[0];
		}


	}
}
