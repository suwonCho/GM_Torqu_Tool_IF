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
	public partial class popTorqueImage : Form
	{
		public popTorqueImage()
		{
			InitializeComponent();
		}

		private void popTorqueImage_Load(object sender, EventArgs e)
		{
			pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
			inpPicSizeMode.ComboBoxItems.AddRange(Fnc.EnumItems2Strings(new ImageLayout()));
			inpPicSizeMode.Value = pnlImage.BackgroundImageLayout.ToString();

			Image_Load();
		}

		private void inpPicSizeMode_Text_Changed(object sender, Function.form.usrEventArgs e)
		{
			pnlImage.BackgroundImageLayout = (ImageLayout)Fnc.enumItem2Object(new ImageLayout(), inpPicSizeMode.Text);
		}

		public void Image_Load()
		{
			//이미지
			if (System.IO.File.Exists(vari.TorqueImagePath))
			{
				try
				{
					pnlImage.BackgroundImage = new Bitmap(vari.TorqueImagePath);
				}
				catch (Exception ex)
				{
					pnlImage.BackgroundImage = null;					
				}
			}
			else
				pnlImage.BackgroundImage = null;
		}


	}
}
