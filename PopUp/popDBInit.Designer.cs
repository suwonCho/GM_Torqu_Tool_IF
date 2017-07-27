namespace GM_Torqu_Tool_IF
{
	partial class popDBInit
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
			this.inpConn = new Function.form.usrInputBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDBInit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.inpDBName = new Function.form.usrInputBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inpConn
			// 
			this.inpConn.BackColor = System.Drawing.SystemColors.Control;
			this.inpConn.ChangeMark_Visable = false;
			this.inpConn.ComboBoxDataSource = null;
			this.inpConn.ComboBoxDisplayMember = "";
			this.inpConn.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpConn.ComboBoxSelectedValue = null;
			this.inpConn.ComboBoxSelectIndex = -1;
			this.inpConn.ComboBoxSelectItem = null;
			this.inpConn.ComboBoxValueMember = "";
			this.inpConn.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpConn.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpConn.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpConn.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpConn.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpConn.DLabel_FontAutoSize = false;
			this.inpConn.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpConn.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpConn.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpConn.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpConn.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpConn.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpConn.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpConn.Label_Text = "DB연결상태 ";
			this.inpConn.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpConn.Label_Visable = true;
			this.inpConn.LabelWidth = 80;
			this.inpConn.Location = new System.Drawing.Point(0, 3);
			this.inpConn.Multiline = false;
			this.inpConn.Name = "inpConn";
			this.inpConn.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpConn.Size = new System.Drawing.Size(319, 24);
			this.inpConn.TabIndex = 1;
			this.inpConn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpConn.TextBox_AcceptsTab = false;
			this.inpConn.TextBox_MaxLength = 32767;
			this.inpConn.TextBox_PasswordChar = '\0';
			this.inpConn.TextBox_TabStopsLength = 8;
			this.inpConn.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpConn.Value = "";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(259, 88);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "닫 기";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDBInit
			// 
			this.btnDBInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDBInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDBInit.Location = new System.Drawing.Point(189, 88);
			this.btnDBInit.Name = "btnDBInit";
			this.btnDBInit.Size = new System.Drawing.Size(64, 23);
			this.btnDBInit.TabIndex = 11;
			this.btnDBInit.Text = "작업시작";
			this.btnDBInit.UseVisualStyleBackColor = true;
			this.btnDBInit.Click += new System.EventHandler(this.btnDBInit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(0, 88);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 13;
			this.btnReset.Text = "설정초기화";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// inpDBName
			// 
			this.inpDBName.BackColor = System.Drawing.SystemColors.Control;
			this.inpDBName.ChangeMark_Visable = true;
			this.inpDBName.ComboBoxDataSource = null;
			this.inpDBName.ComboBoxDisplayMember = "";
			this.inpDBName.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpDBName.ComboBoxSelectedValue = null;
			this.inpDBName.ComboBoxSelectIndex = -1;
			this.inpDBName.ComboBoxSelectItem = null;
			this.inpDBName.ComboBoxValueMember = "";
			this.inpDBName.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpDBName.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpDBName.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpDBName.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpDBName.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpDBName.DLabel_FontAutoSize = false;
			this.inpDBName.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpDBName.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpDBName.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpDBName.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpDBName.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpDBName.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpDBName.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpDBName.Label_Text = "DB 이름";
			this.inpDBName.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpDBName.Label_Visable = true;
			this.inpDBName.LabelWidth = 80;
			this.inpDBName.Location = new System.Drawing.Point(0, 33);
			this.inpDBName.Multiline = false;
			this.inpDBName.Name = "inpDBName";
			this.inpDBName.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpDBName.Size = new System.Drawing.Size(319, 23);
			this.inpDBName.TabIndex = 14;
			this.inpDBName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpDBName.TextBox_AcceptsTab = false;
			this.inpDBName.TextBox_MaxLength = 32767;
			this.inpDBName.TextBox_PasswordChar = '\0';
			this.inpDBName.TextBox_TabStopsLength = 8;
			this.inpDBName.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpDBName.Value = "TorqueTool";
			// 
			// lblMsg
			// 
			this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMsg.Location = new System.Drawing.Point(3, 62);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(320, 23);
			this.lblMsg.TabIndex = 15;
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// popDBInit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 114);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.inpDBName);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDBInit);
			this.Controls.Add(this.inpConn);
			this.isUseFormInit = true;
			this.Name = "popDBInit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "DB 초기화";
			this.ResumeLayout(false);

		}

		#endregion

		private Function.form.usrInputBox inpConn;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDBInit;
		private System.Windows.Forms.Button btnReset;
		private Function.form.usrInputBox inpDBName;
		private System.Windows.Forms.Label lblMsg;
	}
}