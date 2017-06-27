using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Function;
using Function.form;

namespace GM_Torqu_Tool_IF
{
	public partial class frmMain : Function.form.frmWorkBase
	{
		/// <summary>
		/// plc 통신 모듈
		/// </summary>
		PLCModule.clsPLCModule opc = null;

		/// <summary>
		/// 테스트 값
		/// </summary>
		string[] strTest;

		/// <summary>
		/// 테스트 index
		/// </summary>
		int iTest = 0;

		/// <summary>
		/// 조건 차종 배열
		/// </summary>
		string[] cond_cartype = new string[] { "", "G30", "T30" };

		/// <summary>
		/// 조건 결과 배열
		/// </summary>
		string[] cond_result = new string[] { "", "OK", "NG" };
		


		public frmMain()
		{
			InitializeComponent();

			vari.Init();

			SavePosition_Setting = vari.Pgm_Setting;
			btnSetting.Image = Function.resIcon16.save;
			btnSearch.Image = Function.resIcon16.search_file;
			btnCondition_reset.Image = Function.resIcon16.redo;

			btnExcelSave.Image = Function.resIcon16.Excel;

			vari.ImgList.Images.Add(Function.resIcon16.server);
			vari.ImgList.Images.Add(Function.resIcon16.search_web);

			tabControl1.ImageList = vari.ImgList;
			tabMonitoring.ImageIndex = 0;
			tabSearching.ImageIndex = 1;


			clsLog = new Function.Util.Log(vari.Pgm_Path + "\\log", "log", 0, true);

			strTest = (@"W0LJC7E8XHB2432045777F06970G30OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432055778F06971G31OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432065779F06972G32OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432075780F06973G33OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432085781F06974G34OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432095782F06975G35OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432105783F06976G36OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432115784F06977G37OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432125785F06978G38OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432135786F06979G39OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432145787F06980G40OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432155788F06981G41OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432165789F06982G42OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432175790F06983G43OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432185791F06984G44OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432195792F06985G45OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432205793F06986G46OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432215794F06987G47OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432225795F06988G48OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432235796F06989G49OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK
W0LJC7E8XHB2432245797F06990G50OK10017093OK10027093OK10037093OK10048001OK10047093OK10057093OK10067007OK10077093OK10081011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK10157705OK115A7093OK115B7093OK1016116BOK70937099OK10177093OK10187093OK118B7093OK"
).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


		}

		/// <summary>
		/// 수신된 데이터 처리 부
		/// </summary>
		/// <param name="data"></param>
		void Data_Proc(string data)
		{
			try
			{
				clsLog.WLog($"Data를 수신 했습니다.\r\n\t\t {data}");

				string vin = Fnc.StringGet(ref data, 17);
				string trimin = Fnc.StringGet(ref data, 4);
				string pono = Fnc.StringGet(ref data, 6);
				string cartype = Fnc.StringGet(ref data, 3);
				string rst = Fnc.StringGet(ref data, 2);

				string log = $"[PONO]{pono} [TrimIn]{trimin} [CarType]{cartype} [Vin]{vin} [Result]{rst}";

				//db에 저장한다.
				dba.Data_Insert(vin, trimin, pono, cartype, rst, data);
				MoniLogAdd("Data처리", log);

				SetMessage(false, "Data처리 " + log, false);

			}
			catch(Exception ex)
			{
				ProcException(ex, "Data_Proc");
			}

		}

		/// <summary>
		/// 모니터링 로그를 추가한다.
		/// </summary>
		/// <param name="gbn"></param>
		/// <param name="log"></param>
		private void MoniLogAdd(string gbn, string log, bool isError = false)
		{
			ListViewItem li = new ListViewItem(new string[] { string.Empty, Fnc.Date2String(DateTime.Now, Fnc.enDateType.DateTime), gbn, log });
			lstMoniLog.Items.Insert(0, li);

			//최대 로그 수를 유지한다.
			while(lstMoniLog.Items.Count > vari.iLogMaxCnt)
			{
				lstMoniLog.Items.RemoveAt(lstMoniLog.Items.Count - 1);
			}

		}



