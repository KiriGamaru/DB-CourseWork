namespace DBGenerator
{
    partial class Regular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regular));
            this.panelUp = new System.Windows.Forms.Panel();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.pbErase = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSeller = new System.Windows.Forms.TextBox();
            this.tbBun = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSeller = new System.Windows.Forms.Label();
            this.labelBun = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelUp.Controls.Add(this.pbUpdate);
            this.panelUp.Controls.Add(this.pbErase);
            this.panelUp.Controls.Add(this.textBoxSearch);
            this.panelUp.Controls.Add(this.pbSearch);
            this.panelUp.Controls.Add(this.label1);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(800, 67);
            this.panelUp.TabIndex = 0;
            // 
            // pbUpdate
            // 
            this.pbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdate.Image")));
            this.pbUpdate.Location = new System.Drawing.Point(535, 12);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(42, 40);
            this.pbUpdate.TabIndex = 4;
            this.pbUpdate.TabStop = false;
            // 
            // pbErase
            // 
            this.pbErase.Image = ((System.Drawing.Image)(resources.GetObject("pbErase.Image")));
            this.pbErase.Location = new System.Drawing.Point(487, 12);
            this.pbErase.Name = "pbErase";
            this.pbErase.Size = new System.Drawing.Size(42, 40);
            this.pbErase.TabIndex = 3;
            this.pbErase.TabStop = false;
            this.pbErase.Click += new System.EventHandler(this.pbErase_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(631, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(138, 29);
            this.textBoxSearch.TabIndex = 2;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(583, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(42, 40);
            this.pbSearch.TabIndex = 1;
            this.pbSearch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продажи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(535, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Управление записями";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbSeller);
            this.panel1.Controls.Add(this.tbBun);
            this.panel1.Controls.Add(this.tbDate);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelSeller);
            this.panel1.Controls.Add(this.labelBun);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Location = new System.Drawing.Point(42, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 204);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbSeller
            // 
            this.tbSeller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSeller.Location = new System.Drawing.Point(179, 151);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(152, 29);
            this.tbSeller.TabIndex = 8;
            // 
            // tbBun
            // 
            this.tbBun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBun.Location = new System.Drawing.Point(179, 116);
            this.tbBun.Name = "tbBun";
            this.tbBun.Size = new System.Drawing.Size(152, 29);
            this.tbBun.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDate.Location = new System.Drawing.Point(179, 81);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(152, 29);
            this.tbDate.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(179, 46);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(152, 29);
            this.tbID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Запись:";
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeller.Location = new System.Drawing.Point(41, 151);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(132, 21);
            this.labelSeller.TabIndex = 4;
            this.labelSeller.Text = "Номер продавца";
            // 
            // labelBun
            // 
            this.labelBun.AutoSize = true;
            this.labelBun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBun.Location = new System.Drawing.Point(51, 119);
            this.labelBun.Name = "labelBun";
            this.labelBun.Size = new System.Drawing.Size(122, 21);
            this.labelBun.TabIndex = 3;
            this.labelBun.Text = "Номер булочки";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(129, 84);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 21);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(148, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 21);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonNew);
            this.panel2.Location = new System.Drawing.Point(535, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 204);
            this.panel2.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(34, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 41);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(34, 103);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 41);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(34, 56);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 41);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(34, 9);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(117, 41);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "новая запись";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // Regular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUp);
            this.Name = "Regular";
            this.Text = "Regular";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelUp;
        private Label label1;
        private PictureBox pbUpdate;
        private PictureBox pbErase;
        private TextBox textBoxSearch;
        private PictureBox pbSearch;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel1;
        private TextBox tbSeller;
        private TextBox tbBun;
        private TextBox tbDate;
        private TextBox tbID;
        private Label labelSeller;
        private Label labelBun;
        private Label labelDate;
        private Label labelID;
        private Label label3;
        private Panel panel2;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonNew;
        private PictureBox pictureBox1;
    }
}