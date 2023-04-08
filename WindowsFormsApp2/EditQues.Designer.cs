namespace WindowsFormsApp2
{
    partial class EditQues
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPoint = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.rbChoice = new System.Windows.Forms.RadioButton();
            this.rbEssay = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.gbGeneral.SuspendLayout();
            this.gbChoice.SuspendLayout();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.gbType);
            this.gbGeneral.Controls.Add(this.tbPoint);
            this.gbGeneral.Controls.Add(this.tbSubject);
            this.gbGeneral.Controls.Add(this.lbSubject);
            this.gbGeneral.Controls.Add(this.lbPoint);
            this.gbGeneral.Controls.Add(this.lbDescription);
            this.gbGeneral.Controls.Add(this.tbDescription);
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(584, 220);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Thông tin chung";
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
            this.gbChoice.Location = new System.Drawing.Point(12, 257);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(586, 131);
            this.gbChoice.TabIndex = 11;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Lựa chọn";
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
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(3, 23);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(50, 13);
            this.lbDescription.TabIndex = 14;
            this.lbDescription.Text = "Nội dung";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(101, 23);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(360, 47);
            this.tbDescription.TabIndex = 13;
            // 
            // tbPoint
            // 
            this.tbPoint.Location = new System.Drawing.Point(101, 150);
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(137, 20);
            this.tbPoint.TabIndex = 24;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(101, 94);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(137, 20);
            this.tbSubject.TabIndex = 22;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(6, 94);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(54, 13);
            this.lbSubject.TabIndex = 21;
            this.lbSubject.Text = "Học phần";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Location = new System.Drawing.Point(7, 150);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(31, 13);
            this.lbPoint.TabIndex = 23;
            this.lbPoint.Text = "Điểm";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(523, 417);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 17;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(389, 417);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 18;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // rbChoice
            // 
            this.rbChoice.AutoSize = true;
            this.rbChoice.Location = new System.Drawing.Point(6, 19);
            this.rbChoice.Name = "rbChoice";
            this.rbChoice.Size = new System.Drawing.Size(80, 17);
            this.rbChoice.TabIndex = 26;
            this.rbChoice.TabStop = true;
            this.rbChoice.Text = "trắc nghiệm";
            this.rbChoice.UseVisualStyleBackColor = true;
            // 
            // rbEssay
            // 
            this.rbEssay.AutoSize = true;
            this.rbEssay.Location = new System.Drawing.Point(6, 56);
            this.rbEssay.Name = "rbEssay";
            this.rbEssay.Size = new System.Drawing.Size(57, 17);
            this.rbEssay.TabIndex = 27;
            this.rbEssay.TabStop = true;
            this.rbEssay.Text = "tự luận";
            this.rbEssay.UseVisualStyleBackColor = true;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbChoice);
            this.gbType.Controls.Add(this.rbEssay);
            this.gbType.Location = new System.Drawing.Point(346, 94);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(115, 100);
            this.gbType.TabIndex = 28;
            this.gbType.TabStop = false;
            this.gbType.Text = "Kiểu câu hỏi";
            // 
            // EditQues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 452);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.gbChoice);
            this.Controls.Add(this.gbGeneral);
            this.Name = "EditQues";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditQues_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPoint;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.RadioButton rbEssay;
        private System.Windows.Forms.RadioButton rbChoice;
        private System.Windows.Forms.GroupBox gbType;
    }
}