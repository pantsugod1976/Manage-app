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
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btPreview = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
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
            this.lbSubject.Location = new System.Drawing.Point(210, 58);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(54, 13);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Học phần";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(30, 153);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 4;
            this.btGenerate.Text = "Tạo đề thi";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(825, 421);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(75, 23);
            this.tbCancel.TabIndex = 4;
            this.tbCancel.Text = "Thoát";
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
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
            this.cbSubject.Location = new System.Drawing.Point(213, 95);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject.TabIndex = 9;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(392, 58);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(508, 350);
            this.dgvList.TabIndex = 10;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(213, 153);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(75, 23);
            this.btPreview.TabIndex = 11;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(30, 255);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 12;
            this.lbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(30, 292);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(304, 20);
            this.tbSearch.TabIndex = 13;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // Test_Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 456);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTiltle);
            this.Name = "Test_Generate";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Test_Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button tbCancel;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}