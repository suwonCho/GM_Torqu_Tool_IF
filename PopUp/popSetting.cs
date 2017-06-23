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
	public partial class popSetting : Form
	{
		public popSetting()
		{
			InitializeComponent();
		}

		/// <summary>
		/// DB 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtSQL_Setting_Click(object sender, Function.form.usrEventArgs e)
		{
			Function.form.Db.DBSetting con = new Function.form.Db.DBSetting(vari.conn);

			con.ShowDialog(this);

		}
	}
}
