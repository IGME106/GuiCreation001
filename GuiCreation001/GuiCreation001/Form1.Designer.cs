namespace GuiCreation001
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.lblRulesRules = new System.Windows.Forms.Label();
            this.contRules = new System.Windows.Forms.GroupBox();
            this.contWires = new System.Windows.Forms.GroupBox();
            this.btnWire004 = new System.Windows.Forms.Button();
            this.btnWire005 = new System.Windows.Forms.Button();
            this.btnWire001 = new System.Windows.Forms.Button();
            this.btnWire002 = new System.Windows.Forms.Button();
            this.btnWire003 = new System.Windows.Forms.Button();
            this.btnStartReset = new System.Windows.Forms.Button();
            this.progressBar001 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contStatus = new System.Windows.Forms.GroupBox();
            this.cmbBStatus = new System.Windows.Forms.ListBox();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.contRules.SuspendLayout();
            this.contWires.SuspendLayout();
            this.contStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.Location = new System.Drawing.Point(10, 30);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.Size = new System.Drawing.Size(44, 17);
            this.lblRulesTitle.TabIndex = 0;
            this.lblRulesTitle.Text = "Rules";
            // 
            // lblRulesRules
            // 
            this.lblRulesRules.AutoSize = true;
            this.lblRulesRules.Location = new System.Drawing.Point(20, 59);
            this.lblRulesRules.Name = "lblRulesRules";
            this.lblRulesRules.Size = new System.Drawing.Size(443, 68);
            this.lblRulesRules.TabIndex = 1;
            this.lblRulesRules.Text = resources.GetString("lblRulesRules.Text");
            this.lblRulesRules.Click += new System.EventHandler(this.LblRulesRules_Click);
            // 
            // contRules
            // 
            this.contRules.Controls.Add(this.lblRulesRules);
            this.contRules.Controls.Add(this.lblRulesTitle);
            this.contRules.Location = new System.Drawing.Point(21, 29);
            this.contRules.Name = "contRules";
            this.contRules.Size = new System.Drawing.Size(510, 136);
            this.contRules.TabIndex = 2;
            this.contRules.TabStop = false;
            // 
            // contWires
            // 
            this.contWires.Controls.Add(this.btnWire004);
            this.contWires.Controls.Add(this.btnWire005);
            this.contWires.Controls.Add(this.btnWire001);
            this.contWires.Controls.Add(this.btnWire002);
            this.contWires.Controls.Add(this.btnWire003);
            this.contWires.Location = new System.Drawing.Point(21, 201);
            this.contWires.Name = "contWires";
            this.contWires.Size = new System.Drawing.Size(510, 133);
            this.contWires.TabIndex = 8;
            this.contWires.TabStop = false;
            // 
            // btnWire004
            // 
            this.btnWire004.BackColor = System.Drawing.Color.White;
            this.btnWire004.Enabled = false;
            this.btnWire004.Location = new System.Drawing.Point(51, 82);
            this.btnWire004.Name = "btnWire004";
            this.btnWire004.Size = new System.Drawing.Size(414, 10);
            this.btnWire004.TabIndex = 11;
            this.btnWire004.UseVisualStyleBackColor = false;
            // 
            // btnWire005
            // 
            this.btnWire005.BackColor = System.Drawing.Color.Yellow;
            this.btnWire005.Enabled = false;
            this.btnWire005.Location = new System.Drawing.Point(51, 98);
            this.btnWire005.Name = "btnWire005";
            this.btnWire005.Size = new System.Drawing.Size(414, 10);
            this.btnWire005.TabIndex = 12;
            this.btnWire005.UseVisualStyleBackColor = false;
            // 
            // btnWire001
            // 
            this.btnWire001.BackColor = System.Drawing.Color.Red;
            this.btnWire001.Enabled = false;
            this.btnWire001.Location = new System.Drawing.Point(51, 34);
            this.btnWire001.Name = "btnWire001";
            this.btnWire001.Size = new System.Drawing.Size(414, 10);
            this.btnWire001.TabIndex = 8;
            this.btnWire001.UseVisualStyleBackColor = false;
            // 
            // btnWire002
            // 
            this.btnWire002.BackColor = System.Drawing.Color.Black;
            this.btnWire002.Enabled = false;
            this.btnWire002.Location = new System.Drawing.Point(51, 50);
            this.btnWire002.Name = "btnWire002";
            this.btnWire002.Size = new System.Drawing.Size(414, 10);
            this.btnWire002.TabIndex = 9;
            this.btnWire002.UseVisualStyleBackColor = false;
            // 
            // btnWire003
            // 
            this.btnWire003.BackColor = System.Drawing.Color.Blue;
            this.btnWire003.Enabled = false;
            this.btnWire003.Location = new System.Drawing.Point(51, 66);
            this.btnWire003.Name = "btnWire003";
            this.btnWire003.Size = new System.Drawing.Size(414, 10);
            this.btnWire003.TabIndex = 10;
            this.btnWire003.UseVisualStyleBackColor = false;
            // 
            // btnStartReset
            // 
            this.btnStartReset.Location = new System.Drawing.Point(393, 48);
            this.btnStartReset.Name = "btnStartReset";
            this.btnStartReset.Size = new System.Drawing.Size(132, 37);
            this.btnStartReset.TabIndex = 9;
            this.btnStartReset.Text = "Start Game";
            this.btnStartReset.UseVisualStyleBackColor = true;
            this.btnStartReset.Click += new System.EventHandler(this.btnStartReset_Click);
            // 
            // progressBar001
            // 
            this.progressBar001.Location = new System.Drawing.Point(21, 171);
            this.progressBar001.Name = "progressBar001";
            this.progressBar001.Size = new System.Drawing.Size(510, 24);
            this.progressBar001.TabIndex = 10;
            this.progressBar001.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contStatus
            // 
            this.contStatus.Controls.Add(this.cmbBStatus);
            this.contStatus.Controls.Add(this.lblStatusTitle);
            this.contStatus.Location = new System.Drawing.Point(21, 340);
            this.contStatus.Name = "contStatus";
            this.contStatus.Size = new System.Drawing.Size(510, 164);
            this.contStatus.TabIndex = 11;
            this.contStatus.TabStop = false;
            // 
            // cmbBStatus
            // 
            this.cmbBStatus.FormattingEnabled = true;
            this.cmbBStatus.ItemHeight = 16;
            this.cmbBStatus.Location = new System.Drawing.Point(13, 48);
            this.cmbBStatus.Name = "cmbBStatus";
            this.cmbBStatus.Size = new System.Drawing.Size(491, 100);
            this.cmbBStatus.TabIndex = 14;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(10, 27);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(48, 17);
            this.lblStatusTitle.TabIndex = 13;
            this.lblStatusTitle.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 516);
            this.Controls.Add(this.contStatus);
            this.Controls.Add(this.progressBar001);
            this.Controls.Add(this.btnStartReset);
            this.Controls.Add(this.contWires);
            this.Controls.Add(this.contRules);
            this.Name = "Form1";
            this.Text = "Keep Talking and Nobody Explodes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contRules.ResumeLayout(false);
            this.contRules.PerformLayout();
            this.contWires.ResumeLayout(false);
            this.contStatus.ResumeLayout(false);
            this.contStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRulesTitle;
        private System.Windows.Forms.Label lblRulesRules;
        private System.Windows.Forms.GroupBox contRules;
        private System.Windows.Forms.GroupBox contWires;
        private System.Windows.Forms.Button btnWire004;
        private System.Windows.Forms.Button btnWire005;
        private System.Windows.Forms.Button btnWire001;
        private System.Windows.Forms.Button btnWire002;
        private System.Windows.Forms.Button btnWire003;
        private System.Windows.Forms.Button btnStartReset;
        private System.Windows.Forms.ProgressBar progressBar001;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox contStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.ListBox cmbBStatus;
    }
}

