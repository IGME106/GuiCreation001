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
            this.LblRulesTitle = new System.Windows.Forms.Label();
            this.LblRulesRules = new System.Windows.Forms.Label();
            this.ContRules = new System.Windows.Forms.GroupBox();
            this.ContWires = new System.Windows.Forms.GroupBox();
            this.BtnWire004 = new System.Windows.Forms.Button();
            this.BtnWire005 = new System.Windows.Forms.Button();
            this.BtnWire001 = new System.Windows.Forms.Button();
            this.BtnWire002 = new System.Windows.Forms.Button();
            this.BtnWire003 = new System.Windows.Forms.Button();
            this.BtnStartStopReset = new System.Windows.Forms.Button();
            this.ProgressBar001 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContStatus = new System.Windows.Forms.GroupBox();
            this.LabelStatusStatus = new System.Windows.Forms.Label();
            this.LblStatusTitle = new System.Windows.Forms.Label();
            this.ContRules.SuspendLayout();
            this.ContWires.SuspendLayout();
            this.ContStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRulesTitle
            // 
            this.LblRulesTitle.AutoSize = true;
            this.LblRulesTitle.Location = new System.Drawing.Point(10, 30);
            this.LblRulesTitle.Name = "LblRulesTitle";
            this.LblRulesTitle.Size = new System.Drawing.Size(44, 17);
            this.LblRulesTitle.TabIndex = 0;
            this.LblRulesTitle.Text = "Rules";
            // 
            // LblRulesRules
            // 
            this.LblRulesRules.AutoSize = true;
            this.LblRulesRules.Location = new System.Drawing.Point(20, 59);
            this.LblRulesRules.Name = "LblRulesRules";
            this.LblRulesRules.Size = new System.Drawing.Size(443, 68);
            this.LblRulesRules.TabIndex = 1;
            this.LblRulesRules.Text = resources.GetString("LblRulesRules.Text");
            this.LblRulesRules.Click += new System.EventHandler(this.LblRulesRules_Click);
            // 
            // ContRules
            // 
            this.ContRules.Controls.Add(this.LblRulesRules);
            this.ContRules.Controls.Add(this.LblRulesTitle);
            this.ContRules.Location = new System.Drawing.Point(21, 29);
            this.ContRules.Name = "ContRules";
            this.ContRules.Size = new System.Drawing.Size(510, 136);
            this.ContRules.TabIndex = 2;
            this.ContRules.TabStop = false;
            this.ContRules.Text = "ContRules";
            // 
            // ContWires
            // 
            this.ContWires.Controls.Add(this.BtnWire004);
            this.ContWires.Controls.Add(this.BtnWire005);
            this.ContWires.Controls.Add(this.BtnWire001);
            this.ContWires.Controls.Add(this.BtnWire002);
            this.ContWires.Controls.Add(this.BtnWire003);
            this.ContWires.Location = new System.Drawing.Point(21, 201);
            this.ContWires.Name = "ContWires";
            this.ContWires.Size = new System.Drawing.Size(510, 133);
            this.ContWires.TabIndex = 8;
            this.ContWires.TabStop = false;
            this.ContWires.Text = "ContWires";
            // 
            // BtnWire004
            // 
            this.BtnWire004.BackColor = System.Drawing.Color.White;
            this.BtnWire004.Enabled = false;
            this.BtnWire004.Location = new System.Drawing.Point(51, 82);
            this.BtnWire004.Name = "BtnWire004";
            this.BtnWire004.Size = new System.Drawing.Size(414, 10);
            this.BtnWire004.TabIndex = 11;
            this.BtnWire004.UseVisualStyleBackColor = false;
            // 
            // BtnWire005
            // 
            this.BtnWire005.BackColor = System.Drawing.Color.Yellow;
            this.BtnWire005.Enabled = false;
            this.BtnWire005.Location = new System.Drawing.Point(51, 98);
            this.BtnWire005.Name = "BtnWire005";
            this.BtnWire005.Size = new System.Drawing.Size(414, 10);
            this.BtnWire005.TabIndex = 12;
            this.BtnWire005.UseVisualStyleBackColor = false;
            // 
            // BtnWire001
            // 
            this.BtnWire001.BackColor = System.Drawing.Color.Red;
            this.BtnWire001.Enabled = false;
            this.BtnWire001.Location = new System.Drawing.Point(51, 34);
            this.BtnWire001.Name = "BtnWire001";
            this.BtnWire001.Size = new System.Drawing.Size(414, 10);
            this.BtnWire001.TabIndex = 8;
            this.BtnWire001.UseVisualStyleBackColor = false;
            // 
            // BtnWire002
            // 
            this.BtnWire002.BackColor = System.Drawing.Color.Black;
            this.BtnWire002.Enabled = false;
            this.BtnWire002.Location = new System.Drawing.Point(51, 50);
            this.BtnWire002.Name = "BtnWire002";
            this.BtnWire002.Size = new System.Drawing.Size(414, 10);
            this.BtnWire002.TabIndex = 9;
            this.BtnWire002.UseVisualStyleBackColor = false;
            // 
            // BtnWire003
            // 
            this.BtnWire003.BackColor = System.Drawing.Color.Blue;
            this.BtnWire003.Enabled = false;
            this.BtnWire003.Location = new System.Drawing.Point(51, 66);
            this.BtnWire003.Name = "BtnWire003";
            this.BtnWire003.Size = new System.Drawing.Size(414, 10);
            this.BtnWire003.TabIndex = 10;
            this.BtnWire003.UseVisualStyleBackColor = false;
            // 
            // BtnStartStopReset
            // 
            this.BtnStartStopReset.Location = new System.Drawing.Point(393, 48);
            this.BtnStartStopReset.Name = "BtnStartStopReset";
            this.BtnStartStopReset.Size = new System.Drawing.Size(132, 37);
            this.BtnStartStopReset.TabIndex = 9;
            this.BtnStartStopReset.Text = "Start Game";
            this.BtnStartStopReset.UseVisualStyleBackColor = true;
            // 
            // ProgressBar001
            // 
            this.ProgressBar001.Location = new System.Drawing.Point(21, 171);
            this.ProgressBar001.Name = "ProgressBar001";
            this.ProgressBar001.Size = new System.Drawing.Size(510, 24);
            this.ProgressBar001.TabIndex = 10;
            this.ProgressBar001.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // ContStatus
            // 
            this.ContStatus.Controls.Add(this.LabelStatusStatus);
            this.ContStatus.Controls.Add(this.LblStatusTitle);
            this.ContStatus.Location = new System.Drawing.Point(21, 340);
            this.ContStatus.Name = "ContStatus";
            this.ContStatus.Size = new System.Drawing.Size(510, 100);
            this.ContStatus.TabIndex = 11;
            this.ContStatus.TabStop = false;
            this.ContStatus.Text = "ContStatus";
            // 
            // LabelStatusStatus
            // 
            this.LabelStatusStatus.AutoSize = true;
            this.LabelStatusStatus.Location = new System.Drawing.Point(20, 54);
            this.LabelStatusStatus.Name = "LabelStatusStatus";
            this.LabelStatusStatus.Size = new System.Drawing.Size(46, 17);
            this.LabelStatusStatus.TabIndex = 14;
            this.LabelStatusStatus.Text = "label1";
            // 
            // LblStatusTitle
            // 
            this.LblStatusTitle.AutoSize = true;
            this.LblStatusTitle.Location = new System.Drawing.Point(10, 27);
            this.LblStatusTitle.Name = "LblStatusTitle";
            this.LblStatusTitle.Size = new System.Drawing.Size(48, 17);
            this.LblStatusTitle.TabIndex = 13;
            this.LblStatusTitle.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 471);
            this.Controls.Add(this.ContStatus);
            this.Controls.Add(this.ProgressBar001);
            this.Controls.Add(this.BtnStartStopReset);
            this.Controls.Add(this.ContWires);
            this.Controls.Add(this.ContRules);
            this.Name = "Form1";
            this.Text = "Keep Talking and Nobody Explodes";
            this.ContRules.ResumeLayout(false);
            this.ContRules.PerformLayout();
            this.ContWires.ResumeLayout(false);
            this.ContStatus.ResumeLayout(false);
            this.ContStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRulesTitle;
        private System.Windows.Forms.Label LblRulesRules;
        private System.Windows.Forms.GroupBox ContRules;
        private System.Windows.Forms.GroupBox ContWires;
        private System.Windows.Forms.Button BtnWire004;
        private System.Windows.Forms.Button BtnWire005;
        private System.Windows.Forms.Button BtnWire001;
        private System.Windows.Forms.Button BtnWire002;
        private System.Windows.Forms.Button BtnWire003;
        private System.Windows.Forms.Button BtnStartStopReset;
        private System.Windows.Forms.ProgressBar ProgressBar001;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox ContStatus;
        private System.Windows.Forms.Label LabelStatusStatus;
        private System.Windows.Forms.Label LblStatusTitle;
    }
}

