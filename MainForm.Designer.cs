namespace PokerApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.smallBlindNextPot = new System.Windows.Forms.Label();
            this.smallBlindPot = new System.Windows.Forms.Label();
            this.smallBlindLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.anteNextPot = new System.Windows.Forms.Label();
            this.antePot = new System.Windows.Forms.Label();
            this.anteLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bigBlindNextPot = new System.Windows.Forms.Label();
            this.bigBlindPot = new System.Windows.Forms.Label();
            this.bigBlindLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Controls.Add(this.closeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 40);
            this.panel1.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuLabel.ForeColor = System.Drawing.Color.Indigo;
            this.menuLabel.Location = new System.Drawing.Point(0, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(100, 40);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeLabel
            // 
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.Red;
            this.closeLabel.Location = new System.Drawing.Point(1250, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(30, 40);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "x";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(151)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.smallBlindNextPot);
            this.panel4.Controls.Add(this.smallBlindPot);
            this.panel4.Controls.Add(this.smallBlindLabel);
            this.panel4.Location = new System.Drawing.Point(132, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 120);
            this.panel4.TabIndex = 1;
            // 
            // smallBlindNextPot
            // 
            this.smallBlindNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.smallBlindNextPot.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallBlindNextPot.ForeColor = System.Drawing.Color.Coral;
            this.smallBlindNextPot.Location = new System.Drawing.Point(0, 80);
            this.smallBlindNextPot.Name = "smallBlindNextPot";
            this.smallBlindNextPot.Size = new System.Drawing.Size(250, 40);
            this.smallBlindNextPot.TabIndex = 2;
            this.smallBlindNextPot.Text = "Next: 100";
            this.smallBlindNextPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smallBlindPot
            // 
            this.smallBlindPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.smallBlindPot.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallBlindPot.ForeColor = System.Drawing.Color.Coral;
            this.smallBlindPot.Location = new System.Drawing.Point(0, 40);
            this.smallBlindPot.Name = "smallBlindPot";
            this.smallBlindPot.Size = new System.Drawing.Size(250, 40);
            this.smallBlindPot.TabIndex = 1;
            this.smallBlindPot.Text = "100";
            this.smallBlindPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smallBlindLabel
            // 
            this.smallBlindLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.smallBlindLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallBlindLabel.ForeColor = System.Drawing.Color.White;
            this.smallBlindLabel.Location = new System.Drawing.Point(0, 0);
            this.smallBlindLabel.Name = "smallBlindLabel";
            this.smallBlindLabel.Size = new System.Drawing.Size(250, 40);
            this.smallBlindLabel.TabIndex = 0;
            this.smallBlindLabel.Text = "small blind";
            this.smallBlindLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(151)))), ((int)(((byte)(165)))));
            this.panel6.Controls.Add(this.anteNextPot);
            this.panel6.Controls.Add(this.antePot);
            this.panel6.Controls.Add(this.anteLabel);
            this.panel6.Location = new System.Drawing.Point(897, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 120);
            this.panel6.TabIndex = 3;
            // 
            // anteNextPot
            // 
            this.anteNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.anteNextPot.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anteNextPot.ForeColor = System.Drawing.Color.Coral;
            this.anteNextPot.Location = new System.Drawing.Point(0, 80);
            this.anteNextPot.Name = "anteNextPot";
            this.anteNextPot.Size = new System.Drawing.Size(250, 40);
            this.anteNextPot.TabIndex = 5;
            this.anteNextPot.Text = "Next: 100";
            this.anteNextPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // antePot
            // 
            this.antePot.Dock = System.Windows.Forms.DockStyle.Top;
            this.antePot.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.antePot.ForeColor = System.Drawing.Color.Coral;
            this.antePot.Location = new System.Drawing.Point(0, 40);
            this.antePot.Name = "antePot";
            this.antePot.Size = new System.Drawing.Size(250, 40);
            this.antePot.TabIndex = 4;
            this.antePot.Text = "50";
            this.antePot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // anteLabel
            // 
            this.anteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.anteLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anteLabel.ForeColor = System.Drawing.Color.White;
            this.anteLabel.Location = new System.Drawing.Point(0, 0);
            this.anteLabel.Name = "anteLabel";
            this.anteLabel.Size = new System.Drawing.Size(250, 40);
            this.anteLabel.TabIndex = 3;
            this.anteLabel.Text = "ante";
            this.anteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(151)))), ((int)(((byte)(165)))));
            this.panel7.Controls.Add(this.bigBlindNextPot);
            this.panel7.Controls.Add(this.bigBlindPot);
            this.panel7.Controls.Add(this.bigBlindLabel);
            this.panel7.Location = new System.Drawing.Point(515, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 120);
            this.panel7.TabIndex = 4;
            // 
            // bigBlindNextPot
            // 
            this.bigBlindNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigBlindNextPot.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigBlindNextPot.ForeColor = System.Drawing.Color.Coral;
            this.bigBlindNextPot.Location = new System.Drawing.Point(0, 80);
            this.bigBlindNextPot.Name = "bigBlindNextPot";
            this.bigBlindNextPot.Size = new System.Drawing.Size(250, 40);
            this.bigBlindNextPot.TabIndex = 5;
            this.bigBlindNextPot.Text = "Next: 200";
            this.bigBlindNextPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bigBlindPot
            // 
            this.bigBlindPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigBlindPot.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigBlindPot.ForeColor = System.Drawing.Color.Coral;
            this.bigBlindPot.Location = new System.Drawing.Point(0, 40);
            this.bigBlindPot.Name = "bigBlindPot";
            this.bigBlindPot.Size = new System.Drawing.Size(250, 40);
            this.bigBlindPot.TabIndex = 4;
            this.bigBlindPot.Text = "100";
            this.bigBlindPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bigBlindLabel
            // 
            this.bigBlindLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigBlindLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigBlindLabel.ForeColor = System.Drawing.Color.White;
            this.bigBlindLabel.Location = new System.Drawing.Point(0, 0);
            this.bigBlindLabel.Name = "bigBlindLabel";
            this.bigBlindLabel.Size = new System.Drawing.Size(250, 40);
            this.bigBlindLabel.TabIndex = 3;
            this.bigBlindLabel.Text = "big blind";
            this.bigBlindLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.ForeColor = System.Drawing.Color.DarkRed;
            this.timer.Location = new System.Drawing.Point(540, 350);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(200, 70);
            this.timer.TabIndex = 5;
            this.timer.Text = "15:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(70, 600);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 60);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Timer";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label smallBlindLabel;
        private System.Windows.Forms.Label smallBlindPot;
        private System.Windows.Forms.Label smallBlindNextPot;
        private System.Windows.Forms.Label anteNextPot;
        private System.Windows.Forms.Label antePot;
        private System.Windows.Forms.Label anteLabel;
        private System.Windows.Forms.Label bigBlindNextPot;
        private System.Windows.Forms.Label bigBlindPot;
        private System.Windows.Forms.Label bigBlindLabel;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label menuLabel;
    }
}