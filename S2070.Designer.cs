namespace RedwoodV2

{
    partial class S2070
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S2070));
            S2070Title = new Label();
            ConsolePropertiesPanel = new Panel();
            btn_Receive_Comm1 = new Button();
            btn_Send_Comm1 = new Button();
            BaudRate_Label1 = new Label();
            BaudRate_Selection = new ComboBox();
            Toggle_BackspaceLock = new RadioButton();
            Btn_Close_Connection = new Button();
            toolStrip1 = new ToolStrip();
            Btn_estb_connect = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_Quick_Chk = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_Ext_Tests = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            btn_Front_Panel_Tsts = new ToolStripDropDownButton();
            keyboardTestToolStripMenuItem = new ToolStripMenuItem();
            displayTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_FIO_Tsts = new ToolStripDropDownButton();
            loopbackTestToolStripMenuItem = new ToolStripMenuItem();
            c12TestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_CPU_Tests = new ToolStripDropDownButton();
            dRAMSRAMToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            btn_Pwr_Supp_Tests = new ToolStripDropDownButton();
            checkVoltageToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            PortNumLabel1 = new Label();
            AvailablePortsComboBox1 = new ComboBox();
            ConsoleScreen = new Panel();
            Recieve_Label1 = new Label();
            Send_Label1 = new Label();
            Console_RecieveRichTextBox = new RichTextBox();
            Console_SendTextBox = new RichTextBox();
            ConsolePropertiesPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            ConsoleScreen.SuspendLayout();
            SuspendLayout();
            // 
            // S2070Title
            // 
            S2070Title.AutoSize = true;
            S2070Title.Dock = DockStyle.Top;
            S2070Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            S2070Title.Location = new Point(0, 0);
            S2070Title.Name = "S2070Title";
            S2070Title.Size = new Size(154, 25);
            S2070Title.TabIndex = 0;
            S2070Title.Text = "Single 2070 Tests";
            S2070Title.TextAlign = ContentAlignment.TopCenter;
            S2070Title.Click += label1_Click;
            // 
            // ConsolePropertiesPanel
            // 
            ConsolePropertiesPanel.Controls.Add(btn_Receive_Comm1);
            ConsolePropertiesPanel.Controls.Add(btn_Send_Comm1);
            ConsolePropertiesPanel.Controls.Add(BaudRate_Label1);
            ConsolePropertiesPanel.Controls.Add(BaudRate_Selection);
            ConsolePropertiesPanel.Controls.Add(Toggle_BackspaceLock);
            ConsolePropertiesPanel.Controls.Add(Btn_Close_Connection);
            ConsolePropertiesPanel.Dock = DockStyle.Bottom;
            ConsolePropertiesPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConsolePropertiesPanel.Location = new Point(0, 72);
            ConsolePropertiesPanel.Name = "ConsolePropertiesPanel";
            ConsolePropertiesPanel.Size = new Size(1173, 33);
            ConsolePropertiesPanel.TabIndex = 1;
            ConsolePropertiesPanel.Scroll += ConsolePanel_Scroll;
            // 
            // btn_Receive_Comm1
            // 
            btn_Receive_Comm1.Location = new Point(429, 2);
            btn_Receive_Comm1.Name = "btn_Receive_Comm1";
            btn_Receive_Comm1.Size = new Size(75, 23);
            btn_Receive_Comm1.TabIndex = 5;
            btn_Receive_Comm1.Text = "Receive";
            btn_Receive_Comm1.UseVisualStyleBackColor = true;
            btn_Receive_Comm1.Click += btn_Receive_Comm1_Click;
            // 
            // btn_Send_Comm1
            // 
            btn_Send_Comm1.Location = new Point(348, 2);
            btn_Send_Comm1.Name = "btn_Send_Comm1";
            btn_Send_Comm1.Size = new Size(75, 23);
            btn_Send_Comm1.TabIndex = 4;
            btn_Send_Comm1.Text = "Send";
            btn_Send_Comm1.UseVisualStyleBackColor = true;
            btn_Send_Comm1.Click += btn_Send_Comm1_Click;
            // 
            // BaudRate_Label1
            // 
            BaudRate_Label1.AutoSize = true;
            BaudRate_Label1.Location = new Point(974, 7);
            BaudRate_Label1.Name = "BaudRate_Label1";
            BaudRate_Label1.Size = new Size(60, 15);
            BaudRate_Label1.TabIndex = 3;
            BaudRate_Label1.Text = "Baud Rate";
            // 
            // BaudRate_Selection
            // 
            BaudRate_Selection.FormattingEnabled = true;
            BaudRate_Selection.Location = new Point(1040, 4);
            BaudRate_Selection.Name = "BaudRate_Selection";
            BaudRate_Selection.Size = new Size(121, 23);
            BaudRate_Selection.TabIndex = 2;
            BaudRate_Selection.Text = "=baudrate";
            // 
            // Toggle_BackspaceLock
            // 
            Toggle_BackspaceLock.AutoSize = true;
            Toggle_BackspaceLock.Location = new Point(848, 6);
            Toggle_BackspaceLock.Name = "Toggle_BackspaceLock";
            Toggle_BackspaceLock.Size = new Size(108, 19);
            Toggle_BackspaceLock.TabIndex = 1;
            Toggle_BackspaceLock.Text = "&Backspace Lock";
            Toggle_BackspaceLock.UseVisualStyleBackColor = true;
            // 
            // Btn_Close_Connection
            // 
            Btn_Close_Connection.Location = new Point(195, 2);
            Btn_Close_Connection.Name = "Btn_Close_Connection";
            Btn_Close_Connection.Size = new Size(135, 23);
            Btn_Close_Connection.TabIndex = 0;
            Btn_Close_Connection.Text = "Close Connection";
            Btn_Close_Connection.UseVisualStyleBackColor = true;
            Btn_Close_Connection.Click += Btn_Close_Connection_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Btn_estb_connect, toolStripSeparator2, btn_Quick_Chk, toolStripSeparator3, btn_Ext_Tests, toolStripSeparator8, btn_Front_Panel_Tsts, toolStripSeparator1, btn_FIO_Tsts, toolStripSeparator4, btn_CPU_Tests, toolStripSeparator5, btn_Pwr_Supp_Tests, toolStripSeparator6, toolStripButton1, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1173, 38);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Btn_estb_connect
            // 
            Btn_estb_connect.Image = (Image)resources.GetObject("Btn_estb_connect.Image");
            Btn_estb_connect.ImageTransparentColor = Color.Magenta;
            Btn_estb_connect.Name = "Btn_estb_connect";
            Btn_estb_connect.Size = new Size(122, 35);
            Btn_estb_connect.Text = "Establish Connection";
            Btn_estb_connect.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_estb_connect.Click += Btn_estb_connect_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // btn_Quick_Chk
            // 
            btn_Quick_Chk.Image = (Image)resources.GetObject("btn_Quick_Chk.Image");
            btn_Quick_Chk.ImageTransparentColor = Color.Magenta;
            btn_Quick_Chk.Name = "btn_Quick_Chk";
            btn_Quick_Chk.Size = new Size(78, 35);
            btn_Quick_Chk.Text = "Quick Check";
            btn_Quick_Chk.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // btn_Ext_Tests
            // 
            btn_Ext_Tests.Image = (Image)resources.GetObject("btn_Ext_Tests.Image");
            btn_Ext_Tests.ImageTransparentColor = Color.Magenta;
            btn_Ext_Tests.Name = "btn_Ext_Tests";
            btn_Ext_Tests.Size = new Size(96, 35);
            btn_Ext_Tests.Text = "Extended Check";
            btn_Ext_Tests.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 38);
            // 
            // btn_Front_Panel_Tsts
            // 
            btn_Front_Panel_Tsts.DropDownItems.AddRange(new ToolStripItem[] { keyboardTestToolStripMenuItem, displayTestToolStripMenuItem });
            btn_Front_Panel_Tsts.Image = (Image)resources.GetObject("btn_Front_Panel_Tsts.Image");
            btn_Front_Panel_Tsts.ImageTransparentColor = Color.Magenta;
            btn_Front_Panel_Tsts.Name = "btn_Front_Panel_Tsts";
            btn_Front_Panel_Tsts.Size = new Size(108, 35);
            btn_Front_Panel_Tsts.Text = "Front Panel Tests";
            btn_Front_Panel_Tsts.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // keyboardTestToolStripMenuItem
            // 
            keyboardTestToolStripMenuItem.Name = "keyboardTestToolStripMenuItem";
            keyboardTestToolStripMenuItem.Size = new Size(136, 22);
            keyboardTestToolStripMenuItem.Text = "Keypad Test";
            // 
            // displayTestToolStripMenuItem
            // 
            displayTestToolStripMenuItem.Name = "displayTestToolStripMenuItem";
            displayTestToolStripMenuItem.Size = new Size(136, 22);
            displayTestToolStripMenuItem.Text = "Display Test";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // btn_FIO_Tsts
            // 
            btn_FIO_Tsts.DropDownItems.AddRange(new ToolStripItem[] { loopbackTestToolStripMenuItem, c12TestToolStripMenuItem });
            btn_FIO_Tsts.Image = (Image)resources.GetObject("btn_FIO_Tsts.Image");
            btn_FIO_Tsts.ImageTransparentColor = Color.Magenta;
            btn_FIO_Tsts.Name = "btn_FIO_Tsts";
            btn_FIO_Tsts.Size = new Size(66, 35);
            btn_FIO_Tsts.Text = "FIO Tests";
            btn_FIO_Tsts.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // loopbackTestToolStripMenuItem
            // 
            loopbackTestToolStripMenuItem.Name = "loopbackTestToolStripMenuItem";
            loopbackTestToolStripMenuItem.Size = new Size(149, 22);
            loopbackTestToolStripMenuItem.Text = "Loopback Test";
            // 
            // c12TestToolStripMenuItem
            // 
            c12TestToolStripMenuItem.Name = "c12TestToolStripMenuItem";
            c12TestToolStripMenuItem.Size = new Size(149, 22);
            c12TestToolStripMenuItem.Text = "Test2";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 38);
            // 
            // btn_CPU_Tests
            // 
            btn_CPU_Tests.DropDownItems.AddRange(new ToolStripItem[] { dRAMSRAMToolStripMenuItem, versionToolStripMenuItem });
            btn_CPU_Tests.Image = (Image)resources.GetObject("btn_CPU_Tests.Image");
            btn_CPU_Tests.ImageTransparentColor = Color.Magenta;
            btn_CPU_Tests.Name = "btn_CPU_Tests";
            btn_CPU_Tests.Size = new Size(71, 35);
            btn_CPU_Tests.Text = "CPU Tests";
            btn_CPU_Tests.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dRAMSRAMToolStripMenuItem
            // 
            dRAMSRAMToolStripMenuItem.Name = "dRAMSRAMToolStripMenuItem";
            dRAMSRAMToolStripMenuItem.Size = new Size(145, 22);
            dRAMSRAMToolStripMenuItem.Text = "DRAM/SRAM";
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(145, 22);
            versionToolStripMenuItem.Text = "Boot Version";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 38);
            // 
            // btn_Pwr_Supp_Tests
            // 
            btn_Pwr_Supp_Tests.DropDownItems.AddRange(new ToolStripItem[] { checkVoltageToolStripMenuItem });
            btn_Pwr_Supp_Tests.Image = (Image)resources.GetObject("btn_Pwr_Supp_Tests.Image");
            btn_Pwr_Supp_Tests.ImageTransparentColor = Color.Magenta;
            btn_Pwr_Supp_Tests.Name = "btn_Pwr_Supp_Tests";
            btn_Pwr_Supp_Tests.Size = new Size(120, 35);
            btn_Pwr_Supp_Tests.Text = "Power Supply Tests";
            btn_Pwr_Supp_Tests.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // checkVoltageToolStripMenuItem
            // 
            checkVoltageToolStripMenuItem.Name = "checkVoltageToolStripMenuItem";
            checkVoltageToolStripMenuItem.Size = new Size(149, 22);
            checkVoltageToolStripMenuItem.Text = "Check Voltage";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 38);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(63, 35);
            toolStripButton1.Text = "Exit S2070";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 38);
            // 
            // PortNumLabel1
            // 
            PortNumLabel1.AutoSize = true;
            PortNumLabel1.Location = new Point(15, 78);
            PortNumLabel1.Name = "PortNumLabel1";
            PortNumLabel1.Size = new Size(39, 15);
            PortNumLabel1.TabIndex = 3;
            PortNumLabel1.Text = "Port #";
            PortNumLabel1.Click += label1_Click_1;
            // 
            // AvailablePortsComboBox1
            // 
            AvailablePortsComboBox1.FormattingEnabled = true;
            AvailablePortsComboBox1.Location = new Point(55, 75);
            AvailablePortsComboBox1.Name = "AvailablePortsComboBox1";
            AvailablePortsComboBox1.Size = new Size(121, 23);
            AvailablePortsComboBox1.TabIndex = 4;
            AvailablePortsComboBox1.SelectedIndexChanged += AvailablePortsComboBox1_SelectedIndexChanged;
            // 
            // ConsoleScreen
            // 
            ConsoleScreen.BorderStyle = BorderStyle.FixedSingle;
            ConsoleScreen.Controls.Add(Recieve_Label1);
            ConsoleScreen.Controls.Add(Send_Label1);
            ConsoleScreen.Controls.Add(Console_RecieveRichTextBox);
            ConsoleScreen.Controls.Add(Console_SendTextBox);
            ConsoleScreen.Dock = DockStyle.Bottom;
            ConsoleScreen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ConsoleScreen.Location = new Point(0, 105);
            ConsoleScreen.Name = "ConsoleScreen";
            ConsoleScreen.Size = new Size(1173, 455);
            ConsoleScreen.TabIndex = 5;
            ConsoleScreen.Paint += ConsoleScreen_Paint;
            // 
            // Recieve_Label1
            // 
            Recieve_Label1.AutoSize = true;
            Recieve_Label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Recieve_Label1.Location = new Point(5, 18);
            Recieve_Label1.Name = "Recieve_Label1";
            Recieve_Label1.Size = new Size(47, 15);
            Recieve_Label1.TabIndex = 4;
            Recieve_Label1.Text = "Receive";
            // 
            // Send_Label1
            // 
            Send_Label1.AutoSize = true;
            Send_Label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Send_Label1.Location = new Point(6, 405);
            Send_Label1.Name = "Send_Label1";
            Send_Label1.Size = new Size(33, 15);
            Send_Label1.TabIndex = 3;
            Send_Label1.Text = "Send";
            Send_Label1.Click += label1_Click_2;
            // 
            // Console_RecieveRichTextBox
            // 
            Console_RecieveRichTextBox.Location = new Point(54, 18);
            Console_RecieveRichTextBox.Name = "Console_RecieveRichTextBox";
            Console_RecieveRichTextBox.Size = new Size(1106, 378);
            Console_RecieveRichTextBox.TabIndex = 2;
            Console_RecieveRichTextBox.Text = "";
            Console_RecieveRichTextBox.TextChanged += Console_RecieveRichTextBox_TextChanged;
            // 
            // Console_SendTextBox
            // 
            Console_SendTextBox.Location = new Point(54, 402);
            Console_SendTextBox.Name = "Console_SendTextBox";
            Console_SendTextBox.Size = new Size(1106, 40);
            Console_SendTextBox.TabIndex = 1;
            Console_SendTextBox.Text = "";
            // 
            // S2070
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 560);
            Controls.Add(AvailablePortsComboBox1);
            Controls.Add(PortNumLabel1);
            Controls.Add(toolStrip1);
            Controls.Add(ConsolePropertiesPanel);
            Controls.Add(S2070Title);
            Controls.Add(ConsoleScreen);
            Name = "S2070";
            Text = "S2070";
            FormClosing += S2070_FormClosing;
            Load += S2070_Load;
            ConsolePropertiesPanel.ResumeLayout(false);
            ConsolePropertiesPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ConsoleScreen.ResumeLayout(false);
            ConsoleScreen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label S2070Title;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_Quick_Chk;
        private ToolStripDropDownButton btn_Front_Panel_Tsts;
        private ToolStripDropDownButton btn_FIO_Tsts;
        private ToolStripDropDownButton btn_CPU_Tests;
        private ToolStripDropDownButton btn_Pwr_Supp_Tests;
        private ToolStripButton btn_Ext_Tests;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_estb_connect;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        public Panel ConsolePropertiesPanel;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem keyboardTestToolStripMenuItem;
        private ToolStripMenuItem displayTestToolStripMenuItem;
        private ToolStripMenuItem dRAMSRAMToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem checkVoltageToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator7;
        private Label PortNumLabel1;
        private ComboBox AvailablePortsComboBox1;
        private Panel ConsoleScreen;
        private RadioButton Toggle_BackspaceLock;
        private Button Btn_Close_Connection;
        private Label BaudRate_Label1;
        private ComboBox BaudRate_Selection;
        private Button btn_Receive_Comm1;
        private Button btn_Send_Comm1;
        private RichTextBox Console_SendTextBox;
        private RichTextBox Console_RecieveRichTextBox;
        private Label Send_Label1;
        private Label Recieve_Label1;
        private ToolStripMenuItem loopbackTestToolStripMenuItem;
        private ToolStripMenuItem c12TestToolStripMenuItem;
    }
}