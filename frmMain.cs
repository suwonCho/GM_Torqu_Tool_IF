﻿using System;
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

		public frmMain()
		{
			InitializeComponent();

			vari.Init();

			SavePosition_Setting = vari.Pgm_Setting;
			btnSetting.Image = Function.resIcon16.save;

			vari.ImgList.Images.Add(Function.resIcon16.server);
			vari.ImgList.Images.Add(Function.resIcon16.search_web);

			tabControl1.ImageList = vari.ImgList;
			tabMonitoring.ImageIndex = 0;
			tabSearching.ImageIndex = 1;


			clsLog = new Function.Util.Log(vari.Pgm_Path + "\\log", "log", 0, true);

			strTest = (@"W0LJC7E8XHB2432045777F06970G30OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432055778F06971G31OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432065779F06972G32OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432075780F06973G33OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432085781F06974G34OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432095782F06975G35OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432105783F06976G36OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432115784F06977G37OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432125785F06978G38OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432135786F06979G39OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432145787F06980G40OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432155788F06981G41OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432165789F06982G42OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432175790F06983G43OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432185791F06984G44OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432195792F06985G45OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432205793F06986G46OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432215794F06987G47OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432225795F06988G48OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432235796F06989G49OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK
W0LJC7E8XHB2432245797F06990G50OK10017093OK10027093OK10037093OK1004OK10047093OK10057093OK1006OK10077093OK10087093OK1011OK10127093OK112B7093OK10137093OK10147093OK114B7093OK1015OK115A7093OK115B7093OK1016OK116B7093OK10177093OK117BOK10187093OK118B7093OK"
).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


		}

		/// <summary>
		/// 수신된 데이터 처리 부
		/// </summary>
		/// <param name="data"></param>
		void Data_Proc(string data)
		{
			clsLog.WLog($"Data를 수신 했습니다. {data}");

			string vin = Fnc.StringGet(ref data, 17);
			string trimin = Fnc.StringGet(ref data, 6);
			string pono = Fnc.StringGet(ref data, 6);
			string cartype = Fnc.StringGet(ref data, 3);
			string rst = Fnc.StringGet(ref data, 2);

			string log = $"[PONO]{pono} [TrimIn]{trimin}";

		}

		private void MoniLogAdd(string gbn, string log)
		{

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
	}
}
