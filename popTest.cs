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
using System.Threading;

namespace GM_Torqu_Tool_IF
{
	public partial class popTest : Function.form.subBaseForm
	{
		/// <summary>
		/// 조건 차종 배열
		/// </summary>
		string[] cond_cartype = new string[] { "", "G30", "T30" };

		/// <summary>
		/// 조건 결과 배열
		/// </summary>
		string[] cond_result = new string[] { "", "OK", "NG" };

		bool isRun = false;
		
		public popTest()
		{
			InitializeComponent();
		}

		private void popTest_Load(object sender, EventArgs e)
		{
			inpSeq.Value = vari.iTestSeq.ToString();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			if(isRun)
			{

			}
			else
			{

			}
		}
	}
}
