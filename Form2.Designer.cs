namespace FinalPhoneBook
{
    partial class Form2
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
            label1 = new Label();
            full_name_txt = new TextBox();
            phone_no_txt = new TextBox();
            email_txt = new TextBox();
            address_txt = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            create_button = new Button();
            label6 = new Label();
            user_name_label2 = new Label();
            label7 = new Label();
            user_id_label = new Label();
            dataGridView1 = new DataGridView();
            update_btn = new Button();
            editbtn = new Button();
            cancel_btn = new Button();
            button1 = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 71, 87);
            label1.Location = new Point(288, 25);
            label1.Name = "label1";
            label1.Size = new Size(336, 62);
            label1.TabIndex = 0;
            label1.Text = "Phone Book";
            // 
            // full_name_txt
            // 
            full_name_txt.Location = new Point(288, 134);
            full_name_txt.Name = "full_name_txt";
            full_name_txt.Size = new Size(318, 27);
            full_name_txt.TabIndex = 1;
            // 
            // phone_no_txt
            // 
            phone_no_txt.Location = new Point(288, 167);
            phone_no_txt.Name = "phone_no_txt";
            phone_no_txt.Size = new Size(318, 27);
            phone_no_txt.TabIndex = 2;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(288, 200);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(318, 27);
            email_txt.TabIndex = 4;
            // 
            // address_txt
            // 
            address_txt.Location = new Point(288, 233);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(318, 120);
            address_txt.TabIndex = 6;
            address_txt.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(24, 71, 87);
            label3.Location = new Point(172, 167);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 8;
            label3.Text = "Phone No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(24, 71, 87);
            label4.Location = new Point(172, 200);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(24, 71, 87);
            label5.Location = new Point(172, 236);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(24, 71, 87);
            label2.Location = new Point(172, 134);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 11;
            label2.Text = "Full Name:";
            // 
            // create_button
            // 
            create_button.BackColor = Color.Teal;
            create_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create_button.ForeColor = Color.White;
            create_button.Location = new Point(676, 134);
            create_button.Name = "create_button";
            create_button.Size = new Size(110, 50);
            create_button.TabIndex = 12;
            create_button.Text = "Create";
            create_button.UseVisualStyleBackColor = false;
            create_button.Click += create_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(24, 71, 87);
            label6.Location = new Point(22, 25);
            label6.Name = "label6";
            label6.Size = new Size(113, 22);
            label6.TabIndex = 14;
            label6.Text = "User Name:";
            // 
            // user_name_label2
            // 
            user_name_label2.AutoSize = true;
            user_name_label2.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_name_label2.ForeColor = Color.White;
            user_name_label2.Location = new Point(133, 25);
            user_name_label2.Name = "user_name_label2";
            user_name_label2.Size = new Size(0, 22);
            user_name_label2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(24, 71, 87);
            label7.Location = new Point(769, 25);
            label7.Name = "label7";
            label7.Size = new Size(83, 22);
            label7.TabIndex = 16;
            label7.Text = "User Id:";
            // 
            // user_id_label
            // 
            user_id_label.AutoSize = true;
            user_id_label.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_id_label.ForeColor = Color.White;
            user_id_label.Location = new Point(858, 25);
            user_id_label.Name = "user_id_label";
            user_id_label.Size = new Size(0, 22);
            user_id_label.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 270);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Teal;
            update_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(676, 246);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(110, 50);
            update_btn.TabIndex = 19;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Teal;
            editbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editbtn.ForeColor = Color.White;
            editbtn.Location = new Point(676, 190);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(110, 50);
            editbtn.TabIndex = 20;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Teal;
            cancel_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_btn.ForeColor = Color.White;
            cancel_btn.Location = new Point(676, 303);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(110, 50);
            cancel_btn.TabIndex = 21;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(858, 61);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 22;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Teal;
            delete_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(149, 303);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(110, 50);
            delete_btn.TabIndex = 23;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1037, 706);
            Controls.Add(delete_btn);
            Controls.Add(button1);
            Controls.Add(cancel_btn);
            Controls.Add(editbtn);
            Controls.Add(update_btn);
            Controls.Add(dataGridView1);
            Controls.Add(user_id_label);
            Controls.Add(label7);
            Controls.Add(user_name_label2);
            Controls.Add(label6);
            Controls.Add(create_button);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(address_txt);
            Controls.Add(email_txt);
            Controls.Add(phone_no_txt);
            Controls.Add(full_name_txt);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Phone Book";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox full_name_txt;
        private TextBox phone_no_txt;
        private TextBox email_txt;
        private RichTextBox address_txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Button create_button;
        private Label label6;
        private Label user_name_label2;
        private Label label7;
        private Label user_id_label;
        private DataGridView dataGridView1;
        private Button update_btn;
        private Button editbtn;
        private Button cancel_btn;
        private Button button1;
        private Button delete_btn;
    }
}