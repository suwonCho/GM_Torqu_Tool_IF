using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Function;
using Function.Db;

namespace GM_Torqu_Tool_IF
{
	public partial class popDBInit : Function.form.subBaseForm
	{

		MsSQL.strConnect conn;

		Control[] ctrls;

		public popDBInit()
		{
			InitializeComponent();

			conn = vari.conn;
			conn.strDataBase = "master";

			ctrls = new Control[] { inpDBName, btnDBInit };

		}

		protected override void Form_Init()
		{
			try
			{
				 MsSQL.fnc_date_get(conn);

				inpConn.Value = "정상 연결";
				inpConn.Label_BackColor = Color.RoyalBlue;
			}
			catch
			{
				inpConn.Value = "연결오류-MS SQL 환경설정을 하여 주십시요";
				inpConn.Label_BackColor = Color.RoyalBlue;

				foreach(Control c in ctrls)
				{
					c.Enabled = false;
				}
			}
		}


		private void btnReset_Click(object sender, EventArgs e)
		{
			inpDBName.Value = "TorqueTool";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDBInit_Click(object sender, EventArgs e)
		{
			try
			{

				lblMsg.Text = "";

				Application.DoEvents();

				string db = inpDBName.Text.Trim();

				string path = MsSQL.fnc_filepath_get(conn) + "\\";

				if(MsSQL.fnc_DataBase_Exists(conn, db))
				{
					if (clsFunction.ShowMsg(this, "DB 중복 확인", "같은 이름에 데이터베이스가 존재 합니다. 삭제하고 다시 생성 합니까?\r\n(기존데이터는 전부 삭제 됩니다.)", Function.form.frmMessage.enMessageType.YesNo) != DialogResult.Yes) return;

					if (clsFunction.ShowMsg(this, "(재확인)DB 중복 확인", "(재확인)같은 이름에 데이터베이스가 존재 합니다. 삭제하고 다시 생성 합니까?\r\n(기존데이터는 전부 삭제 됩니다.)", Function.form.frmMessage.enMessageType.YesNo) != DialogResult.Yes) return;

					MsSQL.fnc_DataBase_drop(conn, db);
				}
				else
					if (clsFunction.ShowMsg(this, "DB 생성 확인", "데이터 베이스를 생성 하시겠습니까?", Function.form.frmMessage.enMessageType.YesNo) != DialogResult.Yes) return;

				lblMsg.Text = "데이터 베이스 생성을 시작합니다.";
				Application.DoEvents();

				//db 생성
				dba_init.db_create(conn, db, path);

				conn.strDataBase = db;

				//table 생성
				dba_init.tables_create(conn);

				//data insert
				dba_init.data_insert(conn);

				lblMsg.Text = "데이터 베이스 생성을 완료 했습니다.";

				if (clsFunction.ShowMsg(this, "DB 생성 완료", "데이터 베이스를 생성이 완료 되었습니다.\r\n 데이터 베이스 설정을 현재 생성된 DB로 변경 하시겠습니까?", Function.form.frmMessage.enMessageType.YesNo) == DialogResult.Yes)
				{
					vari.conn.strDataBase = conn.strDataBase;
					vari.DB_Setting_Save();
				}
				
			}
			catch(Exception ex)
			{
				Function.form.control.Invoke_Control_Text(lblMsg, ex.InnerException.Message);
			}
		}
	}
}
