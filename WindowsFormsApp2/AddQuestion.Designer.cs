namespace WindowsFormsApp2
{
    partial class AddQuestion
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
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbEssay = new System.Windows.Forms.RadioButton();
            this.rbChoice = new System.Windows.Forms.RadioButton();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.gbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbEssay);
            this.gbType.Controls.Add(this.rbChoice);
            this.gbType.Location = new System.Drawing.Point(679, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(151, 131);
            this.gbType.TabIndex = 0;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            this.gbType.Enter += new System.EventHandler(this.gbType_Enter);
            // 
            // rbEssay
            // 
            this.rbEssay.AutoSize = true;
            this.rbEssay.Location = new System.Drawing.Point(6, 81);
            this.rbEssay.Name = "rbEssay";
            this.rbEssay.Size = new System.Drawing.Size(61, 17);
            this.rbEssay.TabIndex = 0;
            this.rbEssay.TabStop = true;
            this.rbEssay.Text = "Tự luận";
            this.rbEssay.UseVisualStyleBackColor = true;
            this.rbEssay.CheckedChanged += new System.EventHandler(this.rbEssay_CheckedChanged);
            // 
            // rbChoice
            // 
            this.rbChoice.AutoSize = true;
            this.rbChoice.Location = new System.Drawing.Point(6, 26);
            this.rbChoice.Name = "rbChoice";
            this.rbChoice.Size = new System.Drawing.Size(84, 17);
            this.rbChoice.TabIndex = 0;
            this.rbChoice.TabStop = true;
            this.rbChoice.Text = "Trắc nghiệm";
            this.rbChoice.UseVisualStyleBackColor = true;
            this.rbChoice.CheckedChanged += new System.EventHandler(this.rbChoice_CheckedChanged);
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.tbD);
            this.gbChoice.Controls.Add(this.tbB);
            this.gbChoice.Controls.Add(this.tbC);
            this.gbChoice.Controls.Add(this.tbA);
            this.gbChoice.Controls.Add(this.rbD);
            this.gbChoice.Controls.Add(this.rbC);
            this.gbChoice.Controls.Add(this.rbB);
            this.gbChoice.Controls.Add(this.rbA);
            this.gbChoice.Location = new System.Drawing.Point(12, 187);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(586, 131);
            this.gbChoice.TabIndex = 1;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "gbChoice";
            this.gbChoice.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(366, 85);
            this.tbD.Multiline = true;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(218, 34);
            this.tbD.TabIndex = 7;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(366, 28);
            this.tbB.Multiline = true;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(218, 34);
            this.tbB.TabIndex = 6;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(45, 84);
            this.tbC.Multiline = true;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(218, 34);
            this.tbC.TabIndex = 5;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(45, 28);
            this.tbA.Multiline = true;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(218, 34);
            this.tbA.TabIndex = 4;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(328, 85);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 17);
            this.rbD.TabIndex = 2;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(6, 85);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 3;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(328, 28);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(6, 28);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 37);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(586, 96);
            this.tbDescription.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(13, 12);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(50, 13);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Nội dung";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(676, 162);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(54, 13);
            this.lbSubject.TabIndex = 4;
            this.lbSubject.Text = "Học phần";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(679, 187);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(137, 45);
            this.tbSubject.TabIndex = 5;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(523, 387);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(741, 387);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.gbChoice);
            this.Controls.Add(this.gbType);
            this.Name = "AddQuestion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbEssay;
        private System.Windows.Forms.RadioButton rbChoice;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
    }
}