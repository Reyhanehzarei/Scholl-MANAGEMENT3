
namespace WindowsFormsApp1
{
    partial class select_grade
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
            this.Grade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grade
            // 
            this.Grade.FormattingEnabled = true;
            this.Grade.Location = new System.Drawing.Point(395, 64);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(195, 134);
            this.Grade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "student id";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(179, 80);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(100, 20);
            this.studentID.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "select grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grade);
            this.Name = "select_grade";
            this.Text = "select_grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Button button1;
    }
}