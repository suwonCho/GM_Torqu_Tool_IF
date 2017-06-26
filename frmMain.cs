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

				opc = new PLCModule.clsPLCModule(PLCModule.enPlcType.AB, vari.plc.RSLINX_ID, vari.plc.RSLINX_ID, "Torque", "Torque", 1000, "Torque_PLC");
				opc.AddAddress(new string[] { vari.plc.Add_Trigger, vari.plc.Add_Ack, vari.plc.Add_Data });
				opc.OnChConnectionStatus += Opc_OnChConnectionStatus; 
				opc.
				



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
			throw new NotImplementedException();
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
	}
}
