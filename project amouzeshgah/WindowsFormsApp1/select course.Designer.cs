
namespace WindowsFormsApp1
{
    partial class select_course
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
            this.Course = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(393, 57);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(323, 251);
            this.Course.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "select course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Course);
            this.Name = "select_course";
            this.Text = "select_course";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Course;
        private System.Windows.Forms.Button button1;
    }
}