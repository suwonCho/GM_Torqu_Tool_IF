using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Function;
using System.Data;
using System.Windows.Forms;

namespace GM_Torqu_Tool_IF
{
	/// <summary>
	/// 변수 관리 클래스
	/// </summary>
	class vari
	{
		/// <summary>
		/// 프로그램
		/// </summary>
		public static readonly string Pgm_Name = "TorquTool";

		/// <summary>
		/// 프로그램 실행 경로
		/// </summary>
		public static string Pgm_Path;
		/// <summary>
		/// 프로그램 설정 파일명
		/// </summary>
		public static string Pgm_Setting_FileName = "TorquTool_Setting.xml";

		/// <summary>
		/// 프로그램 설정 파일
		/// </summary>
		public static Function.Setting Pgm_Setting;


		/// <summary>
		/// SQL Connection Info
		/// </summary>
		public static Function.Db.MsSQL.strConnect conn;


		


		public struct stPLC
		{
			public string RSLINX_ID;
			public string Topic_Name;
			public string Add_Trigger;
			public string Add_Ack;
			public string Add_Data;
		}

		/// <summary>
		/// plc 정보
		/// </summary>
		public static stPLC plc;

		/// <summary>
		/// plc 정보 기초 값
		/// </summary>
		public static stPLC plc_default;

		/// <summary>
		/// 툴 최대 값
		/// </summary>
		public static readonly int tool_max_lenth = 25;

		/// <summary>
		/// 결과 최대 값
		/// </summary>
		public static readonly int rst_max_lenth = 3;

		/// <summary>
		/// 툴 이름 데이터 테이블 T01~T25
		/// </summary>
		public static DataTable dt_tool_name;

		/// <summary>
		/// 결과 이름 데이터 테이블 N01~N03
		/// </summary>
		public static DataTable dt_rst_name;


		/// <summary>
		/// 프로그램 운영 모드
		/// </summary>
		public enum enOpMode
		{
			/// <summary>
			/// 조회 모드
			/// </summary>
			Seaching = 0,
			/// <summary>
			/// 모니터링 모드
			/// </summary>
			Monitoring = 1
		}

		/// <summary>
		/// 프로그램 운영 모드
		/// </summary>
		public static enOpMode OpMode;



		/// <summary>
		/// 프로그램에서 사용 할 이미지 리스트
		/// </summary>
		public static ImageList ImgList = new ImageList();

		/// <summary>
		/// 최대 로그 유지 숫자
		/// </summary>
		public static int iLogMaxCnt = 100;


		/// <summary>
		/// 변수 초기화
		/// </summary>
		public static void Init()
		{
			Pgm_Path = System.Windows.Forms.Application.StartupPath;
			Pgm_Setting_FileName = $"{Pgm_Path}\\{Pgm_Setting_FileName}";


			Pgm_Setting = new Setting(Pgm_Setting_FileName);


			//db 정보 로드
			Pgm_Setting.Group_Select("MsSql");

			conn.strIP = Pgm_Setting.Value_Get("IP", string.Empty);
			conn.strDataBase = Pgm_Setting.Value_Get("DataBase", string.Empty);
			conn.strID = Pgm_Setting.Value_Get("ID", string.Empty);
			conn.strPass = Pgm_Setting.Value_Get("PassWords", string.Empty);

			//plc 기초 값 로드  N7:0,L2
			plc_default.RSLINX_ID = "opcda://localhost/RSLinx OPC Server";
			plc_default.Topic_Name = "Torque";
			plc_default.Add_Trigger = "[Torque]R7000:0,L2";
			plc_default.Add_Ack = "[Torque]R7001:0,L2";
			plc_default.Add_Data = "[Torque]R7002:0,L200";

			Pgm_Setting.Group_Select("PLC");

			plc.RSLINX_ID = vari.Pgm_Setting.Value_Get("RSLINX_ID");

			if (plc.RSLINX_ID?.Equals(string.Empty) == false)
			{
				plc.Topic_Name = vari.Pgm_Setting.Value_Get("TOPIC_NAME");
				plc.Add_Trigger = vari.Pgm_Setting.Value_Get("ADD_TRIGGER");
				plc.Add_Ack = vari.Pgm_Setting.Value_Get("ADD_ACK");
				plc.Add_Data = vari.Pgm_Setting.Value_Get("ADD_DATA");
			}
			else
			{
				plc = plc_default;
			}


			//프로그램 설정
			Pgm_Setting.Group_Select("PGM");
			OpMode = (enOpMode)Fnc.obj2int(vari.Pgm_Setting.Value_Get("OPMODE", "0"));
			
		}

		public static void PLC_Setting_Save()
		{
			Pgm_Setting.Group_Select("PLC");


			vari.Pgm_Setting.Value_Set("RSLINX_ID", plc.RSLINX_ID);
			vari.Pgm_Setting.Value_Set("TOPIC_NAME", plc.Topic_Name);
			vari.Pgm_Setting.Value_Set("ADD_TRIGGER", plc.Add_Trigger);
			vari.Pgm_Setting.Value_Set("ADD_ACK", plc.Add_Ack);
			vari.Pgm_Setting.Value_Set("ADD_DATA", plc.Add_Data);


			//프로그램 설정
			Pgm_Setting.Group_Select("PGM");
			vari.Pgm_Setting.Value_Set("OPMODE", ((int)OpMode).ToString());

			Pgm_Setting.Setting_Save();
		}


		/// <summary>
		/// 변경된 DB 연결 정보를 저장한다.
		/// </summary>
		public static void DB_Setting_Save()
		{
			Pgm_Setting.Group_Select("MsSql");


			Pgm_Setting.Value_Set("IP", conn.strIP);
			Pgm_Setting.Value_Set("DataBase", conn.strDataBase);
			Pgm_Setting.Value_Set("ID", conn.strID);
			Pgm_Setting.Value_Set("PassWords", conn.strPass);

			Pgm_Setting.Setting_Save();
		}
		

		/// <summary>
		/// DB에서 코드정보(툴이름, 결과이름)을 가지고 온다.
		/// </summary>
		public static void DB_CodeDetail_Load()
		{
			try
			{
				dba.code_chk();

				dt_tool_name = dba.codedetail_get("TOOL_NAME");
				dt_rst_name = dba.codedetail_get("RST_NAME");
			}
			catch
			{

			}

		}



	}
}
