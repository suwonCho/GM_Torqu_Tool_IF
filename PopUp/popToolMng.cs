using Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GM_Torqu_Tool_IF
{
	/// <summary>
	/// 툴 이름, 결과 이름 관리 폼
	/// </summary>
	public partial class popToolMng : Function.form.subBaseForm
	{
		public popToolMng()
		{
			InitializeComponent();

			btnRst_Save.Image = Function.resIcon16.ok;
			btnTool_Save.Image = Function.resIcon16.ok;

			btnSave.Image = Function.resIcon16.saveas_alt;
			btnCancel.Image = Function.resIcon16.delete_alt;

		}


		protected override void Form_Init()
		{
			ListViewItem li;
			DataRow[] row;

			

			//툴 이름 바인딩 T01~T25
			for (int i=0;i < vari.tool_max_lenth;i++)
			{
				li = new ListViewItem();
//				li.SubItems.Add(string.Empty);
				li.SubItems.Add((i + 1).ToString());

				row = vari.dt_tool_name.Select($"CODEVALUE = 'T{i+1:D2}'");

				if(row.Length > 0)
				{
					li.SubItems.Add(Fnc.obj2String(row[0]["CODEVALUENAME"]));
				}
				else
				{
					li.SubItems.Add(string.Empty);
				}

				lstToolName.Items.Add(li);
			}

			lstToolName_SelectedIndexChanged(null, null);

			//툴 이름 바인딩 N01~N03
			for (int i = 0; i < vari.rst_max_lenth; i++)
			{
				li = new ListViewItem();
				//li.SubItems.Add(string.Empty);
				li.SubItems.Add((i + 1).ToString());

				row = vari.dt_rst_name.Select($"CODEVALUE = 'N{i+1:D2}'");

				if (row.Length > 0)
				{
					li.SubItems.Add(Fnc.obj2String(row[0]["CODEVALUENAME"]));
				}
				else
				{
					li.SubItems.Add(string.Empty);
				}

				lstRst.Items.Add(li);
			}

			lstRst_SelectedIndexChanged(null, null);

		}
		


		private void lstToolName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstToolName.SelectedItems.Count < 1)
			{
				inpTool_No.Value = string.Empty;
				inpTool_Name.Value = string.Empty;
				btnTool_Save.Enabled = false;
				return;
			}


			ListViewItem li = lstToolName.SelectedItems[0];

			inpTool_No.Value = li.SubItems[1].Text;
			inpTool_Name.Value = li.SubItems[2].Text;

			btnTool_Save.Enabled = true;

		}

		private void lstRst_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (lstRst.SelectedItems.Count < 1)
			{
				inpRst_No.Value = string.Empty;
				inpRst_Name.Value = string.Empty;
				btnRst_Save.Enabled = false;
				return;
			}


			ListViewItem li = lstRst.SelectedItems[0];

			inpRst_No.Value = li.SubItems[1].Text;
			inpRst_Name.Value = li.SubItems[2].Text;

			btnRst_Save.Enabled = true;
		}


		private void btnTool_Save_Click(object sender, EventArgs e)
		{
			if (lstToolName.SelectedItems.Count < 1) return;

			ListViewItem li = lstToolName.SelectedItems[0];

			li.SubItems[2].Text = inpTool_Name.Text;
			inpTool_Name.Commit();
		}

		private void btnRst_Save_Click(object sender, EventArgs e)
		{
			if (lstRst.SelectedItems.Count < 1) return;

			ListViewItem li = lstRst.SelectedItems[0];

			li.SubItems[2].Text = inpRst_Name.Text;
			inpRst_Name.Commit();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (Function.clsFunction.ShowMsg("저장 확인", "툴 이름과 결과 이름의 변경된 내용을 저장 하시겠습니까?", Function.form.frmMessage.enMessageType.YesNo) != DialogResult.Yes) return;


				DataRow[] row;
				DataRow r;

				//지우고 다시 입력 한다.
				vari.dt_tool_name.Rows.Clear();

				//datatable에 반영 한다.			
				foreach (ListViewItem li in lstToolName.Items)
				{
					int no = Fnc.obj2int(li.SubItems[1].Text);
					string nm = Fnc.obj2String(li.SubItems[2].Text);

					r = vari.dt_tool_name.NewRow();
					r["CODEVALUE"] = $"T{no:D2}";
					r["CODEVALUENAME"] = nm;

					vari.dt_tool_name.Rows.Add(r);

				}


				//지우고 다시 입력 한다.
				vari.dt_rst_name.Rows.Clear();

				//datatable에 반영 한다.			
				foreach (ListViewItem li in lstRst.Items)
				{
					int no = Fnc.obj2int(li.SubItems[1].Text);
					string nm = Fnc.obj2String(li.SubItems[2].Text);

					r = vari.dt_rst_name.NewRow();
					r["CODEVALUE"] = $"N{no:D2}";
					r["CODEVALUENAME"] = nm;

					vari.dt_rst_name.Rows.Add(r);

				}


				//db에 저장한다.
				dba.codedetail_save("TOOL_NAME", vari.dt_tool_name);

				dba.codedetail_save("RST_NAME", vari.dt_rst_name);


				Function.clsFunction.ShowMsg("저장 완료", "툴 이름과 결과 이름이 저장 되었습니다.", Function.form.frmMessage.enMessageType.OK);

				this.Close();
			}
			catch(Exception ex)
			{
				clsFunction.ShowMsg("오류발생", ex.InnerException.Message, Function.form.frmMessage.enMessageType.OK);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
