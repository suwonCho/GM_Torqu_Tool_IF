namespace GM_Torqu_Tool_IF
{
	partial class popSetting
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
			this.txtSQL_Setting = new Function.form.usrInputBox();
			this.SuspendLayout();
			// 
			// txtSQL_Setting
			// 
			this.txtSQL_Setting.BackColor = System.Drawing.SystemColors.Control;
			this.txtSQL_Setting.ChangeMark_Visable = false;
			this.txtSQL_Setting.ComboBoxDataSource = null;
			this.txtSQL_Setting.ComboBoxDisplayMember = "";
			this.txtSQL_Setting.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtSQL_Setting.ComboBoxSelectedValue = null;
			this.txtSQL_Setting.ComboBoxSelectIndex = -1;
			this.txtSQL_Setting.ComboBoxSelectItem = null;
			this.txtSQL_Setting.ComboBoxValueMember = "";
			this.txtSQL_Setting.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtSQL_Setting.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.txtSQL_Setting.DLabel_BlinkColor = System.Drawing.Color.White;
			this.txtSQL_Setting.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSQL_Setting.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtSQL_Setting.DLabel_FontAutoSize = false;
			this.txtSQL_Setting.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSQL_Setting.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txtSQL_Setting.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.txtSQL_Setting.Label_BackColor = System.Drawing.Color.Transparent;
			this.txtSQL_Setting.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSQL_Setting.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.txtSQL_Setting.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtSQL_Setting.Label_Text = "MS SQL 환경설정";
			this.txtSQL_Setting.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtSQL_Setting.Label_Visable = true;
			this.txtSQL_Setting.LabelWidth = -1;
			this.txtSQL_Setting.Location = new System.Drawing.Point(5, 7);
			this.txtSQL_Setting.Multiline = false;
			this.txtSQL_Setting.Name = "txtSQL_Setting";
			this.txtSQL_Setting.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.txtSQL_Setting.Size = new System.Drawing.Size(248, 24);
			this.txtSQL_Setting.TabIndex = 0;
			this.txtSQL_Setting.TEXT = "환 경 설 정";
			this.txtSQL_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txtSQL_Setting.TextBox_AcceptsTab = false;
			this.txtSQL_Setting.TEXTBOX_PasswordChar = '\0';
			this.txtSQL_Setting.TextBox_TabStopsLength = 8;
			this.txtSQL_Setting.TextType = Function.form.usrInputBox.enTextType.All;
			this.txtSQL_Setting.Value = "환 경 설 정";
			this.txtSQL_Setting.Click += new Function.form.usrEventHander(this.txtSQL_Setting_Click);
			// 
			// popSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 350);
			this.Controls.Add(this.txtSQL_Setting);
			this.Font = new System.Drawing.Font("굴림", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "popSetting";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "환경 설정";
			this.ResumeLayout(false);

		}

		#endregion

		private Function.form.usrInputBox txtSQL_Setting;
	}
}