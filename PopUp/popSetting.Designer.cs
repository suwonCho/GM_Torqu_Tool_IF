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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inpPLC_Add_Info = new Function.form.usrInputBox();
			this.inpPLC_Add_Confirm = new Function.form.usrInputBox();
			this.inpPLC_Add_Data = new Function.form.usrInputBox();
			this.inpPLC_Add_Ack = new Function.form.usrInputBox();
			this.inpPLC_Add_Trigger = new Function.form.usrInputBox();
			this.inpPLC_RsLinx_ID = new Function.form.usrInputBox();
			this.inpPLC_Topic = new Function.form.usrInputBox();
			this.inpToolMng = new Function.form.usrInputBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkWinStartUp = new System.Windows.Forms.CheckBox();
			this.inpOpMode = new Function.form.usrInputBox();
			this.inpStationID = new Function.form.usrInputBox();
			this.inpDBInit = new Function.form.usrInputBox();
			this.inpImagePath = new Function.form.usrInputBox();
			this.btnImagePath = new System.Windows.Forms.Button();
			this.chkIF_Check = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
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
			this.txtSQL_Setting.LabelWidth = 120;
			this.txtSQL_Setting.Location = new System.Drawing.Point(5, 107);
			this.txtSQL_Setting.Multiline = false;
			this.txtSQL_Setting.Name = "txtSQL_Setting";
			this.txtSQL_Setting.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.txtSQL_Setting.Size = new System.Drawing.Size(313, 24);
			this.txtSQL_Setting.TabIndex = 0;
			this.txtSQL_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.txtSQL_Setting.TextBox_AcceptsTab = false;
			this.txtSQL_Setting.TextBox_MaxLength = 32767;
			this.txtSQL_Setting.TextBox_PasswordChar = '\0';
			this.txtSQL_Setting.TextBox_TabStopsLength = 8;
			this.txtSQL_Setting.TextType = Function.form.usrInputBox.enTextType.All;
			this.txtSQL_Setting.Value = "환 경 설 정";
			this.txtSQL_Setting.Visible = false;
			this.txtSQL_Setting.Click += new Function.form.usrEventHander(this.txtSQL_Setting_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "PLC 환경 설정";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.inpPLC_Add_Info);
			this.panel1.Controls.Add(this.inpPLC_Add_Confirm);
			this.panel1.Controls.Add(this.inpPLC_Add_Data);
			this.panel1.Controls.Add(this.inpPLC_Add_Ack);
			this.panel1.Controls.Add(this.inpPLC_Add_Trigger);
			this.panel1.Controls.Add(this.inpPLC_RsLinx_ID);
			this.panel1.Controls.Add(this.inpPLC_Topic);
			this.panel1.Location = new System.Drawing.Point(3, 210);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(397, 183);
			this.panel1.TabIndex = 2;
			// 
			// inpPLC_Add_Info
			// 
			this.inpPLC_Add_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Add_Info.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Add_Info.ChangeMark_Visable = true;
			this.inpPLC_Add_Info.ComboBoxDataSource = null;
			this.inpPLC_Add_Info.ComboBoxDisplayMember = "";
			this.inpPLC_Add_Info.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Add_Info.ComboBoxSelectedValue = null;
			this.inpPLC_Add_Info.ComboBoxSelectIndex = -1;
			this.inpPLC_Add_Info.ComboBoxSelectItem = null;
			this.inpPLC_Add_Info.ComboBoxValueMember = "";
			this.inpPLC_Add_Info.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Add_Info.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Add_Info.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Add_Info.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Add_Info.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Add_Info.DLabel_FontAutoSize = false;
			this.inpPLC_Add_Info.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Info.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Info.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Add_Info.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Add_Info.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Add_Info.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Add_Info.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Info.Label_Text = "Info 주소";
			this.inpPLC_Add_Info.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Info.Label_Visable = true;
			this.inpPLC_Add_Info.LabelWidth = 75;
			this.inpPLC_Add_Info.Location = new System.Drawing.Point(3, 131);
			this.inpPLC_Add_Info.Multiline = false;
			this.inpPLC_Add_Info.Name = "inpPLC_Add_Info";
			this.inpPLC_Add_Info.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Info.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Info.TabIndex = 7;
			this.inpPLC_Add_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Info.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Info.TextBox_MaxLength = 32767;
			this.inpPLC_Add_Info.TextBox_PasswordChar = '\0';
			this.inpPLC_Add_Info.TextBox_TabStopsLength = 8;
			this.inpPLC_Add_Info.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Add_Info.Value = "";
			// 
			// inpPLC_Add_Confirm
			// 
			this.inpPLC_Add_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Add_Confirm.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Add_Confirm.ChangeMark_Visable = true;
			this.inpPLC_Add_Confirm.ComboBoxDataSource = null;
			this.inpPLC_Add_Confirm.ComboBoxDisplayMember = "";
			this.inpPLC_Add_Confirm.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Add_Confirm.ComboBoxSelectedValue = null;
			this.inpPLC_Add_Confirm.ComboBoxSelectIndex = -1;
			this.inpPLC_Add_Confirm.ComboBoxSelectItem = null;
			this.inpPLC_Add_Confirm.ComboBoxValueMember = "";
			this.inpPLC_Add_Confirm.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Add_Confirm.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Add_Confirm.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Add_Confirm.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Add_Confirm.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Add_Confirm.DLabel_FontAutoSize = false;
			this.inpPLC_Add_Confirm.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Confirm.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Confirm.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Add_Confirm.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Add_Confirm.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Add_Confirm.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Add_Confirm.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Confirm.Label_Text = "Confirm주소";
			this.inpPLC_Add_Confirm.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Confirm.Label_Visable = true;
			this.inpPLC_Add_Confirm.LabelWidth = 75;
			this.inpPLC_Add_Confirm.Location = new System.Drawing.Point(3, 107);
			this.inpPLC_Add_Confirm.Multiline = false;
			this.inpPLC_Add_Confirm.Name = "inpPLC_Add_Confirm";
			this.inpPLC_Add_Confirm.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Confirm.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Confirm.TabIndex = 6;
			this.inpPLC_Add_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Confirm.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Confirm.TextBox_MaxLength = 32767;
			this.inpPLC_Add_Confirm.TextBox_PasswordChar = '\0';
			this.inpPLC_Add_Confirm.TextBox_TabStopsLength = 8;
			this.inpPLC_Add_Confirm.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Add_Confirm.Value = "";
			// 
			// inpPLC_Add_Data
			// 
			this.inpPLC_Add_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Add_Data.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Add_Data.ChangeMark_Visable = true;
			this.inpPLC_Add_Data.ComboBoxDataSource = null;
			this.inpPLC_Add_Data.ComboBoxDisplayMember = "";
			this.inpPLC_Add_Data.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Add_Data.ComboBoxSelectedValue = null;
			this.inpPLC_Add_Data.ComboBoxSelectIndex = -1;
			this.inpPLC_Add_Data.ComboBoxSelectItem = null;
			this.inpPLC_Add_Data.ComboBoxValueMember = "";
			this.inpPLC_Add_Data.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Add_Data.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Add_Data.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Add_Data.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Add_Data.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Add_Data.DLabel_FontAutoSize = false;
			this.inpPLC_Add_Data.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Data.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Data.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Add_Data.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Add_Data.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Add_Data.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Add_Data.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Data.Label_Text = "Data 주소";
			this.inpPLC_Add_Data.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Data.Label_Visable = true;
			this.inpPLC_Add_Data.LabelWidth = 75;
			this.inpPLC_Add_Data.Location = new System.Drawing.Point(3, 155);
			this.inpPLC_Add_Data.Multiline = false;
			this.inpPLC_Add_Data.Name = "inpPLC_Add_Data";
			this.inpPLC_Add_Data.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Data.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Data.TabIndex = 5;
			this.inpPLC_Add_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Data.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Data.TextBox_MaxLength = 32767;
			this.inpPLC_Add_Data.TextBox_PasswordChar = '\0';
			this.inpPLC_Add_Data.TextBox_TabStopsLength = 8;
			this.inpPLC_Add_Data.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Add_Data.Value = "";
			// 
			// inpPLC_Add_Ack
			// 
			this.inpPLC_Add_Ack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Add_Ack.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Add_Ack.ChangeMark_Visable = true;
			this.inpPLC_Add_Ack.ComboBoxDataSource = null;
			this.inpPLC_Add_Ack.ComboBoxDisplayMember = "";
			this.inpPLC_Add_Ack.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Add_Ack.ComboBoxSelectedValue = null;
			this.inpPLC_Add_Ack.ComboBoxSelectIndex = -1;
			this.inpPLC_Add_Ack.ComboBoxSelectItem = null;
			this.inpPLC_Add_Ack.ComboBoxValueMember = "";
			this.inpPLC_Add_Ack.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Add_Ack.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Add_Ack.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Add_Ack.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Add_Ack.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Add_Ack.DLabel_FontAutoSize = false;
			this.inpPLC_Add_Ack.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Ack.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Ack.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Add_Ack.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Add_Ack.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Add_Ack.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Add_Ack.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Ack.Label_Text = "Ack 주소";
			this.inpPLC_Add_Ack.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Ack.Label_Visable = true;
			this.inpPLC_Add_Ack.LabelWidth = 75;
			this.inpPLC_Add_Ack.Location = new System.Drawing.Point(3, 82);
			this.inpPLC_Add_Ack.Multiline = false;
			this.inpPLC_Add_Ack.Name = "inpPLC_Add_Ack";
			this.inpPLC_Add_Ack.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Ack.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Ack.TabIndex = 4;
			this.inpPLC_Add_Ack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Ack.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Ack.TextBox_MaxLength = 32767;
			this.inpPLC_Add_Ack.TextBox_PasswordChar = '\0';
			this.inpPLC_Add_Ack.TextBox_TabStopsLength = 8;
			this.inpPLC_Add_Ack.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Add_Ack.Value = "";
			// 
			// inpPLC_Add_Trigger
			// 
			this.inpPLC_Add_Trigger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Add_Trigger.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Add_Trigger.ChangeMark_Visable = true;
			this.inpPLC_Add_Trigger.ComboBoxDataSource = null;
			this.inpPLC_Add_Trigger.ComboBoxDisplayMember = "";
			this.inpPLC_Add_Trigger.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Add_Trigger.ComboBoxSelectedValue = null;
			this.inpPLC_Add_Trigger.ComboBoxSelectIndex = -1;
			this.inpPLC_Add_Trigger.ComboBoxSelectItem = null;
			this.inpPLC_Add_Trigger.ComboBoxValueMember = "";
			this.inpPLC_Add_Trigger.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Add_Trigger.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Add_Trigger.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Add_Trigger.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Add_Trigger.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Add_Trigger.DLabel_FontAutoSize = false;
			this.inpPLC_Add_Trigger.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Trigger.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Trigger.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Add_Trigger.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Add_Trigger.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Add_Trigger.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Add_Trigger.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Add_Trigger.Label_Text = "Trigger 주소";
			this.inpPLC_Add_Trigger.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Trigger.Label_Visable = true;
			this.inpPLC_Add_Trigger.LabelWidth = 75;
			this.inpPLC_Add_Trigger.Location = new System.Drawing.Point(3, 57);
			this.inpPLC_Add_Trigger.Multiline = false;
			this.inpPLC_Add_Trigger.Name = "inpPLC_Add_Trigger";
			this.inpPLC_Add_Trigger.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Trigger.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Trigger.TabIndex = 3;
			this.inpPLC_Add_Trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Trigger.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Trigger.TextBox_MaxLength = 32767;
			this.inpPLC_Add_Trigger.TextBox_PasswordChar = '\0';
			this.inpPLC_Add_Trigger.TextBox_TabStopsLength = 8;
			this.inpPLC_Add_Trigger.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Add_Trigger.Value = "";
			// 
			// inpPLC_RsLinx_ID
			// 
			this.inpPLC_RsLinx_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_RsLinx_ID.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_RsLinx_ID.ChangeMark_Visable = true;
			this.inpPLC_RsLinx_ID.ComboBoxDataSource = null;
			this.inpPLC_RsLinx_ID.ComboBoxDisplayMember = "";
			this.inpPLC_RsLinx_ID.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_RsLinx_ID.ComboBoxSelectedValue = null;
			this.inpPLC_RsLinx_ID.ComboBoxSelectIndex = -1;
			this.inpPLC_RsLinx_ID.ComboBoxSelectItem = null;
			this.inpPLC_RsLinx_ID.ComboBoxValueMember = "";
			this.inpPLC_RsLinx_ID.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_RsLinx_ID.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_RsLinx_ID.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_RsLinx_ID.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_RsLinx_ID.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_RsLinx_ID.DLabel_FontAutoSize = false;
			this.inpPLC_RsLinx_ID.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_RsLinx_ID.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_RsLinx_ID.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_RsLinx_ID.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_RsLinx_ID.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_RsLinx_ID.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_RsLinx_ID.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_RsLinx_ID.Label_Text = "RsLinx ID";
			this.inpPLC_RsLinx_ID.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_RsLinx_ID.Label_Visable = true;
			this.inpPLC_RsLinx_ID.LabelWidth = 75;
			this.inpPLC_RsLinx_ID.Location = new System.Drawing.Point(3, 6);
			this.inpPLC_RsLinx_ID.Multiline = false;
			this.inpPLC_RsLinx_ID.Name = "inpPLC_RsLinx_ID";
			this.inpPLC_RsLinx_ID.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_RsLinx_ID.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_RsLinx_ID.TabIndex = 2;
			this.inpPLC_RsLinx_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_RsLinx_ID.TextBox_AcceptsTab = false;
			this.inpPLC_RsLinx_ID.TextBox_MaxLength = 32767;
			this.inpPLC_RsLinx_ID.TextBox_PasswordChar = '\0';
			this.inpPLC_RsLinx_ID.TextBox_TabStopsLength = 8;
			this.inpPLC_RsLinx_ID.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_RsLinx_ID.Value = "";
			// 
			// inpPLC_Topic
			// 
			this.inpPLC_Topic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpPLC_Topic.BackColor = System.Drawing.SystemColors.Control;
			this.inpPLC_Topic.ChangeMark_Visable = true;
			this.inpPLC_Topic.ComboBoxDataSource = null;
			this.inpPLC_Topic.ComboBoxDisplayMember = "";
			this.inpPLC_Topic.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpPLC_Topic.ComboBoxSelectedValue = null;
			this.inpPLC_Topic.ComboBoxSelectIndex = -1;
			this.inpPLC_Topic.ComboBoxSelectItem = null;
			this.inpPLC_Topic.ComboBoxValueMember = "";
			this.inpPLC_Topic.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpPLC_Topic.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpPLC_Topic.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpPLC_Topic.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpPLC_Topic.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpPLC_Topic.DLabel_FontAutoSize = false;
			this.inpPLC_Topic.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Topic.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Topic.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpPLC_Topic.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpPLC_Topic.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpPLC_Topic.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpPLC_Topic.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpPLC_Topic.Label_Text = "Topic 이름";
			this.inpPLC_Topic.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Topic.Label_Visable = true;
			this.inpPLC_Topic.LabelWidth = 75;
			this.inpPLC_Topic.Location = new System.Drawing.Point(3, 32);
			this.inpPLC_Topic.Multiline = false;
			this.inpPLC_Topic.Name = "inpPLC_Topic";
			this.inpPLC_Topic.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Topic.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Topic.TabIndex = 1;
			this.inpPLC_Topic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Topic.TextBox_AcceptsTab = false;
			this.inpPLC_Topic.TextBox_MaxLength = 32767;
			this.inpPLC_Topic.TextBox_PasswordChar = '\0';
			this.inpPLC_Topic.TextBox_TabStopsLength = 8;
			this.inpPLC_Topic.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpPLC_Topic.Value = "";
			// 
			// inpToolMng
			// 
			this.inpToolMng.BackColor = System.Drawing.SystemColors.Control;
			this.inpToolMng.ChangeMark_Visable = false;
			this.inpToolMng.ComboBoxDataSource = null;
			this.inpToolMng.ComboBoxDisplayMember = "";
			this.inpToolMng.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpToolMng.ComboBoxSelectedValue = null;
			this.inpToolMng.ComboBoxSelectIndex = -1;
			this.inpToolMng.ComboBoxSelectItem = null;
			this.inpToolMng.ComboBoxValueMember = "";
			this.inpToolMng.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpToolMng.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpToolMng.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpToolMng.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpToolMng.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpToolMng.DLabel_FontAutoSize = false;
			this.inpToolMng.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpToolMng.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpToolMng.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpToolMng.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpToolMng.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpToolMng.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpToolMng.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpToolMng.Label_Text = "Tool 이름 관리";
			this.inpToolMng.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpToolMng.Label_Visable = true;
			this.inpToolMng.LabelWidth = 120;
			this.inpToolMng.Location = new System.Drawing.Point(5, 160);
			this.inpToolMng.Multiline = false;
			this.inpToolMng.Name = "inpToolMng";
			this.inpToolMng.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpToolMng.Size = new System.Drawing.Size(313, 24);
			this.inpToolMng.TabIndex = 3;
			this.inpToolMng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpToolMng.TextBox_AcceptsTab = false;
			this.inpToolMng.TextBox_MaxLength = 32767;
			this.inpToolMng.TextBox_PasswordChar = '\0';
			this.inpToolMng.TextBox_TabStopsLength = 8;
			this.inpToolMng.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpToolMng.Value = "관 리";
			this.inpToolMng.Visible = false;
			this.inpToolMng.Click += new Function.form.usrEventHander(this.inpToolMng_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(262, 396);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "    취 소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(332, 396);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(64, 23);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "    저 장";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkWinStartUp
			// 
			this.chkWinStartUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkWinStartUp.AutoSize = true;
			this.chkWinStartUp.Location = new System.Drawing.Point(3, 400);
			this.chkWinStartUp.Name = "chkWinStartUp";
			this.chkWinStartUp.Size = new System.Drawing.Size(212, 16);
			this.chkWinStartUp.TabIndex = 11;
			this.chkWinStartUp.Text = "윈도우 시작 시 프로그램 자동 시작";
			this.chkWinStartUp.UseVisualStyleBackColor = true;
			// 
			// inpOpMode
			// 
			this.inpOpMode.BackColor = System.Drawing.SystemColors.Control;
			this.inpOpMode.ChangeMark_Visable = true;
			this.inpOpMode.ComboBoxDataSource = null;
			this.inpOpMode.ComboBoxDisplayMember = "";
			this.inpOpMode.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpOpMode.ComboBoxItems.AddRange(new object[] {
            "조회 모드",
            "모니터링&조회모드"});
			this.inpOpMode.ComboBoxSelectedValue = null;
			this.inpOpMode.ComboBoxSelectIndex = -1;
			this.inpOpMode.ComboBoxSelectItem = null;
			this.inpOpMode.ComboBoxValueMember = "";
			this.inpOpMode.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpOpMode.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpOpMode.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpOpMode.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpOpMode.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpOpMode.DLabel_FontAutoSize = false;
			this.inpOpMode.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpOpMode.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpOpMode.InputType = Function.form.usrInputBox.enInputType.COMBO;
			this.inpOpMode.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpOpMode.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpOpMode.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpOpMode.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpOpMode.Label_Text = "프로그램 동작 모드";
			this.inpOpMode.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpOpMode.Label_Visable = true;
			this.inpOpMode.LabelWidth = 120;
			this.inpOpMode.Location = new System.Drawing.Point(5, 29);
			this.inpOpMode.Multiline = false;
			this.inpOpMode.Name = "inpOpMode";
			this.inpOpMode.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpOpMode.Size = new System.Drawing.Size(313, 22);
			this.inpOpMode.TabIndex = 12;
			this.inpOpMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpOpMode.TextBox_AcceptsTab = false;
			this.inpOpMode.TextBox_MaxLength = 32767;
			this.inpOpMode.TextBox_PasswordChar = '\0';
			this.inpOpMode.TextBox_TabStopsLength = 8;
			this.inpOpMode.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpOpMode.Value = "";
			// 
			// inpStationID
			// 
			this.inpStationID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpStationID.BackColor = System.Drawing.SystemColors.Control;
			this.inpStationID.ChangeMark_Visable = true;
			this.inpStationID.ComboBoxDataSource = null;
			this.inpStationID.ComboBoxDisplayMember = "";
			this.inpStationID.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpStationID.ComboBoxItems.AddRange(new object[] {
            "DEV_01",
            "DEV_02"});
			this.inpStationID.ComboBoxSelectedValue = null;
			this.inpStationID.ComboBoxSelectIndex = -1;
			this.inpStationID.ComboBoxSelectItem = null;
			this.inpStationID.ComboBoxValueMember = "";
			this.inpStationID.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpStationID.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpStationID.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpStationID.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpStationID.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpStationID.DLabel_FontAutoSize = false;
			this.inpStationID.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpStationID.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpStationID.InputType = Function.form.usrInputBox.enInputType.COMBO;
			this.inpStationID.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpStationID.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpStationID.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpStationID.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpStationID.Label_Text = "STATION ID";
			this.inpStationID.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpStationID.Label_Visable = true;
			this.inpStationID.LabelWidth = 120;
			this.inpStationID.Location = new System.Drawing.Point(7, 3);
			this.inpStationID.Multiline = false;
			this.inpStationID.Name = "inpStationID";
			this.inpStationID.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpStationID.Size = new System.Drawing.Size(311, 22);
			this.inpStationID.TabIndex = 13;
			this.inpStationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpStationID.TextBox_AcceptsTab = false;
			this.inpStationID.TextBox_MaxLength = 32767;
			this.inpStationID.TextBox_PasswordChar = '\0';
			this.inpStationID.TextBox_TabStopsLength = 8;
			this.inpStationID.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpStationID.Value = "";
			// 
			// inpDBInit
			// 
			this.inpDBInit.BackColor = System.Drawing.SystemColors.Control;
			this.inpDBInit.ChangeMark_Visable = false;
			this.inpDBInit.ComboBoxDataSource = null;
			this.inpDBInit.ComboBoxDisplayMember = "";
			this.inpDBInit.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpDBInit.ComboBoxSelectedValue = null;
			this.inpDBInit.ComboBoxSelectIndex = -1;
			this.inpDBInit.ComboBoxSelectItem = null;
			this.inpDBInit.ComboBoxValueMember = "";
			this.inpDBInit.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpDBInit.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpDBInit.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpDBInit.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpDBInit.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpDBInit.DLabel_FontAutoSize = false;
			this.inpDBInit.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpDBInit.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpDBInit.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpDBInit.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpDBInit.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpDBInit.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpDBInit.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpDBInit.Label_Text = "MS SQL 초기화";
			this.inpDBInit.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpDBInit.Label_Visable = true;
			this.inpDBInit.LabelWidth = 120;
			this.inpDBInit.Location = new System.Drawing.Point(5, 133);
			this.inpDBInit.Multiline = false;
			this.inpDBInit.Name = "inpDBInit";
			this.inpDBInit.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpDBInit.Size = new System.Drawing.Size(313, 24);
			this.inpDBInit.TabIndex = 14;
			this.inpDBInit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpDBInit.TextBox_AcceptsTab = false;
			this.inpDBInit.TextBox_MaxLength = 32767;
			this.inpDBInit.TextBox_PasswordChar = '\0';
			this.inpDBInit.TextBox_TabStopsLength = 8;
			this.inpDBInit.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpDBInit.Value = "초 기 화";
			this.inpDBInit.Visible = false;
			this.inpDBInit.Click += new Function.form.usrEventHander(this.inpDBInit_Click);
			// 
			// inpImagePath
			// 
			this.inpImagePath.BackColor = System.Drawing.SystemColors.Control;
			this.inpImagePath.ChangeMark_Visable = true;
			this.inpImagePath.ComboBoxDataSource = null;
			this.inpImagePath.ComboBoxDisplayMember = "";
			this.inpImagePath.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpImagePath.ComboBoxSelectedValue = null;
			this.inpImagePath.ComboBoxSelectIndex = -1;
			this.inpImagePath.ComboBoxSelectItem = null;
			this.inpImagePath.ComboBoxValueMember = "";
			this.inpImagePath.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpImagePath.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpImagePath.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpImagePath.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpImagePath.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpImagePath.DLabel_FontAutoSize = false;
			this.inpImagePath.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpImagePath.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpImagePath.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpImagePath.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpImagePath.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpImagePath.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpImagePath.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpImagePath.Label_Text = "Torque 사진 경로";
			this.inpImagePath.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpImagePath.Label_Visable = true;
			this.inpImagePath.LabelWidth = 120;
			this.inpImagePath.Location = new System.Drawing.Point(5, 53);
			this.inpImagePath.Multiline = false;
			this.inpImagePath.Name = "inpImagePath";
			this.inpImagePath.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpImagePath.Size = new System.Drawing.Size(368, 24);
			this.inpImagePath.TabIndex = 15;
			this.inpImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpImagePath.TextBox_AcceptsTab = false;
			this.inpImagePath.TextBox_MaxLength = 32767;
			this.inpImagePath.TextBox_PasswordChar = '\0';
			this.inpImagePath.TextBox_TabStopsLength = 8;
			this.inpImagePath.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpImagePath.Value = "";
			// 
			// btnImagePath
			// 
			this.btnImagePath.Location = new System.Drawing.Point(374, 53);
			this.btnImagePath.Name = "btnImagePath";
			this.btnImagePath.Size = new System.Drawing.Size(26, 23);
			this.btnImagePath.TabIndex = 16;
			this.btnImagePath.Text = "..";
			this.btnImagePath.UseVisualStyleBackColor = true;
			this.btnImagePath.Click += new System.EventHandler(this.btnImagePath_Click);
			// 
			// chkIF_Check
			// 
			this.chkIF_Check.AutoSize = true;
			this.chkIF_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkIF_Check.Location = new System.Drawing.Point(7, 83);
			this.chkIF_Check.Name = "chkIF_Check";
			this.chkIF_Check.Size = new System.Drawing.Size(96, 16);
			this.chkIF_Check.TabIndex = 17;
			this.chkIF_Check.Text = "I/F 사용 여부";
			this.chkIF_Check.UseVisualStyleBackColor = true;
			// 
			// popSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 422);
			this.Controls.Add(this.chkIF_Check);
			this.Controls.Add(this.btnImagePath);
			this.Controls.Add(this.inpImagePath);
			this.Controls.Add(this.inpDBInit);
			this.Controls.Add(this.inpStationID);
			this.Controls.Add(this.inpOpMode);
			this.Controls.Add(this.chkWinStartUp);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.inpToolMng);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSQL_Setting);
			this.Font = new System.Drawing.Font("굴림", 9F);
			this.isUseFormInit = true;
			this.KeyPreview = true;
			this.Name = "popSetting";
			this.ShowInTaskbar = false;
			this.Text = "환경 설정";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.popSetting_KeyDown);
			this.Load += new System.EventHandler(this.popSetting_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Function.form.usrInputBox txtSQL_Setting;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Function.form.usrInputBox inpPLC_Add_Data;
		private Function.form.usrInputBox inpPLC_Add_Ack;
		private Function.form.usrInputBox inpPLC_Add_Trigger;
		private Function.form.usrInputBox inpPLC_RsLinx_ID;
		private Function.form.usrInputBox inpPLC_Topic;
		private Function.form.usrInputBox inpToolMng;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkWinStartUp;
		private Function.form.usrInputBox inpOpMode;
		private Function.form.usrInputBox inpStationID;
		private Function.form.usrInputBox inpPLC_Add_Confirm;
		private Function.form.usrInputBox inpPLC_Add_Info;
		private Function.form.usrInputBox inpDBInit;
		private Function.form.usrInputBox inpImagePath;
		private System.Windows.Forms.Button btnImagePath;
		private System.Windows.Forms.CheckBox chkIF_Check;
	}
}