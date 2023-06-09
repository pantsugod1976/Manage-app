﻿namespace WindowsFormsApp2
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
            this.btRestore = new System.Windows.Forms.Button();
            this.tbCancel = new System.Windows.Forms.Button();
            this.btBackup = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
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
            this.btControl.Location = new System.Drawing.Point(646, 88);
            this.btControl.Name = "btControl";
            this.btControl.Size = new System.Drawing.Size(104, 95);
            this.btControl.TabIndex = 1;
            this.btControl.Text = "Quản lí câu hỏi";
            this.btControl.UseVisualStyleBackColor = true;
            this.btControl.Click += new System.EventHandler(this.btControl_Click);
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
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(675, 189);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(113, 23);
            this.btRestore.TabIndex = 1;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
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
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(675, 218);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(113, 23);
            this.btBackup.TabIndex = 3;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(675, 248);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(113, 23);
            this.btQL.TabIndex = 4;
            this.btQL.Text = "Quản lí câu hỏi";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.btRestore);
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
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button tbCancel;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btQL;
    }
}

