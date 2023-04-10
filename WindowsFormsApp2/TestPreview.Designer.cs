namespace WindowsFormsApp2
{
    partial class TestPreview
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lbList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 72);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(776, 278);
            this.dgvList.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Location = new System.Drawing.Point(13, 39);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(97, 13);
            this.lbList.TabIndex = 1;
            this.lbList.Text = "Danh sách câu hỏi";
            // 
            // TestPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.dgvList);
            this.Name = "TestPreview";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TestPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lbList;
    }
}