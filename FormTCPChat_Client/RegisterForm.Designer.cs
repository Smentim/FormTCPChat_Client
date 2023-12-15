namespace FormTCPChat_Client
{
    partial class RegisterForm
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
            reg = new Label();
            fon = new Panel();
            alr_register = new Label();
            label1 = new Label();
            num_pc_box = new TextBox();
            pass_retry_text = new Label();
            password_reg_retry_box = new TextBox();
            pass_text = new Label();
            log_text = new Label();
            check_show_password = new CheckBox();
            button_auth = new Button();
            password_reg_box = new TextBox();
            login_reg_box = new TextBox();
            panel2 = new Panel();
            fon.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // reg
            // 
            reg.Dock = DockStyle.Fill;
            reg.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            reg.ForeColor = Color.White;
            reg.Location = new Point(0, 0);
            reg.Name = "reg";
            reg.Size = new Size(262, 53);
            reg.TabIndex = 0;
            reg.Text = "Регистрация";
            reg.TextAlign = ContentAlignment.TopCenter;
            // 
            // fon
            // 
            fon.BackColor = Color.FromArgb(110, 110, 110);
            fon.Controls.Add(alr_register);
            fon.Controls.Add(label1);
            fon.Controls.Add(num_pc_box);
            fon.Controls.Add(pass_retry_text);
            fon.Controls.Add(password_reg_retry_box);
            fon.Controls.Add(pass_text);
            fon.Controls.Add(log_text);
            fon.Controls.Add(check_show_password);
            fon.Controls.Add(button_auth);
            fon.Controls.Add(password_reg_box);
            fon.Controls.Add(login_reg_box);
            fon.Controls.Add(panel2);
            fon.Dock = DockStyle.Fill;
            fon.Location = new Point(0, 0);
            fon.Margin = new Padding(3, 4, 3, 4);
            fon.Name = "fon";
            fon.Size = new Size(262, 387);
            fon.TabIndex = 1;
            // 
            // alr_register
            // 
            alr_register.AutoSize = true;
            alr_register.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            alr_register.ForeColor = Color.White;
            alr_register.Location = new Point(23, 355);
            alr_register.Name = "alr_register";
            alr_register.Size = new Size(221, 20);
            alr_register.TabIndex = 13;
            alr_register.Text = "Уже зарегистрированы?";
            alr_register.Click += alr_register_Click;
            alr_register.MouseLeave += alr_register_MouseLeave;
            alr_register.MouseHover += alr_register_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 106);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 12;
            label1.Text = "Номер компьютера";
            // 
            // num_pc_box
            // 
            num_pc_box.Location = new Point(13, 129);
            num_pc_box.Margin = new Padding(3, 4, 3, 4);
            num_pc_box.Name = "num_pc_box";
            num_pc_box.Size = new Size(238, 27);
            num_pc_box.TabIndex = 11;
            num_pc_box.Enter += num_pc_box_Enter;
            num_pc_box.Leave += num_pc_box_Leave;
            // 
            // pass_retry_text
            // 
            pass_retry_text.AutoSize = true;
            pass_retry_text.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pass_retry_text.ForeColor = Color.White;
            pass_retry_text.Location = new Point(9, 215);
            pass_retry_text.Name = "pass_retry_text";
            pass_retry_text.Size = new Size(191, 20);
            pass_retry_text.TabIndex = 10;
            pass_retry_text.Text = "Подтвердите пароль";
            // 
            // password_reg_retry_box
            // 
            password_reg_retry_box.Location = new Point(12, 240);
            password_reg_retry_box.Margin = new Padding(3, 4, 3, 4);
            password_reg_retry_box.Name = "password_reg_retry_box";
            password_reg_retry_box.Size = new Size(238, 27);
            password_reg_retry_box.TabIndex = 9;
            password_reg_retry_box.UseSystemPasswordChar = true;
            password_reg_retry_box.Enter += password_reg_retry_box_Enter;
            password_reg_retry_box.Leave += password_reg_retry_box_Leave;
            // 
            // pass_text
            // 
            pass_text.AutoSize = true;
            pass_text.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pass_text.ForeColor = Color.White;
            pass_text.Location = new Point(9, 158);
            pass_text.Name = "pass_text";
            pass_text.Size = new Size(74, 20);
            pass_text.TabIndex = 8;
            pass_text.Text = "Пароль";
            // 
            // log_text
            // 
            log_text.AutoSize = true;
            log_text.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            log_text.ForeColor = Color.White;
            log_text.Location = new Point(8, 55);
            log_text.Name = "log_text";
            log_text.Size = new Size(62, 20);
            log_text.TabIndex = 7;
            log_text.Text = "Логин";
            // 
            // check_show_password
            // 
            check_show_password.AutoSize = true;
            check_show_password.Location = new Point(94, 274);
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
            button_auth.Location = new Point(12, 301);
            button_auth.Margin = new Padding(3, 4, 3, 4);
            button_auth.Name = "button_auth";
            button_auth.Size = new Size(238, 45);
            button_auth.TabIndex = 5;
            button_auth.Text = "Зарегистрироваться";
            button_auth.UseVisualStyleBackColor = false;
            button_auth.Click += button_auth_Click;
            // 
            // password_reg_box
            // 
            password_reg_box.Location = new Point(12, 183);
            password_reg_box.Margin = new Padding(3, 4, 3, 4);
            password_reg_box.Name = "password_reg_box";
            password_reg_box.Size = new Size(238, 27);
            password_reg_box.TabIndex = 4;
            password_reg_box.UseSystemPasswordChar = true;
            password_reg_box.Enter += password_reg_box_Enter;
            password_reg_box.Leave += password_reg_box_Leave;
            // 
            // login_reg_box
            // 
            login_reg_box.Location = new Point(12, 78);
            login_reg_box.Margin = new Padding(3, 4, 3, 4);
            login_reg_box.Name = "login_reg_box";
            login_reg_box.Size = new Size(238, 27);
            login_reg_box.TabIndex = 2;
            login_reg_box.Enter += login_reg_box_Enter;
            login_reg_box.Leave += login_reg_box_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(reg);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 53);
            panel2.TabIndex = 0;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 387);
            Controls.Add(fon);
            Name = "RegisterForm";
            Text = "Тех. поддержка";
            fon.ResumeLayout(false);
            fon.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label reg;
        private Panel fon;
        private Label log_text;
        private CheckBox check_show_password;
        private Button button_auth;
        private TextBox password_reg_box;
        private TextBox login_reg_box;
        private Panel panel2;
        private Label pass_retry_text;
        private TextBox password_reg_retry_box;
        private Label pass_text;
        private Label label1;
        private TextBox num_pc_box;
        private Label alr_register;
    }
}