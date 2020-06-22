namespace Игра
{
    partial class LoserForm
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
            this.labelLose = new System.Windows.Forms.Label();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.Red;
            this.labelLose.Location = new System.Drawing.Point(70, 43);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(445, 55);
            this.labelLose.TabIndex = 0;
            this.labelLose.Text = "Вы проиграли :((((";
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTryAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTryAgain.Location = new System.Drawing.Point(125, 205);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(150, 36);
            this.btnTryAgain.TabIndex = 1;
            this.btnTryAgain.Text = "Сыграть еще раз";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainMenu.Location = new System.Drawing.Point(304, 205);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(135, 36);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Главное меню";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSeconds.Location = new System.Drawing.Point(446, 138);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(27, 19);
            this.labelSeconds.TabIndex = 30;
            this.labelSeconds.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(434, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = ":";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMinutes.Location = new System.Drawing.Point(412, 138);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(27, 19);
            this.labelMinutes.TabIndex = 28;
            this.labelMinutes.Text = "00";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDifficulty.Location = new System.Drawing.Point(66, 140);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(300, 18);
            this.labelDifficulty.TabIndex = 35;
            this.labelDifficulty.Text = "Общее время игры на легком уровне";
            // 
            // LoserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.labelLose);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "LoserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelDifficulty;
    }
}