namespace GM_Torqu_Tool_IF
{
	partial class popTorqueImage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popTorqueImage));
			this.pnlImage = new System.Windows.Forms.Panel();
			this.inpPicSizeMode = new Function.form.usrInputBox();
			this.pnlImage.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlImage
			// 
			this.pnlImage.Controls.Add(this.inpPicSizeMode);
			this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlImage.Location = new System.Drawing.Point(0, 0);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(856, 562);
			this.pnlImage.TabIndex = 0;
			// 
			// inpPicSizeMode
			// 
			this.inpPicSizeMode.BackColor = System.Drawing.Color.Transparent;
			this.inpPicSizeMode.ChangeMark_Visable = false;
			this.inpPicSizeMode.ComboBoxDataSource = null;
			this.inpPicSizeMode.ComboBoxDisplayMember = "";
			this.inpPicSizeMode.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPicSizeMode.ComboBoxSelectedValue = null;
			this.inpPicSizeMode.ComboBoxSelectIndex = -1;
			this.inpPicSizeMode.ComboBoxSelectItem = null;
			this.inpPicSizeMode.ComboBoxValueMember = "";
			this.inpPicSizeMode.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpPicSizeMode.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPicSizeMode.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPicSizeMode.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPicSizeMode.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpPicSizeMode.DLabel_FontAutoSize = false;
			this.inpPicSizeMode.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPicSizeMode.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPicSizeMode.InputType = Function.form.usrInputBox.enInputType.COMBO;
			this.inpPicSizeMode.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPicSizeMode.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPicSizeMode.Label_Font = new System.Drawing.Font("굴림체", 9F);
			this.inpPicSizeMode.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPicSizeMode.Label_Text = "SizeMode";
			this.inpPicSizeMode.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpPicSizeMode.Label_Visable = true;
			this.inpPicSizeMode.LabelWidth = 60;
			this.inpPicSizeMode.Location = new System.Drawing.Point(6, 4);
			this.inpPicSizeMode.Multiline = false;
			this.inpPicSizeMode.Name = "inpPicSizeMode";
			this.inpPicSizeMode.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPicSizeMode.Size = new System.Drawing.Size(215, 22);
			this.inpPicSizeMode.TabIndex = 2;
			this.inpPicSizeMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPicSizeMode.TextBox_AcceptsTab = false;
			this.inpPicSizeMode.TextBox_MaxLength = 32767;
			this.inpPicSizeMode.TextBox_PasswordChar = '\0';
			this.inpPicSizeMode.TextBox_TabStopsLength = 8;
			this.inpPicSizeMode.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPicSizeMode.Value = "";
			this.inpPicSizeMode.Text_Changed += new Function.form.usrEventHander(this.inpPicSizeMode_Text_Changed);
			// 
			// popTorqueImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 562);
			this.Controls.Add(this.pnlImage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "popTorqueImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TorqueImage";
			this.Load += new System.EventHandler(this.popTorqueImage_Load);
			this.pnlImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlImage;
		private Function.form.usrInputBox inpPicSizeMode;
	}
}