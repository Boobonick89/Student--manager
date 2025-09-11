namespace Student__manager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtID = new TextBox();
            lstStudents = new ListBox();
            BtnAdd = new Button();
            BtnRemove = new Button();
            BtnSearchName = new Button();
            BtnSearchAge = new Button();
            BtnReset = new Button();
            label4 = new Label();
            label5 = new Label();
            txtSearchName = new TextBox();
            txtSearchAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Возраст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 115);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 23);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(181, 74);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(132, 23);
            txtAge.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(181, 115);
            txtID.Name = "txtID";
            txtID.Size = new Size(132, 23);
            txtID.TabIndex = 5;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(395, 32);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(330, 304);
            lstStudents.TabIndex = 6;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(27, 301);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(134, 23);
            BtnAdd.TabIndex = 7;
            BtnAdd.Text = "Добавить";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(24, 354);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(134, 23);
            BtnRemove.TabIndex = 8;
            BtnRemove.Text = "Удалить";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnSearchName
            // 
            BtnSearchName.Location = new Point(181, 301);
            BtnSearchName.Name = "BtnSearchName";
            BtnSearchName.Size = new Size(133, 23);
            BtnSearchName.TabIndex = 9;
            BtnSearchName.Text = "Поиск по имени";
            BtnSearchName.UseVisualStyleBackColor = true;
            BtnSearchName.Click += BtnSearchName_Click;
            // 
            // BtnSearchAge
            // 
            BtnSearchAge.Location = new Point(181, 354);
            BtnSearchAge.Name = "BtnSearchAge";
            BtnSearchAge.Size = new Size(130, 23);
            BtnSearchAge.TabIndex = 10;
            BtnSearchAge.Text = "Поиск по возрасту";
            BtnSearchAge.UseVisualStyleBackColor = true;
            BtnSearchAge.Click += BtnSearchAge_Click;
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(27, 395);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(126, 23);
            BtnReset.TabIndex = 11;
            BtnReset.Text = "Сброс";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 175);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 12;
            label4.Text = "Поиск по имени";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 223);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 13;
            label5.Text = "Поиск по возрасту";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(181, 172);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(132, 23);
            txtSearchName.TabIndex = 14;
            // 
            // txtSearchAge
            // 
            txtSearchAge.Location = new Point(178, 220);
            txtSearchAge.Name = "txtSearchAge";
            txtSearchAge.Size = new Size(133, 23);
            txtSearchAge.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchAge);
            Controls.Add(txtSearchName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnReset);
            Controls.Add(BtnSearchAge);
            Controls.Add(BtnSearchName);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAdd);
            Controls.Add(lstStudents);
            Controls.Add(txtID);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student - manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtID;
        private ListBox lstStudents;
        private Button BtnAdd;
        private Button BtnRemove;
        private Button BtnSearchName;
        private Button BtnSearchAge;
        private Button BtnReset;
        private Label label4;
        private Label label5;
        private TextBox txtSearchName;
        private TextBox txtSearchAge;
    }
}
