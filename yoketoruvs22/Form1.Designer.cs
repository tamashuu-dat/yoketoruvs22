
namespace yoketoruvs22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(205, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(378, 86);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2022";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(303, 272);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(192, 91);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート‼";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(274, 391);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(250, 32);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Cpoyright © 2022 たま";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("AR DARLING", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(25, 18);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(116, 30);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Font = new System.Drawing.Font("AR DARLING", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highLabel.Location = new System.Drawing.Point(303, 187);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(190, 30);
            this.highLabel.TabIndex = 4;
            this.highLabel.Text = "High Score 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("AR DARLING", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftLabel.Location = new System.Drawing.Point(699, 18);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(65, 30);
            this.leftLabel.TabIndex = 5;
            this.leftLabel.Text = "★:10";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("AR DARLING", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameOverLabel.Location = new System.Drawing.Point(274, 189);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(246, 59);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "GameOver";
            this.gameOverLabel.Visible = false;
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.ForeColor = System.Drawing.Color.Red;
            this.clearLabel.Location = new System.Drawing.Point(314, 189);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(170, 65);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "Clear!!";
            this.clearLabel.Visible = false;
            // 
            // titlebutton
            // 
            this.titlebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.titlebutton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlebutton.Location = new System.Drawing.Point(303, 272);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(192, 91);
            this.titlebutton.TabIndex = 8;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = false;
            this.titlebutton.Visible = false;
            this.titlebutton.Click += new System.EventHandler(this.titlebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLabel.Location = new System.Drawing.Point(148, 289);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(52, 45);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "★";
            this.tempLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "よけとる2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titlebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tempLabel;
    }
}

