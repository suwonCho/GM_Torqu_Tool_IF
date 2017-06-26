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



	}
}