		/// <summary>
		/// 콤보박스의 선택된 값을 가져 온다.
		/// </summary>
		/// <param name="ip"></param>
		/// <returns></returns>
		private string Cond_Value_Get(usrInputBox ip)
		{			
			string[] cond = null;

			switch(ip.Tag.ToString())
			{
				case "CarType":
					cond = cond_cartype;
					break;

				case "Result":
					cond = cond_result;
					break;
			}

			if (cond == null) return string.Empty;

			return cond[ip.ComboBoxSelectIndex];

		}


		
		protected override void Form_Init()
		{
			try
			{
				//운영모드 확인
				if(vari.OpMode == vari.enOpMode.Monitoring)
				{   //모니터링
					if (!tabControl1.TabPages.Contains(tabMonitoring)) tabControl1.TabPages.Insert(0, tabMonitoring);
				}
				else
				{   //조화 Only
					tabControl1.TabPages.Remove(tabMonitoring);					
				}

				//코드 정보 로드
				vari.DB_CodeDetail_Load();

				//plc 연결 정보 초기화
				if (opc != null) opc.Dispose();

				Application.DoEvents();

				//opc = new PLCModule.clsPLCModule(PLCModule.enPlcType.AB, vari.plc.RSLINX_ID, vari.plc.RSLINX_ID, "Torque", "Torque", 1000, "Torque_PLC");
				//opc.AddAddress(new string[] { vari.plc.Add_Trigger, vari.plc.Add_Ack, vari.plc.Add_Data });
				//opc.OnChConnectionStatus += Opc_OnChConnectionStatus; 


				Search_Conditon_Reset();


			}
			catch(Exception ex)
			{
				ProcException(ex, "Form_Init");
			}

		}

		/// <summary>
		/// plc상태 변경
		/// </summary>
		/// <param name="bolSocketStats"></param>
		private void Opc_OnChConnectionStatus(bool bolSocketStats)
		{
			
		}
		

		/// <summary>
		/// 조회 조건 초기화
		/// </summary>
		private void Search_Conditon_Reset()
		{
			string date = DateTime.Now.ToString("yyyy-MM-dd");

			dtFrom.Value = Fnc.String2Date(date + " 00:00:00", Fnc.enDateType.DateTime);
			dtTo.Value = Fnc.String2Date(date + " 23:59:59", Fnc.enDateType.DateTime);

			inpCartype.ComboBoxSelectIndex = 0;
			inpPono.Value = string.Empty;
			inpTrimin.Value = string.Empty;
			inpVin.Value = string.Empty;
			inpResult.ComboBoxSelectIndex = 0;

		}







		/// <summary>
		/// 환경 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSetting_Click(object sender, EventArgs e)
		{
			popSetting frm = new popSetting();
			if (frm.ShowDialog(this) == DialogResult.OK)
				Form_Init();
		}

		/// <summary>
		/// 수신테스트 버튼
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTest_Click(object sender, EventArgs e)
		{
			if (iTest >= strTest.Length) iTest = 0;

			Data_Proc(strTest[iTest]);

			iTest++;

		}

		/// <summary>
		/// 폼 크기가 변경 되었을때 화면처리를 한다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmMain_SizeChanged(object sender, EventArgs e)
		{
			//모니터링 로그 컬럼 사이즈
			int width = 0;
			for(int i = 0; i< lstMoniLog.Columns.Count-1; i++)
			{
				width += lstMoniLog.Columns[i].Width;
			}

			width = this.Width - width - 55;
			width = width > 0 ? width : 0;

			lstMoniLog.Columns[lstMoniLog.Columns.Count - 1].Width = width;

			

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// 조회 조건 초기화
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCondition_reset_Click(object sender, EventArgs e)
		{
			Search_Conditon_Reset();
		}

		/// <summary>
		/// 조건 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime dtF;
				DateTime dtT;
				string cartype, pono, trimin, vin, rst;


				if(dtFrom.Value < dtTo.Value)
				{
					dtF = dtFrom.Value;
					dtT = dtTo.Value;
				}
				else
				{
					dtT = dtFrom.Value;
					dtF = dtTo.Value;
				}

				cartype = Cond_Value_Get(inpCartype);
				pono = inpPono.TEXT.Trim();
				trimin = inpTrimin.TEXT.Trim();
				vin = inpVin.TEXT.Trim();
				rst = Cond_Value_Get(inpResult);

				DataTable dt = dba.Data_Search(dtF, dtT, cartype, pono, vin, trimin, rst);

				grdSearch.DataSource = dt;

				foreach(DataGridViewColumn c in grdSearch.Columns)
				{
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				}
				

				SetMessage(false, $"{dt.Rows.Count}건이 조회 되었습니다.", false);			


			}
			catch(Exception ex)
			{
				ProcException(ex, "btnSearch_Click");
			}

		}

		private void btnExcelSave_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = grdSearch.DataSource as DataTable;

				if(dt == null)
				{
					clsFunction.ShowMsg("엑셀저장 오류", "조회 후 엑셀 저장을 하여 주세요.", frmMessage.enMessageType.OK);
					return;
				}

				SaveFileDialog f = new SaveFileDialog();
				f.RestoreDirectory = true;
				f.Filter = "CSV|*.csv|모든파일|*.*";
				if (f.ShowDialog(this) != DialogResult.OK) return;

				Function.clsFunction.DataTable2CSV(dt, f.FileName);

				clsFunction.ShowMsg("엑셀저장", $"'{f.FileName}' 파일로 저장 되었습니다.", frmMessage.enMessageType.OK);


			}
			catch (Exception ex)
			{
				ProcException(ex, "btnExcelSave_Click");
			}
		}
	}
}
