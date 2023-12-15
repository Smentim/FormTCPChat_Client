namespace FormTCPChat_Client
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
            fon = new Panel();
            yet_register = new Label();
            check_show_password = new CheckBox();
            button_auth = new Button();
            password_box = new TextBox();
            pictureBox_password = new PictureBox();
            login_box = new TextBox();
            pictureBox_login = new PictureBox();
            panel2 = new Panel();
            auth = new Label();
            fon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // fon
            // 
            fon.BackColor = Color.FromArgb(110, 110, 110);
            fon.Controls.Add(yet_register);
            fon.Controls.Add(check_show_password);
            fon.Controls.Add(button_auth);
            fon.Controls.Add(password_box);
            fon.Controls.Add(pictureBox_password);
            fon.Controls.Add(login_box);
            fon.Controls.Add(pictureBox_login);
            fon.Controls.Add(panel2);
            fon.Dock = DockStyle.Fill;
            fon.Location = new Point(0, 0);
            fon.Margin = new Padding(3, 4, 3, 4);
            fon.Name = "fon";
            fon.Size = new Size(263, 242);
            fon.TabIndex = 0;
            // 
            // yet_register
            // 
            yet_register.Anchor = AnchorStyles.None;
            yet_register.AutoSize = true;
            yet_register.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            yet_register.ForeColor = Color.White;
            yet_register.ImageAlign = ContentAlignment.BottomCenter;
            yet_register.Location = new Point(20, 214);
            yet_register.Name = "yet_register";
            yet_register.Size = new Size(224, 20);
            yet_register.TabIndex = 14;
            yet_register.Text = "У вас еще нет аккаунта?";
            yet_register.TextAlign = ContentAlignment.TopCenter;
            yet_register.Click += yet_register_Click;
            yet_register.MouseLeave += yet_register_MouseLeave;
            yet_register.MouseHover += yet_register_MouseHover;
            // 
            // check_show_password
            // 
            check_show_password.AutoSize = true;
            check_show_password.ForeColor = Color.White;
            check_show_password.Location = new Point(95, 138);
            check_show_password.Name = "check_show_password";
            check_show_password.RightToLeft = RightToLeft.Yes;
            check_show_password.Size = new Size(157, 24);
            check_show_password.TabIndex = 6;
            check_show_password.Text = "?Показать пароль";
            check_show_password.UseVisualStyleBackColor = true;
            check_show_password.CheckedChanged += check_show_password_CheckedChanged;
            // 
            // button_auth
            // 
            button_auth.BackColor = Color.FromArgb(186, 255, 57);
            button_auth.FlatAppearance.BorderSize = 0;
            button_auth.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_auth.Location = new Point(14, 164);
            button_auth.Margin = new Padding(3, 4, 3, 4);
            button_auth.Name = "button_auth";
            button_auth.Size = new Size(237, 45);
            button_auth.TabIndex = 5;
            button_auth.Text = "Войти";
            button_auth.UseVisualStyleBackColor = false;
            button_auth.Click += button_auth_Click;
            // 
            // password_box
            // 
            password_box.Location = new Point(55, 111);
            password_box.Margin = new Padding(3, 4, 3, 4);
            password_box.Name = "password_box";
            password_box.Size = new Size(195, 27);
            password_box.TabIndex = 4;
            password_box.UseSystemPasswordChar = true;
            // 
            // pictureBox_password
            // 
            pictureBox_password.Image = Properties.Resources.password;
            pictureBox_password.Location = new Point(14, 111);
            pictureBox_password.Margin = new Padding(3, 4, 3, 4);
            pictureBox_password.Name = "pictureBox_password";
            pictureBox_password.Size = new Size(26, 31);
            pictureBox_password.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_password.TabIndex = 3;
            pictureBox_password.TabStop = false;
            // 
            // login_box
            // 
            login_box.Location = new Point(55, 72);
            login_box.Margin = new Padding(3, 4, 3, 4);
            login_box.Name = "login_box";
            login_box.Size = new Size(195, 27);
            login_box.TabIndex = 2;
            // 
            // pictureBox_login
            // 
            pictureBox_login.Image = Properties.Resources.login;
            pictureBox_login.Location = new Point(14, 72);
            pictureBox_login.Margin = new Padding(3, 4, 3, 4);
            pictureBox_login.Name = "pictureBox_login";
            pictureBox_login.Size = new Size(26, 31);
            pictureBox_login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_login.TabIndex = 1;
            pictureBox_login.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(auth);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 53);
            panel2.TabIndex = 0;
            // 
            // auth
            // 
            auth.Dock = DockStyle.Fill;
            auth.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            auth.ForeColor = Color.White;
            auth.Location = new Point(0, 0);
            auth.Name = "auth";
            auth.Size = new Size(263, 53);
            auth.TabIndex = 0;
            auth.Text = "Авторизация";
            auth.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 242);
            Controls.Add(fon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Тех. поддержка";
            fon.ResumeLayout(false);
            fon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel fon;
        private Panel panel2;
        private Label auth;
        private PictureBox pictureBox_login;
        private TextBox password_box;
        private PictureBox pictureBox_password;
        private TextBox login_box;
        private Button button_auth;
        private CheckBox check_show_password;
        private Label yet_register;
    }
}