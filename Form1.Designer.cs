namespace StudentAttendanceChecker
{
    partial class Form1
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.Label();
            this.fullnamebox = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.Label();
            this.sectionbox = new System.Windows.Forms.TextBox();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(800, 255);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.Tag = "dgvStudents";
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick_1);
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FullName.Location = new System.Drawing.Point(227, 273);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(80, 20);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name";
            // 
            // fullnamebox
            // 
            this.fullnamebox.Location = new System.Drawing.Point(338, 273);
            this.fullnamebox.Name = "fullnamebox";
            this.fullnamebox.Size = new System.Drawing.Size(179, 20);
            this.fullnamebox.TabIndex = 2;
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.section.Location = new System.Drawing.Point(227, 311);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(63, 20);
            this.section.TabIndex = 3;
            this.section.Text = "Section";
            // 
            // sectionbox
            // 
            this.sectionbox.Location = new System.Drawing.Point(338, 311);
            this.sectionbox.Name = "sectionbox";
            this.sectionbox.Size = new System.Drawing.Size(179, 20);
            this.sectionbox.TabIndex = 4;
            // 
            // statusbox
            // 
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Present",
            "Late",
            "Absent"});
            this.statusbox.Location = new System.Drawing.Point(363, 351);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(127, 21);
            this.statusbox.TabIndex = 6;
            this.statusbox.Text = "Status";
            this.statusbox.SelectedIndexChanged += new System.EventHandler(this.statusbox_SelectedIndexChanged);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.addbutton.Location = new System.Drawing.Point(388, 396);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.Lime;
            this.editbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.editbutton.Location = new System.Drawing.Point(609, 270);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(56, 23);
            this.editbutton.TabIndex = 8;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.Color.Red;
            this.removebutton.ForeColor = System.Drawing.SystemColors.Window;
            this.removebutton.Location = new System.Drawing.Point(671, 270);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(56, 23);
            this.removebutton.TabIndex = 9;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.clearbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearbutton.Location = new System.Drawing.Point(733, 270);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(56, 23);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.sectionbox);
            this.Controls.Add(this.section);
            this.Controls.Add(this.fullnamebox);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.TextBox fullnamebox;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.TextBox sectionbox;
        private System.Windows.Forms.ComboBox statusbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

