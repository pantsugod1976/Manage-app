namespace WindowsFormsApp2
{
    partial class HomePage
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
            this.btControl = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.btQuest = new System.Windows.Forms.Button();
            this.btRestore = new System.Windows.Forms.Button();
            this.tbCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTiltle
            // 
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiltle.Location = new System.Drawing.Point(12, 9);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.Size = new System.Drawing.Size(776, 51);
            this.lbTiltle.TabIndex = 0;
            this.lbTiltle.Text = "Quản lí ngân hàng câu hỏi";
            this.lbTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btControl
            // 
            this.btControl.Location = new System.Drawing.Point(675, 88);
            this.btControl.Name = "btControl";
            this.btControl.Size = new System.Drawing.Size(104, 95);
            this.btControl.TabIndex = 1;
            this.btControl.Text = "Quản lí câu hỏi";
            this.btControl.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(364, 88);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(104, 95);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Cập nhật câu hỏi";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(60, 88);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(104, 95);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "Tạo đề thi";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(393, 189);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.TabIndex = 1;
            this.btFile.Text = "Cập nhật từ File";
            this.btFile.UseVisualStyleBackColor = true;
            // 
            // btQuest
            // 
            this.btQuest.Location = new System.Drawing.Point(393, 218);
            this.btQuest.Name = "btQuest";
            this.btQuest.Size = new System.Drawing.Size(75, 23);
            this.btQuest.TabIndex = 1;
            this.btQuest.Text = "Cập nhật từng câu";
            this.btQuest.UseVisualStyleBackColor = true;
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(393, 247);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(75, 23);
            this.btRestore.TabIndex = 1;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(675, 391);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(75, 23);
            this.tbCancel.TabIndex = 2;
            this.tbCancel.Text = "Thoát";
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btQuest);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btControl);
            this.Controls.Add(this.lbTiltle);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.Button btControl;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btQuest;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button tbCancel;
    }
}

