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



			}
			catch(Exception ex)
			{
				ProcException(ex, "Form_Init");
			}

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
