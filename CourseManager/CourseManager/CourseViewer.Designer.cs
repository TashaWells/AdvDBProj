namespace CourseManager
{
    partial class CourseViewer
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
            this.DepartmentList = new System.Windows.Forms.ComboBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentList
            // 
            this.DepartmentList.FormattingEnabled = true;
            this.DepartmentList.Location = new System.Drawing.Point(26, 27);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(502, 39);
            this.DepartmentList.TabIndex = 0;
            this.DepartmentList.SelectedIndexChanged += new System.EventHandler(this.DepartmentList_SelectedIndexChanged);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(782, 19);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(153, 53);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "Close";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(26, 148);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.RowTemplate.Height = 40;
            this.courseGridView.Size = new System.Drawing.Size(920, 639);
            this.courseGridView.TabIndex = 2;
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 850);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.DepartmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartmentList;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.DataGridView courseGridView;
    }
}

