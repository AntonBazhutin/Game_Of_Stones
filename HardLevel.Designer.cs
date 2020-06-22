namespace Игра
{
    partial class HardLevel
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
            this.labelCurrentCountOfStonesInThirdHeap = new System.Windows.Forms.Label();
            this.labelCurrentCountOfStonesInFirstHeap = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTimes = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWhosTurn = new System.Windows.Forms.Label();
            this.labelCountOfStones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentCountOfStonesInSecondHeap = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCurrentCountOfStonesInThirdHeap
            // 
            this.labelCurrentCountOfStonesInThirdHeap.AutoSize = true;
            this.labelCurrentCountOfStonesInThirdHeap.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCountOfStonesInThirdHeap.Location = new System.Drawing.Point(381, 125);
            this.labelCurrentCountOfStonesInThirdHeap.Name = "labelCurrentCountOfStonesInThirdHeap";
            this.labelCurrentCountOfStonesInThirdHeap.Size = new System.Drawing.Size(62, 48);
            this.labelCurrentCountOfStonesInThirdHeap.TabIndex = 41;
            this.labelCurrentCountOfStonesInThirdHeap.Text = "12";
            this.labelCurrentCountOfStonesInThirdHeap.Click += new System.EventHandler(this.labelCurrentCountOfStonesInThirdHeap_Click);
            // 
            // labelCurrentCountOfStonesInFirstHeap
            // 
            this.labelCurrentCountOfStonesInFirstHeap.AutoSize = true;
            this.labelCurrentCountOfStonesInFirstHeap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentCountOfStonesInFirstHeap.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCountOfStonesInFirstHeap.Location = new System.Drawing.Point(155, 125);
            this.labelCurrentCountOfStonesInFirstHeap.Name = "labelCurrentCountOfStonesInFirstHeap";
            this.labelCurrentCountOfStonesInFirstHeap.Size = new System.Drawing.Size(64, 50);
            this.labelCurrentCountOfStonesInFirstHeap.TabIndex = 40;
            this.labelCurrentCountOfStonesInFirstHeap.Text = "12";
            this.labelCurrentCountOfStonesInFirstHeap.Click += new System.EventHandler(this.labelCurrentCountOfStonesInFirstHeap_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(290, 263);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(81, 35);
            this.btnMinus.TabIndex = 39;
            this.btnMinus.Text = "- 5";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeconds.Location = new System.Drawing.Point(538, 9);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(27, 19);
            this.labelSeconds.TabIndex = 38;
            this.labelSeconds.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(527, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = ":";
            // 
            // BtnTimes
            // 
            this.BtnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTimes.Location = new System.Drawing.Point(97, 264);
            this.BtnTimes.Name = "BtnTimes";
            this.BtnTimes.Size = new System.Drawing.Size(75, 35);
            this.BtnTimes.TabIndex = 36;
            this.BtnTimes.Text = "x3";
            this.BtnTimes.UseVisualStyleBackColor = true;
            this.BtnTimes.Click += new System.EventHandler(this.BtnTimes_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPlus.Location = new System.Drawing.Point(191, 263);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(81, 35);
            this.BtnPlus.TabIndex = 35;
            this.BtnPlus.Text = "+2";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinutes.Location = new System.Drawing.Point(505, 9);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(27, 19);
            this.labelMinutes.TabIndex = 34;
            this.labelMinutes.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Время игры";
            // 
            // labelWhosTurn
            // 
            this.labelWhosTurn.AutoSize = true;
            this.labelWhosTurn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhosTurn.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelWhosTurn.Location = new System.Drawing.Point(229, 8);
            this.labelWhosTurn.Name = "labelWhosTurn";
            this.labelWhosTurn.Size = new System.Drawing.Size(116, 25);
            this.labelWhosTurn.TabIndex = 32;
            this.labelWhosTurn.Text = "ВАШ ХОД";
            // 
            // labelCountOfStones
            // 
            this.labelCountOfStones.AutoSize = true;
            this.labelCountOfStones.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountOfStones.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelCountOfStones.Location = new System.Drawing.Point(145, 0);
            this.labelCountOfStones.Name = "labelCountOfStones";
            this.labelCountOfStones.Size = new System.Drawing.Size(43, 33);
            this.labelCountOfStones.TabIndex = 31;
            this.labelCountOfStones.Text = "89";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = " Камней в куче :";
            // 
            // labelCurrentCountOfStonesInSecondHeap
            // 
            this.labelCurrentCountOfStonesInSecondHeap.AutoSize = true;
            this.labelCurrentCountOfStonesInSecondHeap.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCountOfStonesInSecondHeap.Location = new System.Drawing.Point(267, 125);
            this.labelCurrentCountOfStonesInSecondHeap.Name = "labelCurrentCountOfStonesInSecondHeap";
            this.labelCurrentCountOfStonesInSecondHeap.Size = new System.Drawing.Size(62, 48);
            this.labelCurrentCountOfStonesInSecondHeap.TabIndex = 42;
            this.labelCurrentCountOfStonesInSecondHeap.Text = "12";
            this.labelCurrentCountOfStonesInSecondHeap.Click += new System.EventHandler(this.labelCurrentCountOfStonesInSecondHeap_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(389, 263);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(81, 35);
            this.btnDivide.TabIndex = 43;
            this.btnDivide.Text = ": 4";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // TurnTimer
            // 
            this.TurnTimer.Enabled = true;
            this.TurnTimer.Interval = 6000;
            this.TurnTimer.Tick += new System.EventHandler(this.TurnTimer_Tick);
            // 
            // HardLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.labelCurrentCountOfStonesInSecondHeap);
            this.Controls.Add(this.labelCurrentCountOfStonesInThirdHeap);
            this.Controls.Add(this.labelCurrentCountOfStonesInFirstHeap);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTimes);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWhosTurn);
            this.Controls.Add(this.labelCountOfStones);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "HardLevel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HardLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentCountOfStonesInThirdHeap;
        private System.Windows.Forms.Label labelCurrentCountOfStonesInFirstHeap;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTimes;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWhosTurn;
        private System.Windows.Forms.Label labelCountOfStones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentCountOfStonesInSecondHeap;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer TurnTimer;
    }
}