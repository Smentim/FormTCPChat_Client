namespace FormTCPChat_Client
{
    partial class TehChat
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
            auth = new Label();
            fon = new Panel();
            listBox1 = new ListBox();
            send_mess_box = new TextBox();
            button_auth = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            fon.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // auth
            // 
            auth.Dock = DockStyle.Fill;
            auth.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            auth.ForeColor = Color.White;
            auth.Location = new Point(0, 0);
            auth.Name = "auth";
            auth.Size = new Size(800, 53);
            auth.TabIndex = 0;
            auth.Text = "Чат тех. поддержки";
            auth.TextAlign = ContentAlignment.TopCenter;
            // 
            // fon
            // 
            fon.BackColor = Color.FromArgb(110, 110, 110);
            fon.Controls.Add(listBox1);
            fon.Controls.Add(send_mess_box);
            fon.Controls.Add(button_auth);
            fon.Controls.Add(panel2);
            fon.Dock = DockStyle.Fill;
            fon.Location = new Point(0, 0);
            fon.Margin = new Padding(3, 4, 3, 4);
            fon.Name = "fon";
            fon.Size = new Size(800, 435);
            fon.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 324);
            listBox1.TabIndex = 8;
            // 
            // send_mess_box
            // 
            send_mess_box.Location = new Point(12, 401);
            send_mess_box.Name = "send_mess_box";
            send_mess_box.Size = new Size(533, 27);
            send_mess_box.TabIndex = 7;
            // 
            // button_auth
            // 
            button_auth.BackColor = Color.FromArgb(186, 255, 57);
            button_auth.FlatAppearance.BorderSize = 0;
            button_auth.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_auth.Location = new Point(551, 401);
            button_auth.Margin = new Padding(3, 4, 3, 4);
            button_auth.Name = "button_auth";
            button_auth.Size = new Size(237, 27);
            button_auth.TabIndex = 5;
            button_auth.Text = "Отправить";
            button_auth.UseVisualStyleBackColor = false;
            button_auth.Click += button_auth_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(auth);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 53);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 255, 57);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(136, 45);
            button1.TabIndex = 9;
            button1.Text = "Подключиться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(751, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TehChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 435);
            Controls.Add(fon);
            Name = "TehChat";
            Text = "TehChat";
            Load += TehChat_Load;
            fon.ResumeLayout(false);
            fon.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label auth;
        private Panel fon;
        private Button button_auth;
        private Panel panel2;
        private TextBox send_mess_box;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox1;
    }
}