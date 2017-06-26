﻿namespace GM_Torqu_Tool_IF
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
			this.txtSQL_Setting.Location = new System.Drawing.Point(5, 37);
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
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "PLC 환경 설정";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.inpPLC_Add_Data);
			this.panel1.Controls.Add(this.inpPLC_Add_Ack);
			this.panel1.Controls.Add(this.inpPLC_Add_Trigger);
			this.panel1.Controls.Add(this.inpPLC_RsLinx_ID);
			this.panel1.Controls.Add(this.inpPLC_Topic);
			this.panel1.Location = new System.Drawing.Point(3, 121);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(397, 138);
			this.panel1.TabIndex = 2;
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
			this.inpPLC_Add_Data.Location = new System.Drawing.Point(3, 108);
			this.inpPLC_Add_Data.Multiline = false;
			this.inpPLC_Add_Data.Name = "inpPLC_Add_Data";
			this.inpPLC_Add_Data.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpPLC_Add_Data.Size = new System.Drawing.Size(389, 23);
			this.inpPLC_Add_Data.TabIndex = 5;
			this.inpPLC_Add_Data.TEXT = "";
			this.inpPLC_Add_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Data.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Data.TEXTBOX_PasswordChar = '\0';
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
			this.inpPLC_Add_Ack.TEXT = "";
			this.inpPLC_Add_Ack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Ack.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Ack.TEXTBOX_PasswordChar = '\0';
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
			this.inpPLC_Add_Trigger.TEXT = "";
			this.inpPLC_Add_Trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Add_Trigger.TextBox_AcceptsTab = false;
			this.inpPLC_Add_Trigger.TEXTBOX_PasswordChar = '\0';
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
			this.inpPLC_RsLinx_ID.TEXT = "";
			this.inpPLC_RsLinx_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_RsLinx_ID.TextBox_AcceptsTab = false;
			this.inpPLC_RsLinx_ID.TEXTBOX_PasswordChar = '\0';
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
			this.inpPLC_Topic.TEXT = "";
			this.inpPLC_Topic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpPLC_Topic.TextBox_AcceptsTab = false;
			this.inpPLC_Topic.TEXTBOX_PasswordChar = '\0';
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
			this.inpToolMng.Location = new System.Drawing.Point(5, 67);
			this.inpToolMng.Multiline = false;
			this.inpToolMng.Name = "inpToolMng";
			this.inpToolMng.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpToolMng.Size = new System.Drawing.Size(248, 24);
			this.inpToolMng.TabIndex = 3;
			this.inpToolMng.TEXT = "관 리";
			this.inpToolMng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpToolMng.TextBox_AcceptsTab = false;
			this.inpToolMng.TEXTBOX_PasswordChar = '\0';
			this.inpToolMng.TextBox_TabStopsLength = 8;
			this.inpToolMng.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpToolMng.Value = "관 리";
			this.inpToolMng.Click += new Function.form.usrEventHander(this.inpToolMng_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(262, 262);
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
			this.btnSave.Location = new System.Drawing.Point(332, 262);
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
			this.chkWinStartUp.AutoSize = true;
			this.chkWinStartUp.Location = new System.Drawing.Point(3, 265);
			this.chkWinStartUp.Name = "chkWinStartUp";
			this.chkWinStartUp.Size = new System.Drawing.Size(212, 16);
			this.chkWinStartUp.TabIndex = 11;
			this.chkWinStartUp.Text = "윈도우 시작 시 프로그램 자동 시작";
			this.chkWinStartUp.UseVisualStyleBackColor = true;
			// 
			// inpOpMode
			// 
			this.inpOpMode.BackColor = System.Drawing.SystemColors.Control;
			this.inpOpMode.ChangeMark_Visable = false;
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
			this.inpOpMode.Location = new System.Drawing.Point(5, 7);
			this.inpOpMode.Multiline = false;
			this.inpOpMode.Name = "inpOpMode";
			this.inpOpMode.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpOpMode.Size = new System.Drawing.Size(248, 24);
			this.inpOpMode.TabIndex = 12;
			this.inpOpMode.TEXT = "";
			this.inpOpMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpOpMode.TextBox_AcceptsTab = false;
			this.inpOpMode.TEXTBOX_PasswordChar = '\0';
			this.inpOpMode.TextBox_TabStopsLength = 8;
			this.inpOpMode.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpOpMode.Value = "";
			// 
			// popSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 288);
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
			this.Name = "popSetting";
			this.ShowInTaskbar = false;
			this.Text = "환경 설정";
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
	}
}