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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnIF = new System.Windows.Forms.Button();
			this.inpIF_Pass = new Function.form.usrInputBox();
			this.inpIF_ID = new Function.form.usrInputBox();
			this.inpIF_DB = new Function.form.usrInputBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.inpConn.Location = new System.Drawing.Point(6, 20);
			this.inpConn.Multiline = false;
			this.inpConn.Name = "inpConn";
			this.inpConn.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpConn.Size = new System.Drawing.Size(361, 24);
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
			this.btnClose.Location = new System.Drawing.Point(314, 327);
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
			this.btnDBInit.Location = new System.Drawing.Point(206, 76);
			this.btnDBInit.Name = "btnDBInit";
			this.btnDBInit.Size = new System.Drawing.Size(172, 23);
			this.btnDBInit.TabIndex = 11;
			this.btnDBInit.Text = "DB 및 테이블 생성";
			this.btnDBInit.UseVisualStyleBackColor = true;
			this.btnDBInit.Click += new System.EventHandler(this.btnDBInit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(0, 327);
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
			this.inpDBName.Location = new System.Drawing.Point(6, 50);
			this.inpDBName.Multiline = false;
			this.inpDBName.Name = "inpDBName";
			this.inpDBName.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpDBName.Size = new System.Drawing.Size(361, 23);
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
			this.lblMsg.Location = new System.Drawing.Point(3, 229);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(375, 95);
			this.lblMsg.TabIndex = 15;
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.inpConn);
			this.groupBox1.Controls.Add(this.btnDBInit);
			this.groupBox1.Controls.Add(this.inpDBName);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(379, 105);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DB 및 테이블 생성";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnIF);
			this.groupBox2.Controls.Add(this.inpIF_Pass);
			this.groupBox2.Controls.Add(this.inpIF_ID);
			this.groupBox2.Controls.Add(this.inpIF_DB);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 105);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(379, 121);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "I/F 정보 설정";
			// 
			// btnIF
			// 
			this.btnIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIF.Location = new System.Drawing.Point(206, 92);
			this.btnIF.Name = "btnIF";
			this.btnIF.Size = new System.Drawing.Size(172, 23);
			this.btnIF.TabIndex = 18;
			this.btnIF.Text = "DB Link 및 프로시져 생성";
			this.btnIF.UseVisualStyleBackColor = true;
			this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
			// 
			// inpIF_Pass
			// 
			this.inpIF_Pass.BackColor = System.Drawing.SystemColors.Control;
			this.inpIF_Pass.ChangeMark_Visable = true;
			this.inpIF_Pass.ComboBoxDataSource = null;
			this.inpIF_Pass.ComboBoxDisplayMember = "";
			this.inpIF_Pass.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpIF_Pass.ComboBoxSelectedValue = null;
			this.inpIF_Pass.ComboBoxSelectIndex = -1;
			this.inpIF_Pass.ComboBoxSelectItem = null;
			this.inpIF_Pass.ComboBoxValueMember = "";
			this.inpIF_Pass.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpIF_Pass.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpIF_Pass.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpIF_Pass.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpIF_Pass.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpIF_Pass.DLabel_FontAutoSize = false;
			this.inpIF_Pass.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_Pass.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_Pass.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpIF_Pass.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpIF_Pass.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpIF_Pass.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpIF_Pass.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_Pass.Label_Text = "상대 DB 암호";
			this.inpIF_Pass.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_Pass.Label_Visable = true;
			this.inpIF_Pass.LabelWidth = 80;
			this.inpIF_Pass.Location = new System.Drawing.Point(6, 68);
			this.inpIF_Pass.Multiline = false;
			this.inpIF_Pass.Name = "inpIF_Pass";
			this.inpIF_Pass.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpIF_Pass.Size = new System.Drawing.Size(361, 23);
			this.inpIF_Pass.TabIndex = 17;
			this.inpIF_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_Pass.TextBox_AcceptsTab = false;
			this.inpIF_Pass.TextBox_MaxLength = 32767;
			this.inpIF_Pass.TextBox_PasswordChar = '\0';
			this.inpIF_Pass.TextBox_TabStopsLength = 8;
			this.inpIF_Pass.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpIF_Pass.Value = "";
			// 
			// inpIF_ID
			// 
			this.inpIF_ID.BackColor = System.Drawing.SystemColors.Control;
			this.inpIF_ID.ChangeMark_Visable = true;
			this.inpIF_ID.ComboBoxDataSource = null;
			this.inpIF_ID.ComboBoxDisplayMember = "";
			this.inpIF_ID.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpIF_ID.ComboBoxSelectedValue = null;
			this.inpIF_ID.ComboBoxSelectIndex = -1;
			this.inpIF_ID.ComboBoxSelectItem = null;
			this.inpIF_ID.ComboBoxValueMember = "";
			this.inpIF_ID.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpIF_ID.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpIF_ID.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpIF_ID.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpIF_ID.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpIF_ID.DLabel_FontAutoSize = false;
			this.inpIF_ID.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_ID.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_ID.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpIF_ID.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpIF_ID.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpIF_ID.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpIF_ID.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_ID.Label_Text = "상대 DB ID";
			this.inpIF_ID.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_ID.Label_Visable = true;
			this.inpIF_ID.LabelWidth = 80;
			this.inpIF_ID.Location = new System.Drawing.Point(6, 43);
			this.inpIF_ID.Multiline = false;
			this.inpIF_ID.Name = "inpIF_ID";
			this.inpIF_ID.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpIF_ID.Size = new System.Drawing.Size(361, 23);
			this.inpIF_ID.TabIndex = 16;
			this.inpIF_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_ID.TextBox_AcceptsTab = false;
			this.inpIF_ID.TextBox_MaxLength = 32767;
			this.inpIF_ID.TextBox_PasswordChar = '\0';
			this.inpIF_ID.TextBox_TabStopsLength = 8;
			this.inpIF_ID.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpIF_ID.Value = "sa";
			// 
			// inpIF_DB
			// 
			this.inpIF_DB.BackColor = System.Drawing.SystemColors.Control;
			this.inpIF_DB.ChangeMark_Visable = true;
			this.inpIF_DB.ComboBoxDataSource = null;
			this.inpIF_DB.ComboBoxDisplayMember = "";
			this.inpIF_DB.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpIF_DB.ComboBoxSelectedValue = null;
			this.inpIF_DB.ComboBoxSelectIndex = -1;
			this.inpIF_DB.ComboBoxSelectItem = null;
			this.inpIF_DB.ComboBoxValueMember = "";
			this.inpIF_DB.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpIF_DB.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpIF_DB.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpIF_DB.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpIF_DB.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpIF_DB.DLabel_FontAutoSize = false;
			this.inpIF_DB.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_DB.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_DB.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpIF_DB.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpIF_DB.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpIF_DB.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpIF_DB.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpIF_DB.Label_Text = "상대 DB IP";
			this.inpIF_DB.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_DB.Label_Visable = true;
			this.inpIF_DB.LabelWidth = 80;
			this.inpIF_DB.Location = new System.Drawing.Point(6, 17);
			this.inpIF_DB.Multiline = false;
			this.inpIF_DB.Name = "inpIF_DB";
			this.inpIF_DB.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpIF_DB.Size = new System.Drawing.Size(361, 23);
			this.inpIF_DB.TabIndex = 15;
			this.inpIF_DB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpIF_DB.TextBox_AcceptsTab = false;
			this.inpIF_DB.TextBox_MaxLength = 32767;
			this.inpIF_DB.TextBox_PasswordChar = '\0';
			this.inpIF_DB.TextBox_TabStopsLength = 8;
			this.inpIF_DB.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpIF_DB.Value = "";
			// 
			// popDBInit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 353);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnClose);
			this.isUseFormInit = true;
			this.Name = "popDBInit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "DB 초기화";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Function.form.usrInputBox inpConn;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDBInit;
		private System.Windows.Forms.Button btnReset;
		private Function.form.usrInputBox inpDBName;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Function.form.usrInputBox inpIF_Pass;
		private Function.form.usrInputBox inpIF_ID;
		private Function.form.usrInputBox inpIF_DB;
		private System.Windows.Forms.Button btnIF;
	}
}