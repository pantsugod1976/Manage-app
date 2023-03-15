namespace WindowsFormsApp2
{
    partial class Test_Generate
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
            this.boxAmount = new System.Windows.Forms.GroupBox();
            this.numberEssay = new System.Windows.Forms.NumericUpDown();
            this.numberChoice = new System.Windows.Forms.NumericUpDown();
            this.lbEssay = new System.Windows.Forms.Label();
            this.lbChoice = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbCancel = new System.Windows.Forms.Button();
            this.boxAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberEssay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTiltle
            // 
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiltle.Location = new System.Drawing.Point(12, 9);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.Size = new System.Drawing.Size(776, 46);
            this.lbTiltle.TabIndex = 0;
            this.lbTiltle.Text = "Tạo đề thi";
            this.lbTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxAmount
            // 
            this.boxAmount.Controls.Add(this.numberEssay);
            this.boxAmount.Controls.Add(this.numberChoice);
            this.boxAmount.Controls.Add(this.lbEssay);
            this.boxAmount.Controls.Add(this.lbChoice);
            this.boxAmount.Location = new System.Drawing.Point(17, 58);
            this.boxAmount.Name = "boxAmount";
            this.boxAmount.Size = new System.Drawing.Size(232, 100);
            this.boxAmount.TabIndex = 1;
            this.boxAmount.TabStop = false;
            this.boxAmount.Text = "Số lượng câu hỏi";
            // 
            // numberEssay
            // 
            this.numberEssay.Location = new System.Drawing.Point(80, 64);
            this.numberEssay.Name = "numberEssay";
            this.numberEssay.Size = new System.Drawing.Size(120, 20);
            this.numberEssay.TabIndex = 1;
            // 
            // numberChoice
            // 
            this.numberChoice.Location = new System.Drawing.Point(80, 18);
            this.numberChoice.Name = "numberChoice";
            this.numberChoice.Size = new System.Drawing.Size(120, 20);
            this.numberChoice.TabIndex = 1;
            // 
            // lbEssay
            // 
            this.lbEssay.AutoSize = true;
            this.lbEssay.Location = new System.Drawing.Point(7, 64);
            this.lbEssay.Name = "lbEssay";
            this.lbEssay.Size = new System.Drawing.Size(43, 13);
            this.lbEssay.TabIndex = 0;
            this.lbEssay.Text = "Tự luận";
            // 
            // lbChoice
            // 
            this.lbChoice.AutoSize = true;
            this.lbChoice.Location = new System.Drawing.Point(7, 20);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(66, 13);
            this.lbChoice.TabIndex = 0;
            this.lbChoice.Text = "Trắc nghiệm";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(375, 95);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(296, 20);
            this.tbSubject.TabIndex = 2;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(372, 58);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(54, 13);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Học phần";
            this.lbSubject.Click += new System.EventHandler(this.lb_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(69, 365);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 4;
            this.btGenerate.Text = "Tạo đề thi";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(557, 365);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(75, 23);
            this.tbCancel.TabIndex = 4;
            this.tbCancel.Text = "Thoát";
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // Test_Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.boxAmount);
            this.Controls.Add(this.lbTiltle);
            this.Name = "Test_Generate";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Test_Generate_Load);
            this.boxAmount.ResumeLayout(false);
            this.boxAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberEssay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.GroupBox boxAmount;
        private System.Windows.Forms.NumericUpDown numberEssay;
        private System.Windows.Forms.NumericUpDown numberChoice;
        private System.Windows.Forms.Label lbEssay;
        private System.Windows.Forms.Label lbChoice;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button tbCancel;
    }
}