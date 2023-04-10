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
            this.lbSubject = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbCancel = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTiltle
            // 
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiltle.Location = new System.Drawing.Point(11, 9);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.Size = new System.Drawing.Size(776, 46);
            this.lbTiltle.TabIndex = 0;
            this.lbTiltle.Text = "Tạo đề thi";
            this.lbTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btGenerate.Location = new System.Drawing.Point(30, 257);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 4;
            this.btGenerate.Text = "Tạo đề thi";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(490, 257);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(75, 23);
            this.tbCancel.TabIndex = 4;
            this.tbCancel.Text = "Thoát";
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(372, 151);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(70, 13);
            this.lbAmount.TabIndex = 5;
            this.lbAmount.Text = "Số lượng câu";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(375, 188);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(190, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(27, 58);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(66, 13);
            this.lbType.TabIndex = 7;
            this.lbType.Text = "Kiểu câu hỏi";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(30, 95);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 8;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(375, 95);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject.TabIndex = 9;
            // 
            // Test_Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 347);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTiltle);
            this.Name = "Test_Generate";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Test_Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button tbCancel;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}