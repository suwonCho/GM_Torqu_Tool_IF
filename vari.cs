using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Function;

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




		/// <summary>
		/// 변수 초기화
		/// </summary>
		public static void Init()
		{
			Pgm_Path = System.Windows.Forms.Application.StartupPath;
			Pgm_Setting_FileName = $"{Pgm_Path}\\{Pgm_Setting_FileName}";


			Pgm_Setting = new Setting(Pgm_Setting_FileName);


			Pgm_Setting.Group_Select("MsSql");

			conn.strIP = Pgm_Setting.Value_Get("IP", string.Empty);
			conn.strDataBase = Pgm_Setting.Value_Get("DataBase", string.Empty);
			conn.strID = Pgm_Setting.Value_Get("ID", string.Empty);
			conn.strPass = Pgm_Setting.Value_Get("PassWords", string.Empty);
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
		


	}
}
