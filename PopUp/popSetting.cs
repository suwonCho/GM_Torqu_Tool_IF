using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Function;

namespace GM_Torqu_Tool_IF
{
	public partial class popSetting : Function.form.subBaseForm
	{

		DateTime dtF9 = DateTime.Now;

		Function.form.usrInputBox[] inpSetting;

		public popSetting()
		{
			InitializeComponent();

			btnSave.Image = Function.resIcon16.saveas_alt;
			btnCancel.Image = Function.resIcon16.delete_alt;

			inpSetting = new Function.form.usrInputBox[] { txtSQL_Setting, inpToolMng, inpDBInit };
		}

		protected override void Form_Init()
		{
			base.Form_Init();

			inpStationID.Value = vari.StationID;
			inpImagePath.Value = vari.TorqueImagePath;

			inpPLC_RsLinx_ID.Value = vari.plc.RSLINX_ID;
			inpPLC_Topic.Value = vari.plc.Topic_Name;
			inpPLC_Add_Trigger.Value = vari.plc.Add_Trigger;
			inpPLC_Add_Ack.Value = vari.plc.Add_Ack;
			inpPLC_Add_Data.Value = vari.plc.Add_Data;
			inpPLC_Add_Confirm.Value = vari.plc.Add_Confirm;
			inpPLC_Add_Info.Value = vari.plc.Add_Info;
			chkIF_Check.Checked = vari.bIF_Chk;

			chkWinStartUp.Checked = Function.clsFunction.StartUpPgm_isReg(vari.Pgm_Name, Application.ExecutablePath);

			inpOpMode.ComboBoxSelectIndex = (int)vari.OpMode;



		}





		/// <summary>
		/// DB 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtSQL_Setting_Click(object sender, Function.form.usrEventArgs e)
		{
			try
			{
				Function.form.Db.DBSetting con = new Function.form.Db.DBSetting(vari.conn);

				con.DbType_Changable = false;

				if (con.ShowDialog(this) != DialogResult.OK) return;

				//변경됨
				vari.conn = con.sql;

				vari.DB_Setting_Save();

				SetMessage(false, "MS-Sql DB 설정이 변경/저장 되었습니다.", true);

			}
			catch(Exception ex)
			{
				ProcException(ex, "txtSQL_Setting_Click", true);
			}
		}

		private void inpToolMng_Click(object sender, Function.form.usrEventArgs e)
		{
			try
			{
				popToolMng frm = new popToolMng();
				frm.ShowDialog();

				//inpStationID.Text
			}
			catch (Exception ex)
			{
				ProcException(ex, "inpToolMng_Click", true);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Function.form.usrInputBox[] inps = new Function.form.usrInputBox[] { inpStationID, inpPLC_RsLinx_ID, inpPLC_Topic, inpPLC_Add_Trigger, inpPLC_Add_Ack, inpPLC_Add_Data };

			foreach(Function.form.usrInputBox inp in inps)
			{
				if(inp.Text.Length < 1)
				{
					Function.clsFunction.ShowMsg(this, "설정입력", $"{inp.Label_Text}를 입력 하여 주십시요.", Function.form.frmMessage.enMessageType.OK);
					return;
				}
			}


			if (Function.clsFunction.ShowMsg("저장 확인", "변경된 내용을 저장 하시겠습니까?", Function.form.frmMessage.enMessageType.YesNo) != DialogResult.Yes) return;

			vari.StationID = inpStationID.Text;
			vari.TorqueImagePath = inpImagePath.Text;
			vari.bIF_Chk = chkIF_Check.Checked;

			//윈도우 시작 시 시작			
			Function.clsFunction.StartUpPgm_Reg(chkWinStartUp.Checked, vari.Pgm_Name, Application.ExecutablePath);

			vari.plc.RSLINX_ID = inpPLC_RsLinx_ID.Text.Trim();
			vari.plc.Topic_Name = inpPLC_Topic.Text.Trim();
			vari.plc.Add_Trigger = inpPLC_Add_Trigger.Text.Trim();
			vari.plc.Add_Ack = inpPLC_Add_Ack.Text.Trim();
			vari.plc.Add_Data = inpPLC_Add_Data.Text.Trim();
			vari.plc.Add_Confirm = inpPLC_Add_Confirm.Text.Trim();
			vari.plc.Add_Info = inpPLC_Add_Info.Text.Trim();

			vari.OpMode = (vari.enOpMode)inpOpMode.ComboBoxSelectIndex;

			vari.PLC_Setting_Save();
			
			Function.clsFunction.ShowMsg("저장 완료", "설정이 저장 되었습니다.", Function.form.frmMessage.enMessageType.OK);

			this.DialogResult = DialogResult.OK;

			//this.Close();

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void popSetting_Load(object sender, EventArgs e)
		{

		}
		
		private void popSetting_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F9)
			{
				lock (this)
				{
					TimeSpan sp = DateTime.Now - dtF9;

					if (sp.TotalSeconds >= 0 && sp.TotalSeconds <= 0.3) return;

					bool vis = false;

					if (!txtSQL_Setting.Visible)					
					{
						if (!clsFunction.CheckPasswords("설정암호를 입력 하여 주세요.", "PISS")) return;

						vis = true;						
					}

					//Console.WriteLine("keydown {0} {1}", txtSQL_Setting.Visible, sp.TotalSeconds);

					foreach(Function.form.usrInputBox i in inpSetting)
					{
						i.Visible = vis;
					}
					

					dtF9 = DateTime.Now;
				}

			}
		}

		private void inpDBInit_Click(object sender, Function.form.usrEventArgs e)
		{
			try
			{
				popDBInit frm = new popDBInit();
				frm.ShowDialog();

				//inpStationID.Text
			}
			catch (Exception ex)
			{
				ProcException(ex, "inpDBInit_Click", true);
			}
		}

		private void btnImagePath_Click(object sender, EventArgs e)
		{
			OpenFileDialog f = new OpenFileDialog();
			f.Multiselect = false;
			//f.InitialDirectory = vari.TorqueImagePath;
			f.FileName = vari.TorqueImagePath;
			f.Filter = "이미지파일|*.bmp;*jpg;*png|모든파일|*.*";

			if (f.ShowDialog(this) != DialogResult.OK) return;

			inpImagePath.Text = f.FileName;
		}
	}
}
