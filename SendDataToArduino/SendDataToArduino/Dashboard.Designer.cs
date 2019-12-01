namespace SendDataToArduino
{
    partial class Dashboard
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
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.Controlgroup = new System.Windows.Forms.GroupBox();
            this.Lcdgroup = new System.Windows.Forms.GroupBox();
            this.connectBTN = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxLed0 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed1 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed2 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageTXT = new System.Windows.Forms.TextBox();
            this.sendMessageBTN = new System.Windows.Forms.Button();
            this.connectionGroup.SuspendLayout();
            this.Controlgroup.SuspendLayout();
            this.Lcdgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.label1);
            this.connectionGroup.Controls.Add(this.comboBoxPort);
            this.connectionGroup.Controls.Add(this.connectBTN);
            this.connectionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionGroup.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.connectionGroup.Location = new System.Drawing.Point(20, 60);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Size = new System.Drawing.Size(470, 90);
            this.connectionGroup.TabIndex = 0;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection Port";
            // 
            // Controlgroup
            // 
            this.Controlgroup.Controls.Add(this.checkBoxLed3);
            this.Controlgroup.Controls.Add(this.checkBoxLed2);
            this.Controlgroup.Controls.Add(this.checkBoxLed1);
            this.Controlgroup.Controls.Add(this.checkBoxLed0);
            this.Controlgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controlgroup.Location = new System.Drawing.Point(20, 150);
            this.Controlgroup.Name = "Controlgroup";
            this.Controlgroup.Size = new System.Drawing.Size(470, 121);
            this.Controlgroup.TabIndex = 1;
            this.Controlgroup.TabStop = false;
            this.Controlgroup.Text = "Control";
            // 
            // Lcdgroup
            // 
            this.Lcdgroup.Controls.Add(this.sendMessageBTN);
            this.Lcdgroup.Controls.Add(this.messageTXT);
            this.Lcdgroup.Controls.Add(this.label2);
            this.Lcdgroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lcdgroup.Location = new System.Drawing.Point(20, 271);
            this.Lcdgroup.Name = "Lcdgroup";
            this.Lcdgroup.Size = new System.Drawing.Size(470, 170);
            this.Lcdgroup.TabIndex = 1;
            this.Lcdgroup.TabStop = false;
            this.Lcdgroup.Text = "LCD";
            // 
            // connectBTN
            // 
            this.connectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectBTN.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.connectBTN.Location = new System.Drawing.Point(297, 30);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(129, 37);
            this.connectBTN.TabIndex = 0;
            this.connectBTN.Text = "Connect";
            this.connectBTN.UseVisualStyleBackColor = true;
            this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPort.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(130, 30);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 37);
            this.comboBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Prot:";
            // 
            // checkBoxLed0
            // 
            this.checkBoxLed0.AutoSize = true;
            this.checkBoxLed0.Location = new System.Drawing.Point(11, 36);
            this.checkBoxLed0.Name = "checkBoxLed0";
            this.checkBoxLed0.Size = new System.Drawing.Size(115, 17);
            this.checkBoxLed0.TabIndex = 0;
            this.checkBoxLed0.Text = "LED0   On (Pin 13)";
            this.checkBoxLed0.UseVisualStyleBackColor = true;
            this.checkBoxLed0.CheckedChanged += new System.EventHandler(this.checkBoxLed0_CheckedChanged);
            // 
            // checkBoxLed1
            // 
            this.checkBoxLed1.AutoSize = true;
            this.checkBoxLed1.Location = new System.Drawing.Point(11, 72);
            this.checkBoxLed1.Name = "checkBoxLed1";
            this.checkBoxLed1.Size = new System.Drawing.Size(115, 17);
            this.checkBoxLed1.TabIndex = 1;
            this.checkBoxLed1.Text = "LED1   On (Pin 12)";
            this.checkBoxLed1.UseVisualStyleBackColor = true;
            this.checkBoxLed1.CheckedChanged += new System.EventHandler(this.checkBoxLed1_CheckedChanged);
            // 
            // checkBoxLed2
            // 
            this.checkBoxLed2.AutoSize = true;
            this.checkBoxLed2.Location = new System.Drawing.Point(213, 36);
            this.checkBoxLed2.Name = "checkBoxLed2";
            this.checkBoxLed2.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLed2.TabIndex = 2;
            this.checkBoxLed2.Text = "LED2   On (Pin 8)";
            this.checkBoxLed2.UseVisualStyleBackColor = true;
            this.checkBoxLed2.Visible = false;
            this.checkBoxLed2.CheckedChanged += new System.EventHandler(this.checkBoxLed2_CheckedChanged);
            // 
            // checkBoxLed3
            // 
            this.checkBoxLed3.AutoSize = true;
            this.checkBoxLed3.Location = new System.Drawing.Point(213, 83);
            this.checkBoxLed3.Name = "checkBoxLed3";
            this.checkBoxLed3.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLed3.TabIndex = 5;
            this.checkBoxLed3.Text = "LED3   On (Pin 7)";
            this.checkBoxLed3.UseVisualStyleBackColor = true;
            this.checkBoxLed3.Visible = false;
            this.checkBoxLed3.CheckedChanged += new System.EventHandler(this.checkBoxLed3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // messageTXT
            // 
            this.messageTXT.Location = new System.Drawing.Point(103, 44);
            this.messageTXT.Multiline = true;
            this.messageTXT.Name = "messageTXT";
            this.messageTXT.Size = new System.Drawing.Size(190, 116);
            this.messageTXT.TabIndex = 4;
            // 
            // sendMessageBTN
            // 
            this.sendMessageBTN.Font = new System.Drawing.Font("PNU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendMessageBTN.Location = new System.Drawing.Point(309, 123);
            this.sendMessageBTN.Name = "sendMessageBTN";
            this.sendMessageBTN.Size = new System.Drawing.Size(94, 37);
            this.sendMessageBTN.TabIndex = 3;
            this.sendMessageBTN.Text = "SEND";
            this.sendMessageBTN.UseVisualStyleBackColor = true;
            this.sendMessageBTN.Click += new System.EventHandler(this.sendMessageBTN_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 461);
            this.Controls.Add(this.Controlgroup);
            this.Controls.Add(this.Lcdgroup);
            this.Controls.Add(this.connectionGroup);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.Controlgroup.ResumeLayout(false);
            this.Controlgroup.PerformLayout();
            this.Lcdgroup.ResumeLayout(false);
            this.Lcdgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.GroupBox Controlgroup;
        private System.Windows.Forms.GroupBox Lcdgroup;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxLed3;
        private System.Windows.Forms.CheckBox checkBoxLed2;
        private System.Windows.Forms.CheckBox checkBoxLed1;
        private System.Windows.Forms.CheckBox checkBoxLed0;
        private System.Windows.Forms.Button sendMessageBTN;
        private System.Windows.Forms.TextBox messageTXT;
        private System.Windows.Forms.Label label2;
    }
}

