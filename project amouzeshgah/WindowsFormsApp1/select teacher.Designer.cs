
namespace WindowsFormsApp1
{
    partial class select_teacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter teacher id";
            // 
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(157, 58);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(100, 20);
            this.teacherID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "select teacher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teacher
            // 
            this.Teacher.FormattingEnabled = true;
            this.Teacher.Location = new System.Drawing.Point(358, 42);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(187, 147);
            this.Teacher.TabIndex = 3;
            // 
            // select_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.label1);
            this.Name = "select_teacher";
            this.Text = "select_teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Teacher;
    }
}