namespace PokerApp
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSmallBlind = new System.Windows.Forms.Panel();
            this.smallBlindNextPot = new System.Windows.Forms.Label();
            this.smallBlindPot = new System.Windows.Forms.Label();
            this.labelSmallBlind = new System.Windows.Forms.Label();
            this.panelBigBlind = new System.Windows.Forms.Panel();
            this.bigBlindNextPot = new System.Windows.Forms.Label();
            this.bigBlindPot = new System.Windows.Forms.Label();
            this.labelBigBlind = new System.Windows.Forms.Label();
            this.panelAnte = new System.Windows.Forms.Panel();
            this.anteNextPot = new System.Windows.Forms.Label();
            this.antePot = new System.Windows.Forms.Label();
            this.labelAnte = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.blindMenu = new System.Windows.Forms.ComboBox();
            this.panelSmallBlind.SuspendLayout();
            this.panelBigBlind.SuspendLayout();
            this.panelAnte.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSmallBlind
            // 
            this.panelSmallBlind.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSmallBlind.Controls.Add(this.smallBlindNextPot);
            this.panelSmallBlind.Controls.Add(this.smallBlindPot);
            this.panelSmallBlind.Controls.Add(this.labelSmallBlind);
            this.panelSmallBlind.Location = new System.Drawing.Point(140, 70);
            this.panelSmallBlind.Name = "panelSmallBlind";
            this.panelSmallBlind.Size = new System.Drawing.Size(250, 120);
            this.panelSmallBlind.TabIndex = 0;
            // 
            // smallBlindNextPot
            // 
            this.smallBlindNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.smallBlindNextPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallBlindNextPot.ForeColor = System.Drawing.Color.Coral;
            this.smallBlindNextPot.Location = new System.Drawing.Point(0, 87);
            this.smallBlindNextPot.Name = "smallBlindNextPot";
            this.smallBlindNextPot.Size = new System.Drawing.Size(250, 33);
            this.smallBlindNextPot.TabIndex = 2;
            this.smallBlindNextPot.Text = "next: 100";
            this.smallBlindNextPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallBlindPot
            // 
            this.smallBlindPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.smallBlindPot.ForeColor = System.Drawing.Color.Coral;
            this.smallBlindPot.Location = new System.Drawing.Point(0, 41);
            this.smallBlindPot.Name = "smallBlindPot";
            this.smallBlindPot.Size = new System.Drawing.Size(250, 46);
            this.smallBlindPot.TabIndex = 1;
            this.smallBlindPot.Text = "100";
            this.smallBlindPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSmallBlind
            // 
            this.labelSmallBlind.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSmallBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSmallBlind.ForeColor = System.Drawing.Color.White;
            this.labelSmallBlind.Location = new System.Drawing.Point(0, 0);
            this.labelSmallBlind.Name = "labelSmallBlind";
            this.labelSmallBlind.Size = new System.Drawing.Size(250, 41);
            this.labelSmallBlind.TabIndex = 0;
            this.labelSmallBlind.Text = "small blind";
            this.labelSmallBlind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBigBlind
            // 
            this.panelBigBlind.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBigBlind.Controls.Add(this.bigBlindNextPot);
            this.panelBigBlind.Controls.Add(this.bigBlindPot);
            this.panelBigBlind.Controls.Add(this.labelBigBlind);
            this.panelBigBlind.Location = new System.Drawing.Point(530, 70);
            this.panelBigBlind.Name = "panelBigBlind";
            this.panelBigBlind.Size = new System.Drawing.Size(250, 120);
            this.panelBigBlind.TabIndex = 1;
            // 
            // bigBlindNextPot
            // 
            this.bigBlindNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigBlindNextPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigBlindNextPot.ForeColor = System.Drawing.Color.Coral;
            this.bigBlindNextPot.Location = new System.Drawing.Point(0, 87);
            this.bigBlindNextPot.Name = "bigBlindNextPot";
            this.bigBlindNextPot.Size = new System.Drawing.Size(250, 33);
            this.bigBlindNextPot.TabIndex = 3;
            this.bigBlindNextPot.Text = "next: 200";
            this.bigBlindNextPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigBlindPot
            // 
            this.bigBlindPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigBlindPot.ForeColor = System.Drawing.Color.Coral;
            this.bigBlindPot.Location = new System.Drawing.Point(0, 41);
            this.bigBlindPot.Name = "bigBlindPot";
            this.bigBlindPot.Size = new System.Drawing.Size(250, 46);
            this.bigBlindPot.TabIndex = 2;
            this.bigBlindPot.Text = "100";
            this.bigBlindPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBigBlind
            // 
            this.labelBigBlind.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBigBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBigBlind.ForeColor = System.Drawing.Color.White;
            this.labelBigBlind.Location = new System.Drawing.Point(0, 0);
            this.labelBigBlind.Name = "labelBigBlind";
            this.labelBigBlind.Size = new System.Drawing.Size(250, 41);
            this.labelBigBlind.TabIndex = 1;
            this.labelBigBlind.Text = "big blind";
            this.labelBigBlind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAnte
            // 
            this.panelAnte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelAnte.Controls.Add(this.anteNextPot);
            this.panelAnte.Controls.Add(this.antePot);
            this.panelAnte.Controls.Add(this.labelAnte);
            this.panelAnte.Location = new System.Drawing.Point(920, 70);
            this.panelAnte.Name = "panelAnte";
            this.panelAnte.Size = new System.Drawing.Size(250, 120);
            this.panelAnte.TabIndex = 2;
            this.panelAnte.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // anteNextPot
            // 
            this.anteNextPot.Dock = System.Windows.Forms.DockStyle.Top;
            this.anteNextPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anteNextPot.ForeColor = System.Drawing.Color.Coral;
            this.anteNextPot.Location = new System.Drawing.Point(0, 87);
            this.anteNextPot.Name = "anteNextPot";
            this.anteNextPot.Size = new System.Drawing.Size(250, 33);
            this.anteNextPot.TabIndex = 3;
            this.anteNextPot.Text = "next: 100";
            this.anteNextPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // antePot
            // 
            this.antePot.Dock = System.Windows.Forms.DockStyle.Top;
            this.antePot.ForeColor = System.Drawing.Color.Coral;
            this.antePot.Location = new System.Drawing.Point(0, 41);
            this.antePot.Name = "antePot";
            this.antePot.Size = new System.Drawing.Size(250, 46);
            this.antePot.TabIndex = 2;
            this.antePot.Text = "100";
            this.antePot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnte
            // 
            this.labelAnte.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnte.ForeColor = System.Drawing.Color.White;
            this.labelAnte.Location = new System.Drawing.Point(0, 0);
            this.labelAnte.Name = "labelAnte";
            this.labelAnte.Size = new System.Drawing.Size(250, 41);
            this.labelAnte.TabIndex = 1;
            this.labelAnte.Text = "ante";
            this.labelAnte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panelSmallBlind);
            this.panel4.Controls.Add(this.panelAnte);
            this.panel4.Controls.Add(this.panelBigBlind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1310, 190);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.closeButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1310, 48);
            this.panel5.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(1271, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 48);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer
            // 
            this.timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.ForeColor = System.Drawing.Color.DarkOrange;
            this.timer.Location = new System.Drawing.Point(0, 0);
            this.timer.Margin = new System.Windows.Forms.Padding(0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(307, 109);
            this.timer.TabIndex = 4;
            this.timer.Text = "15:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timer);
            this.panel1.Location = new System.Drawing.Point(507, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 109);
            this.panel1.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(51, 624);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 86);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // blindMenu
            // 
            this.blindMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blindMenu.FormattingEnabled = true;
            this.blindMenu.Items.AddRange(new object[] {
            "dfdfdf",
            "dddddd",
            "ffggfghhj",
            "ddd"});
            this.blindMenu.Location = new System.Drawing.Point(1010, 647);
            this.blindMenu.Name = "blindMenu";
            this.blindMenu.Size = new System.Drawing.Size(196, 46);
            this.blindMenu.TabIndex = 8;
            this.blindMenu.Text = "first var";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1310, 750);
            this.Controls.Add(this.blindMenu);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Timer";
            this.panelSmallBlind.ResumeLayout(false);
            this.panelBigBlind.ResumeLayout(false);
            this.panelAnte.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSmallBlind;
        private System.Windows.Forms.Panel panelBigBlind;
        private System.Windows.Forms.Panel panelAnte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSmallBlind;
        private System.Windows.Forms.Label labelBigBlind;
        private System.Windows.Forms.Label labelAnte;
        private System.Windows.Forms.Label smallBlindPot;
        private System.Windows.Forms.Label bigBlindPot;
        private System.Windows.Forms.Label antePot;
        private System.Windows.Forms.Label smallBlindNextPot;
        private System.Windows.Forms.Label bigBlindNextPot;
        private System.Windows.Forms.Label anteNextPot;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox blindMenu;
    }
}

