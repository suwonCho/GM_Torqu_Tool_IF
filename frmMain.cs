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
		}
	}
}
