namespace FinalPhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            user_name_txt = new TextBox();
            password_txt = new TextBox();
            password_label = new Label();
            user_name_label = new Label();
            register_btn = new Button();
            login_btn = new Button();
            user_name_error_label = new Label();
            password_error_label = new Label();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(282, 58);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.Size = new Size(277, 27);
            user_name_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.Location = new Point(282, 128);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(277, 27);
            password_txt.TabIndex = 2;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_label.Location = new Point(130, 131);
            password_label.Name = "password_label";
            password_label.Size = new Size(100, 22);
            password_label.TabIndex = 5;
            password_label.Text = "Password:";
            // 
            // user_name_label
            // 
            user_name_label.AutoSize = true;
            user_name_label.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_name_label.Location = new Point(130, 61);
            user_name_label.Name = "user_name_label";
            user_name_label.Size = new Size(113, 22);
            user_name_label.TabIndex = 6;
            user_name_label.Text = "User Name:";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.Teal;
            register_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(449, 229);
            register_btn.Margin = new Padding(4);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(110, 50);
            register_btn.TabIndex = 7;
            register_btn.Text = "Sign Up";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Teal;
            login_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(282, 229);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(110, 50);
            login_btn.TabIndex = 8;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // user_name_error_label
            // 
            user_name_error_label.AutoSize = true;
            user_name_error_label.ForeColor = Color.Red;
            user_name_error_label.Location = new Point(282, 88);
            user_name_error_label.Name = "user_name_error_label";
            user_name_error_label.Size = new Size(0, 20);
            user_name_error_label.TabIndex = 9;
            // 
            // password_error_label
            // 
            password_error_label.AutoSize = true;
            password_error_label.ForeColor = Color.Red;
            password_error_label.Location = new Point(282, 158);
            password_error_label.Name = "password_error_label";
            password_error_label.Size = new Size(0, 20);
            password_error_label.TabIndex = 10;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.LightGray;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(648, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 437);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 71, 87);
            label1.Location = new Point(130, 392);
            label1.Name = "label1";
            label1.Size = new Size(433, 83);
            label1.TabIndex = 12;
            label1.Text = "Phone Book";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 594);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(password_error_label);
            Controls.Add(user_name_error_label);
            Controls.Add(login_btn);
            Controls.Add(register_btn);
            Controls.Add(user_name_label);
            Controls.Add(password_label);
            Controls.Add(password_txt);
            Controls.Add(user_name_txt);
            Name = "Form1";
            Text = "Login / Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user_name_txt;
        private TextBox password_txt;
        private Label password_label;
        private Label user_name_label;
        private Button register_btn;
        private Button login_btn;
        private Label user_name_error_label;
        private Label password_error_label;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
