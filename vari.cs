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
		/// 변수 초기화
		/// </summary>
		public static void Init()
		{
			Pgm_Path = System.Windows.Forms.Application.StartupPath;
			Pgm_Setting_FileName = $"{Pgm_Path}\\{Pgm_Setting_FileName}";


			Pgm_Setting = new Setting(Pgm_Setting_FileName);



		}
	}
}
