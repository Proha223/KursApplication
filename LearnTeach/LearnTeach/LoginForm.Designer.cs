namespace LearnTeach
{
    partial class LoginForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.PictureBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LockPass = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.SecondPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.ClearButton2 = new System.Windows.Forms.PictureBox();
            this.UnlockPass = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.ShowButton = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SecondPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(12)))));
            this.MainPanel.Controls.Add(this.ClearButton);
            this.MainPanel.Controls.Add(this.EnterButton);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.LockPass);
            this.MainPanel.Controls.Add(this.LoginTextBox);
            this.MainPanel.Controls.Add(this.LoginPicture);
            this.MainPanel.Controls.Add(this.SecondPanel);
            this.MainPanel.Controls.Add(this.ClearButton2);
            this.MainPanel.Controls.Add(this.UnlockPass);
            this.MainPanel.Controls.Add(this.HideButton);
            this.MainPanel.Controls.Add(this.ShowButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(779, 468);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ClearButton
            // 
            this.ClearButton.Image = global::LearnTeach.Properties.Resources.bin;
            this.ClearButton.Location = new System.Drawing.Point(644, 159);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(71, 62);
            this.ClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearButton.TabIndex = 6;
            this.ClearButton.TabStop = false;
            this.ClearButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearButton_MouseDown);
            this.ClearButton.MouseLeave += new System.EventHandler(this.ClearButton_MouseLeave);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(257, 374);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(272, 62);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(188, 263);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(424, 58);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LockPass
            // 
            this.LockPass.Image = global::LearnTeach.Properties.Resources._lock;
            this.LockPass.Location = new System.Drawing.Point(95, 263);
            this.LockPass.Margin = new System.Windows.Forms.Padding(4);
            this.LockPass.Name = "LockPass";
            this.LockPass.Size = new System.Drawing.Size(85, 79);
            this.LockPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockPass.TabIndex = 3;
            this.LockPass.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(188, 154);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(424, 58);
            this.LoginTextBox.TabIndex = 2;
            // 
            // LoginPicture
            // 
            this.LoginPicture.Image = global::LearnTeach.Properties.Resources.user;
            this.LoginPicture.Location = new System.Drawing.Point(95, 154);
            this.LoginPicture.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(85, 79);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicture.TabIndex = 1;
            this.LoginPicture.TabStop = false;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(1)))), ((int)(((byte)(58)))));
            this.SecondPanel.Controls.Add(this.CloseButton);
            this.SecondPanel.Controls.Add(this.Text);
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondPanel.Location = new System.Drawing.Point(0, 0);
            this.SecondPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Size = new System.Drawing.Size(779, 114);
            this.SecondPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(743, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 39);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Text
            // 
            this.Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.ForeColor = System.Drawing.SystemColors.Info;
            this.Text.Location = new System.Drawing.Point(0, 0);
            this.Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(779, 114);
            this.Text.TabIndex = 0;
            this.Text.Text = "Авторизация";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Text_MouseDown);
            this.Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Text_MouseMove);
            // 
            // ClearButton2
            // 
            this.ClearButton2.Image = global::LearnTeach.Properties.Resources.bluebin;
            this.ClearButton2.Location = new System.Drawing.Point(644, 159);
            this.ClearButton2.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(71, 62);
            this.ClearButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearButton2.TabIndex = 8;
            this.ClearButton2.TabStop = false;
            // 
            // UnlockPass
            // 
            this.UnlockPass.Image = global::LearnTeach.Properties.Resources.unlock;
            this.UnlockPass.Location = new System.Drawing.Point(95, 263);
            this.UnlockPass.Margin = new System.Windows.Forms.Padding(4);
            this.UnlockPass.Name = "UnlockPass";
            this.UnlockPass.Size = new System.Drawing.Size(85, 79);
            this.UnlockPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UnlockPass.TabIndex = 9;
            this.UnlockPass.TabStop = false;
            // 
            // HideButton
            // 
            this.HideButton.Image = global::LearnTeach.Properties.Resources.hide1;
            this.HideButton.Location = new System.Drawing.Point(644, 268);
            this.HideButton.Margin = new System.Windows.Forms.Padding(4);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(71, 62);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideButton.TabIndex = 11;
            this.HideButton.TabStop = false;
            this.HideButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HideButton_MouseDown);
            // 
            // ShowButton
            // 
            this.ShowButton.Image = global::LearnTeach.Properties.Resources.show;
            this.ShowButton.Location = new System.Drawing.Point(644, 268);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(71, 62);
            this.ShowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowButton.TabIndex = 10;
            this.ShowButton.TabStop = false;
            this.ShowButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowButton_MouseDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 468);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.SecondPanel.ResumeLayout(false);
            this.SecondPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondPanel;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox LockPass;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.PictureBox ClearButton;
        private System.Windows.Forms.PictureBox ClearButton2;
        private System.Windows.Forms.PictureBox UnlockPass;
        private System.Windows.Forms.PictureBox ShowButton;
        private System.Windows.Forms.PictureBox HideButton;
    }
}