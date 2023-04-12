namespace WindowsFormsApp2
{
    partial class ImportData
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
            this.lbTiltle = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbFile = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btRestore = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTiltle
            // 
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTiltle.Location = new System.Drawing.Point(12, 9);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTiltle.Size = new System.Drawing.Size(544, 40);
            this.lbTiltle.TabIndex = 0;
            this.lbTiltle.Text = "RESTORE DATA";
            this.lbTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTable
            // 
            this.lbTable.Location = new System.Drawing.Point(12, 92);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(100, 21);
            this.lbTable.TabIndex = 1;
            this.lbTable.Text = "Kiểu câu hỏi";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(131, 92);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(203, 21);
            this.cbType.TabIndex = 2;
            // 
            // lbFile
            // 
            this.lbFile.Location = new System.Drawing.Point(12, 164);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(100, 21);
            this.lbFile.TabIndex = 3;
            this.lbFile.Text = "FIle path";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(131, 164);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(290, 20);
            this.tbFile.TabIndex = 4;
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(131, 325);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(75, 23);
            this.btRestore.TabIndex = 5;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(368, 325);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Thoát";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(467, 164);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "Browser";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 382);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.lbTiltle);
            this.Name = "ImportData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ImportData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btFile;
    }
}