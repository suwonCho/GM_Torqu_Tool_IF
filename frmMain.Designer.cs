﻿namespace GM_Torqu_Tool_IF
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{			
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSetting = new System.Windows.Forms.Button();
            this.picDB = new System.Windows.Forms.PictureBox();
            this.picPLC = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonitoring = new System.Windows.Forms.TabPage();
            this.lstMoniLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabSearching = new System.Windows.Forms.TabPage();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearch_conditon = new System.Windows.Forms.Panel();
            this.inpStationID = new Function.form.usrInputBox();
            this.btnExcelSave = new System.Windows.Forms.Button();
            this.btnCondition_reset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.inpResult = new Function.form.usrInputBox();
            this.inpVin = new Function.form.usrInputBox();
            this.inpTrimin = new Function.form.usrInputBox();
            this.inpPono = new Function.form.usrInputBox();
            this.inpCartype = new Function.form.usrInputBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.inpPicSizeMode = new Function.form.usrInputBox();
            this.tabIFLog = new System.Windows.Forms.TabPage();
            this.btnIF_Test = new System.Windows.Forms.Button();
            this.lstIFLog = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIF_Status = new System.Windows.Forms.Label();
            this.btnPicPopUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPLC)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMonitoring.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.pnlSearch_conditon.SuspendLayout();
            this.tabImage.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.tabIFLog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(975, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(83, 25);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "   환경설정";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // picDB
            // 
            this.picDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDB.Image = global::GM_Torqu_Tool_IF.Properties.Resources.ramp_db_ng;
            this.picDB.Location = new System.Drawing.Point(781, 16);
            this.picDB.Name = "picDB";
            this.picDB.Size = new System.Drawing.Size(50, 34);
            this.picDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDB.TabIndex = 4;
            this.picDB.TabStop = false;
            // 
            // picPLC
            // 
            this.picPLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPLC.Image = global::GM_Torqu_Tool_IF.Properties.Resources.ramp_plc_ng;
            this.picPLC.Location = new System.Drawing.Point(725, 16);
            this.picPLC.Name = "picPLC";
            this.picPLC.Size = new System.Drawing.Size(50, 34);
            this.picPLC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPLC.TabIndex = 3;
            this.picPLC.TabStop = false;
            this.picPLC.DoubleClick += new System.EventHandler(this.picPLC_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabMonitoring);
            this.tabControl1.Controls.Add(this.tabSearching);
            this.tabControl1.Controls.Add(this.tabImage);
            this.tabControl1.Controls.Add(this.tabIFLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 619);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabMonitoring
            // 
            this.tabMonitoring.BackColor = System.Drawing.SystemColors.Control;
            this.tabMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMonitoring.Controls.Add(this.lstMoniLog);
            this.tabMonitoring.Controls.Add(this.panel1);
            this.tabMonitoring.Controls.Add(this.btnTest);
            this.tabMonitoring.Location = new System.Drawing.Point(4, 4);
            this.tabMonitoring.Name = "tabMonitoring";
            this.tabMonitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitoring.Size = new System.Drawing.Size(1056, 593);
            this.tabMonitoring.TabIndex = 0;
            this.tabMonitoring.Text = "모니터링";
            // 
            // lstMoniLog
            // 
            this.lstMoniLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lstMoniLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMoniLog.FullRowSelect = true;
            this.lstMoniLog.GridLines = true;
            this.lstMoniLog.Location = new System.Drawing.Point(3, 30);
            this.lstMoniLog.Margin = new System.Windows.Forms.Padding(2);
            this.lstMoniLog.MultiSelect = false;
            this.lstMoniLog.Name = "lstMoniLog";
            this.lstMoniLog.Size = new System.Drawing.Size(1048, 558);
            this.lstMoniLog.TabIndex = 4;
            this.lstMoniLog.UseCompatibleStateImageBehavior = false;
            this.lstMoniLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "처리 시간";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "처리구분";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "내 용";
            this.columnHeader3.Width = 1235;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 27);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Torque 모니터링";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(996, 570);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(56, 18);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabSearching
            // 
            this.tabSearching.BackColor = System.Drawing.SystemColors.Control;
            this.tabSearching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSearching.Controls.Add(this.grdSearch);
            this.tabSearching.Controls.Add(this.pnlSearch_conditon);
            this.tabSearching.Controls.Add(this.label3);
            this.tabSearching.Location = new System.Drawing.Point(4, 4);
            this.tabSearching.Name = "tabSearching";
            this.tabSearching.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearching.Size = new System.Drawing.Size(1056, 593);
            this.tabSearching.TabIndex = 1;
            this.tabSearching.Text = "조 회";
            // 
            // grdSearch
            // 
            this.grdSearch.AllowUserToAddRows = false;
            this.grdSearch.AllowUserToDeleteRows = false;
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSearch.Location = new System.Drawing.Point(3, 91);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.ReadOnly = true;
            this.grdSearch.RowTemplate.Height = 23;
            this.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearch.Size = new System.Drawing.Size(1048, 497);
            this.grdSearch.TabIndex = 5;
            // 
            // pnlSearch_conditon
            // 
            this.pnlSearch_conditon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch_conditon.Controls.Add(this.inpStationID);
            this.pnlSearch_conditon.Controls.Add(this.btnExcelSave);
            this.pnlSearch_conditon.Controls.Add(this.btnCondition_reset);
            this.pnlSearch_conditon.Controls.Add(this.btnSearch);
            this.pnlSearch_conditon.Controls.Add(this.inpResult);
            this.pnlSearch_conditon.Controls.Add(this.inpVin);
            this.pnlSearch_conditon.Controls.Add(this.inpTrimin);
            this.pnlSearch_conditon.Controls.Add(this.inpPono);
            this.pnlSearch_conditon.Controls.Add(this.inpCartype);
            this.pnlSearch_conditon.Controls.Add(this.label5);
            this.pnlSearch_conditon.Controls.Add(this.dtTo);
            this.pnlSearch_conditon.Controls.Add(this.label4);
            this.pnlSearch_conditon.Controls.Add(this.dtFrom);
            this.pnlSearch_conditon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch_conditon.Location = new System.Drawing.Point(3, 30);
            this.pnlSearch_conditon.Name = "pnlSearch_conditon";
            this.pnlSearch_conditon.Size = new System.Drawing.Size(1048, 61);
            this.pnlSearch_conditon.TabIndex = 6;
            // 
            // inpStationID
            // 
            this.inpStationID.BackColor = System.Drawing.SystemColors.Control;
            this.inpStationID.ChangeMark_Visable = false;
            this.inpStationID.ComboBoxDataSource = null;
            this.inpStationID.ComboBoxDisplayMember = "";
            this.inpStationID.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpStationID.ComboBoxItems.AddRange(new object[] {
            "전체",
            "DEV_01",
            "DEV_02"});
            this.inpStationID.ComboBoxSelectedValue = null;
            this.inpStationID.ComboBoxSelectIndex = -1;
            this.inpStationID.ComboBoxSelectItem = null;
            this.inpStationID.ComboBoxValueMember = "";
            this.inpStationID.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpStationID.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpStationID.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpStationID.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpStationID.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpStationID.DLabel_FontAutoSize = false;
            this.inpStationID.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpStationID.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpStationID.InputType = Function.form.usrInputBox.enInputType.COMBO;
            this.inpStationID.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpStationID.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpStationID.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpStationID.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpStationID.Label_Text = "수집장비";
            this.inpStationID.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpStationID.Label_Visable = true;
            this.inpStationID.LabelWidth = -1;
            this.inpStationID.Location = new System.Drawing.Point(414, 30);
            this.inpStationID.Multiline = false;
            this.inpStationID.Name = "inpStationID";
            this.inpStationID.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpStationID.Size = new System.Drawing.Size(181, 22);
            this.inpStationID.TabIndex = 12;
            this.inpStationID.Tag = "StationID";
            this.inpStationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpStationID.TextBox_AcceptsTab = false;
            this.inpStationID.TextBox_MaxLength = 32767;
            this.inpStationID.TextBox_PasswordChar = '\0';
            this.inpStationID.TextBox_TabStopsLength = 8;
            this.inpStationID.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpStationID.Value = "";
            // 
            // btnExcelSave
            // 
            this.btnExcelSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcelSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelSave.Location = new System.Drawing.Point(800, 2);
            this.btnExcelSave.Name = "btnExcelSave";
            this.btnExcelSave.Size = new System.Drawing.Size(64, 52);
            this.btnExcelSave.TabIndex = 11;
            this.btnExcelSave.Text = "    엑셀\r\n    출력";
            this.btnExcelSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelSave.UseVisualStyleBackColor = true;
            this.btnExcelSave.Click += new System.EventHandler(this.btnExcelSave_Click);
            // 
            // btnCondition_reset
            // 
            this.btnCondition_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCondition_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondition_reset.Location = new System.Drawing.Point(636, 30);
            this.btnCondition_reset.Name = "btnCondition_reset";
            this.btnCondition_reset.Size = new System.Drawing.Size(93, 23);
            this.btnCondition_reset.TabIndex = 10;
            this.btnCondition_reset.Text = "   조건초기화";
            this.btnCondition_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondition_reset.UseVisualStyleBackColor = true;
            this.btnCondition_reset.Click += new System.EventHandler(this.btnCondition_reset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(735, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 52);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "   조회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // inpResult
            // 
            this.inpResult.BackColor = System.Drawing.SystemColors.Control;
            this.inpResult.ChangeMark_Visable = false;
            this.inpResult.ComboBoxDataSource = null;
            this.inpResult.ComboBoxDisplayMember = "";
            this.inpResult.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpResult.ComboBoxItems.AddRange(new object[] {
            "전체",
            "OK",
            "NG"});
            this.inpResult.ComboBoxSelectedValue = null;
            this.inpResult.ComboBoxSelectIndex = -1;
            this.inpResult.ComboBoxSelectItem = null;
            this.inpResult.ComboBoxValueMember = "";
            this.inpResult.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpResult.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpResult.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpResult.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpResult.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpResult.DLabel_FontAutoSize = false;
            this.inpResult.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpResult.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpResult.InputType = Function.form.usrInputBox.enInputType.COMBO;
            this.inpResult.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpResult.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpResult.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpResult.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpResult.Label_Text = "결과구분";
            this.inpResult.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpResult.Label_Visable = true;
            this.inpResult.LabelWidth = -1;
            this.inpResult.Location = new System.Drawing.Point(892, 30);
            this.inpResult.Multiline = false;
            this.inpResult.Name = "inpResult";
            this.inpResult.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpResult.Size = new System.Drawing.Size(151, 22);
            this.inpResult.TabIndex = 8;
            this.inpResult.Tag = "Result";
            this.inpResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpResult.TextBox_AcceptsTab = false;
            this.inpResult.TextBox_MaxLength = 32767;
            this.inpResult.TextBox_PasswordChar = '\0';
            this.inpResult.TextBox_TabStopsLength = 8;
            this.inpResult.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpResult.Value = "";
            this.inpResult.Visible = false;
            // 
            // inpVin
            // 
            this.inpVin.BackColor = System.Drawing.SystemColors.Control;
            this.inpVin.ChangeMark_Visable = false;
            this.inpVin.ComboBoxDataSource = null;
            this.inpVin.ComboBoxDisplayMember = "";
            this.inpVin.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpVin.ComboBoxItems.AddRange(new object[] {
            "전체",
            "GSUV",
            "T300"});
            this.inpVin.ComboBoxSelectedValue = null;
            this.inpVin.ComboBoxSelectIndex = -1;
            this.inpVin.ComboBoxSelectItem = null;
            this.inpVin.ComboBoxValueMember = "";
            this.inpVin.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpVin.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpVin.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpVin.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpVin.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpVin.DLabel_FontAutoSize = false;
            this.inpVin.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpVin.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpVin.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
            this.inpVin.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpVin.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpVin.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpVin.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpVin.Label_Text = "Vin";
            this.inpVin.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpVin.Label_Visable = true;
            this.inpVin.LabelWidth = -1;
            this.inpVin.Location = new System.Drawing.Point(170, 31);
            this.inpVin.Multiline = false;
            this.inpVin.Name = "inpVin";
            this.inpVin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpVin.Size = new System.Drawing.Size(238, 23);
            this.inpVin.TabIndex = 7;
            this.inpVin.Tag = "Vin";
            this.inpVin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpVin.TextBox_AcceptsTab = false;
            this.inpVin.TextBox_MaxLength = 32767;
            this.inpVin.TextBox_PasswordChar = '\0';
            this.inpVin.TextBox_TabStopsLength = 8;
            this.inpVin.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpVin.Value = "";
            // 
            // inpTrimin
            // 
            this.inpTrimin.BackColor = System.Drawing.SystemColors.Control;
            this.inpTrimin.ChangeMark_Visable = false;
            this.inpTrimin.ComboBoxDataSource = null;
            this.inpTrimin.ComboBoxDisplayMember = "";
            this.inpTrimin.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpTrimin.ComboBoxItems.AddRange(new object[] {
            "전체",
            "GSUV",
            "T300"});
            this.inpTrimin.ComboBoxSelectedValue = null;
            this.inpTrimin.ComboBoxSelectIndex = -1;
            this.inpTrimin.ComboBoxSelectItem = null;
            this.inpTrimin.ComboBoxValueMember = "";
            this.inpTrimin.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpTrimin.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpTrimin.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpTrimin.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTrimin.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpTrimin.DLabel_FontAutoSize = false;
            this.inpTrimin.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpTrimin.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpTrimin.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
            this.inpTrimin.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpTrimin.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTrimin.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpTrimin.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpTrimin.Label_Text = "TrimInSeq";
            this.inpTrimin.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpTrimin.Label_Visable = true;
            this.inpTrimin.LabelWidth = -1;
            this.inpTrimin.Location = new System.Drawing.Point(3, 31);
            this.inpTrimin.Multiline = false;
            this.inpTrimin.Name = "inpTrimin";
            this.inpTrimin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpTrimin.Size = new System.Drawing.Size(161, 23);
            this.inpTrimin.TabIndex = 6;
            this.inpTrimin.Tag = "TrimInSeq";
            this.inpTrimin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpTrimin.TextBox_AcceptsTab = false;
            this.inpTrimin.TextBox_MaxLength = 32767;
            this.inpTrimin.TextBox_PasswordChar = '\0';
            this.inpTrimin.TextBox_TabStopsLength = 8;
            this.inpTrimin.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpTrimin.Value = "";
            // 
            // inpPono
            // 
            this.inpPono.BackColor = System.Drawing.SystemColors.Control;
            this.inpPono.ChangeMark_Visable = false;
            this.inpPono.ComboBoxDataSource = null;
            this.inpPono.ComboBoxDisplayMember = "";
            this.inpPono.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpPono.ComboBoxItems.AddRange(new object[] {
            "전체",
            "GSUV",
            "T300"});
            this.inpPono.ComboBoxSelectedValue = null;
            this.inpPono.ComboBoxSelectIndex = -1;
            this.inpPono.ComboBoxSelectItem = null;
            this.inpPono.ComboBoxValueMember = "";
            this.inpPono.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpPono.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpPono.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpPono.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpPono.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpPono.DLabel_FontAutoSize = false;
            this.inpPono.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpPono.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpPono.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
            this.inpPono.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpPono.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpPono.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpPono.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpPono.Label_Text = "PoNo";
            this.inpPono.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpPono.Label_Visable = true;
            this.inpPono.LabelWidth = -1;
            this.inpPono.Location = new System.Drawing.Point(571, 2);
            this.inpPono.Multiline = false;
            this.inpPono.Name = "inpPono";
            this.inpPono.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpPono.Size = new System.Drawing.Size(158, 23);
            this.inpPono.TabIndex = 5;
            this.inpPono.Tag = "PoNo";
            this.inpPono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpPono.TextBox_AcceptsTab = false;
            this.inpPono.TextBox_MaxLength = 32767;
            this.inpPono.TextBox_PasswordChar = '\0';
            this.inpPono.TextBox_TabStopsLength = 8;
            this.inpPono.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpPono.Value = "";
            // 
            // inpCartype
            // 
            this.inpCartype.BackColor = System.Drawing.SystemColors.Control;
            this.inpCartype.ChangeMark_Visable = false;
            this.inpCartype.ComboBoxDataSource = null;
            this.inpCartype.ComboBoxDisplayMember = "";
            this.inpCartype.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpCartype.ComboBoxItems.AddRange(new object[] {
            "전체",
            "GSUV",
            "T300"});
            this.inpCartype.ComboBoxSelectedValue = null;
            this.inpCartype.ComboBoxSelectIndex = -1;
            this.inpCartype.ComboBoxSelectItem = null;
            this.inpCartype.ComboBoxValueMember = "";
            this.inpCartype.DLabel_BackColor = System.Drawing.Color.Transparent;
            this.inpCartype.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
            this.inpCartype.DLabel_BlinkColor = System.Drawing.Color.White;
            this.inpCartype.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCartype.DLabel_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpCartype.DLabel_FontAutoSize = false;
            this.inpCartype.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpCartype.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpCartype.InputType = Function.form.usrInputBox.enInputType.COMBO;
            this.inpCartype.Label_BackColor = System.Drawing.Color.Transparent;
            this.inpCartype.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCartype.Label_Font = new System.Drawing.Font("굴림체", 9F);
            this.inpCartype.Label_ForeColor = System.Drawing.SystemColors.ControlText;
            this.inpCartype.Label_Text = "차종";
            this.inpCartype.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inpCartype.Label_Visable = true;
            this.inpCartype.LabelWidth = -1;
            this.inpCartype.Location = new System.Drawing.Point(414, 3);
            this.inpCartype.Multiline = false;
            this.inpCartype.Name = "inpCartype";
            this.inpCartype.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpCartype.Size = new System.Drawing.Size(151, 22);
            this.inpCartype.TabIndex = 4;
            this.inpCartype.Tag = "CarType";
            this.inpCartype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpCartype.TextBox_AcceptsTab = false;
            this.inpCartype.TextBox_MaxLength = 32767;
            this.inpCartype.TextBox_PasswordChar = '\0';
            this.inpCartype.TextBox_TabStopsLength = 8;
            this.inpCartype.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpCartype.Value = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "~";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(247, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(161, 21);
            this.dtTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "조회기간";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(67, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(161, 21);
            this.dtFrom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1048, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Torque 조회";
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.pnlImage);
            this.tabImage.Location = new System.Drawing.Point(4, 4);
            this.tabImage.Name = "tabImage";
            this.tabImage.Size = new System.Drawing.Size(1056, 593);
            this.tabImage.TabIndex = 2;
            this.tabImage.Text = "Torque사진";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.inpPicSizeMode);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(1056, 593);
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
            this.inpPicSizeMode.Location = new System.Drawing.Point(3, 3);
            this.inpPicSizeMode.Multiline = false;
            this.inpPicSizeMode.Name = "inpPicSizeMode";
            this.inpPicSizeMode.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.inpPicSizeMode.Size = new System.Drawing.Size(215, 22);
            this.inpPicSizeMode.TabIndex = 1;
            this.inpPicSizeMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inpPicSizeMode.TextBox_AcceptsTab = false;
            this.inpPicSizeMode.TextBox_MaxLength = 32767;
            this.inpPicSizeMode.TextBox_PasswordChar = '\0';
            this.inpPicSizeMode.TextBox_TabStopsLength = 8;
            this.inpPicSizeMode.TextType = Function.form.usrInputBox.enTextType.All;
            this.inpPicSizeMode.Value = "";
            this.inpPicSizeMode.Text_Changed += new Function.form.usrEventHander(this.inpPicSizeMode_Text_Changed);
            // 
            // tabIFLog
            // 
            this.tabIFLog.Controls.Add(this.btnIF_Test);
            this.tabIFLog.Controls.Add(this.lstIFLog);
            this.tabIFLog.Controls.Add(this.panel2);
            this.tabIFLog.Location = new System.Drawing.Point(4, 4);
            this.tabIFLog.Name = "tabIFLog";
            this.tabIFLog.Size = new System.Drawing.Size(1056, 593);
            this.tabIFLog.TabIndex = 3;
            this.tabIFLog.Text = "I/F 로그";
            this.tabIFLog.UseVisualStyleBackColor = true;
            // 
            // btnIF_Test
            // 
            this.btnIF_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIF_Test.Location = new System.Drawing.Point(976, 543);
            this.btnIF_Test.Name = "btnIF_Test";
            this.btnIF_Test.Size = new System.Drawing.Size(72, 28);
            this.btnIF_Test.TabIndex = 8;
            this.btnIF_Test.Text = "IF Test";
            this.btnIF_Test.UseVisualStyleBackColor = true;
            this.btnIF_Test.Click += new System.EventHandler(this.btnIF_Test_Click);
            // 
            // lstIFLog
            // 
            this.lstIFLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstIFLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIFLog.FullRowSelect = true;
            this.lstIFLog.GridLines = true;
            this.lstIFLog.Location = new System.Drawing.Point(0, 27);
            this.lstIFLog.Margin = new System.Windows.Forms.Padding(2);
            this.lstIFLog.MultiSelect = false;
            this.lstIFLog.Name = "lstIFLog";
            this.lstIFLog.Size = new System.Drawing.Size(1056, 566);
            this.lstIFLog.TabIndex = 5;
            this.lstIFLog.UseCompatibleStateImageBehavior = false;
            this.lstIFLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "처리 시간";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 131;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "처리구분";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "내 용";
            this.columnHeader8.Width = 1235;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblIF_Status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 27);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(776, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "I/F 로그";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIF_Status
            // 
            this.lblIF_Status.BackColor = System.Drawing.Color.DarkGray;
            this.lblIF_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIF_Status.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIF_Status.ForeColor = System.Drawing.Color.White;
            this.lblIF_Status.Location = new System.Drawing.Point(776, 0);
            this.lblIF_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIF_Status.Name = "lblIF_Status";
            this.lblIF_Status.Size = new System.Drawing.Size(278, 25);
            this.lblIF_Status.TabIndex = 6;
            this.lblIF_Status.Text = "상태";
            this.lblIF_Status.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnPicPopUp
            // 
            this.btnPicPopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicPopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPicPopUp.Location = new System.Drawing.Point(886, 1);
            this.btnPicPopUp.Name = "btnPicPopUp";
            this.btnPicPopUp.Size = new System.Drawing.Size(83, 25);
            this.btnPicPopUp.TabIndex = 5;
            this.btnPicPopUp.Text = "   사진팝업";
            this.btnPicPopUp.UseVisualStyleBackColor = true;
            this.btnPicPopUp.Click += new System.EventHandler(this.btnPicPopUp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 695);
            this.Controls.Add(this.btnPicPopUp);
            this.Controls.Add(this.picPLC);
            this.Controls.Add(this.picDB);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.isUseFormInit = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.PromptQuitPgm = true;
            this.SaveConfigFileType = Function.form.enConfigFileType.ConfigXml;
            this.SavePosition = true;
            this.Text = "TorqueTool";
            this.Title_Label = "Torque Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnSetting, 0);
            this.Controls.SetChildIndex(this.picDB, 0);
            this.Controls.SetChildIndex(this.picPLC, 0);
            this.Controls.SetChildIndex(this.btnPicPopUp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPLC)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMonitoring.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabSearching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.pnlSearch_conditon.ResumeLayout(false);
            this.pnlSearch_conditon.PerformLayout();
            this.tabImage.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.tabIFLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabMonitoring;
		private System.Windows.Forms.TabPage tabSearching;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		public System.Windows.Forms.ListView lstMoniLog;
		private System.Windows.Forms.Panel pnlSearch_conditon;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.DataGridView grdSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Function.form.usrInputBox inpCartype;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtTo;
		private System.Windows.Forms.Button btnSearch;
		private Function.form.usrInputBox inpResult;
		private Function.form.usrInputBox inpVin;
		private Function.form.usrInputBox inpTrimin;
		private Function.form.usrInputBox inpPono;
		private System.Windows.Forms.Button btnCondition_reset;
		private System.Windows.Forms.Button btnExcelSave;
		private System.Windows.Forms.PictureBox picDB;
		private System.Windows.Forms.PictureBox picPLC;
		private Function.form.usrInputBox inpStationID;
		private System.Windows.Forms.TabPage tabImage;
		private System.Windows.Forms.Panel pnlImage;
		private Function.form.usrInputBox inpPicSizeMode;
		private System.Windows.Forms.Button btnPicPopUp;
		private System.Windows.Forms.TabPage tabIFLog;
		public System.Windows.Forms.ListView lstIFLog;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblIF_Status;
        private System.Windows.Forms.Button btnIF_Test;
    }
}

