namespace DBGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dgName = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tb14 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.tb13 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.tb12 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.tb11 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tb10 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tb9 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tb8 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBuns = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.pbGenerator = new System.Windows.Forms.ProgressBar();
            this.udCount = new System.Windows.Forms.NumericUpDown();
            this.tb1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(3, 6);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(575, 156);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.Text = "SELECT* FROM Buns";
            // 
            // dgName
            // 
            this.dgName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgName.Location = new System.Drawing.Point(6, 197);
            this.dgName.Name = "dgName";
            this.dgName.RowTemplate.Height = 25;
            this.dgName.Size = new System.Drawing.Size(572, 213);
            this.dgName.TabIndex = 3;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(416, 168);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "выполнить запрос";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 510);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtQuery);
            this.tabPage1.Controls.Add(this.dgName);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "запросы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tb14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tb13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tb12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tb11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.labelBuns);
            this.tabPage2.Controls.Add(this.labelCount);
            this.tabPage2.Controls.Add(this.btnGo);
            this.tabPage2.Controls.Add(this.pbGenerator);
            this.tabPage2.Controls.Add(this.udCount);
            this.tabPage2.Controls.Add(this.tb1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ватрушка";
            // 
            // tb14
            // 
            this.tb14.Location = new System.Drawing.Point(297, 348);
            this.tb14.Name = "tb14";
            this.tb14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb14.Size = new System.Drawing.Size(156, 45);
            this.tb14.TabIndex = 31;
            this.tb14.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(460, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Пампушка";
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(297, 297);
            this.tb13.Name = "tb13";
            this.tb13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb13.Size = new System.Drawing.Size(156, 45);
            this.tb13.TabIndex = 29;
            this.tb13.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Сдоба выборгская";
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(297, 246);
            this.tb12.Name = "tb12";
            this.tb12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb12.Size = new System.Drawing.Size(156, 45);
            this.tb12.TabIndex = 27;
            this.tb12.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Рулет";
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(297, 195);
            this.tb11.Name = "tb11";
            this.tb11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb11.Size = new System.Drawing.Size(156, 45);
            this.tb11.TabIndex = 25;
            this.tb11.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Бриошь";
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(297, 144);
            this.tb10.Name = "tb10";
            this.tb10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb10.Size = new System.Drawing.Size(156, 45);
            this.tb10.TabIndex = 23;
            this.tb10.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "С посыпкой";
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(297, 93);
            this.tb9.Name = "tb9";
            this.tb9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb9.Size = new System.Drawing.Size(156, 45);
            this.tb9.TabIndex = 21;
            this.tb9.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Слойка";
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(297, 42);
            this.tb8.Name = "tb8";
            this.tb8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb8.Size = new System.Drawing.Size(156, 45);
            this.tb8.TabIndex = 19;
            this.tb8.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Сайка";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(7, 348);
            this.tb7.Name = "tb7";
            this.tb7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb7.Size = new System.Drawing.Size(156, 45);
            this.tb7.TabIndex = 17;
            this.tb7.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Крендель";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(7, 297);
            this.tb6.Name = "tb6";
            this.tb6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb6.Size = new System.Drawing.Size(156, 45);
            this.tb6.TabIndex = 15;
            this.tb6.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Калачик";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(7, 246);
            this.tb5.Name = "tb5";
            this.tb5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb5.Size = new System.Drawing.Size(156, 45);
            this.tb5.TabIndex = 13;
            this.tb5.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рогалик";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(7, 195);
            this.tb4.Name = "tb4";
            this.tb4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb4.Size = new System.Drawing.Size(156, 45);
            this.tb4.TabIndex = 11;
            this.tb4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Круассан";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(7, 144);
            this.tb3.Name = "tb3";
            this.tb3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb3.Size = new System.Drawing.Size(156, 45);
            this.tb3.TabIndex = 9;
            this.tb3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Плюшка";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(7, 93);
            this.tb2.Name = "tb2";
            this.tb2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb2.Size = new System.Drawing.Size(156, 45);
            this.tb2.TabIndex = 7;
            this.tb2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Бублик";
            // 
            // labelBuns
            // 
            this.labelBuns.AutoSize = true;
            this.labelBuns.Location = new System.Drawing.Point(26, 14);
            this.labelBuns.Name = "labelBuns";
            this.labelBuns.Size = new System.Drawing.Size(85, 15);
            this.labelBuns.TabIndex = 5;
            this.labelBuns.Text = "Виды булочек";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 406);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(79, 15);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Колличество";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(503, 453);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "запустить";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pbGenerator
            // 
            this.pbGenerator.Location = new System.Drawing.Point(6, 453);
            this.pbGenerator.Name = "pbGenerator";
            this.pbGenerator.Size = new System.Drawing.Size(491, 23);
            this.pbGenerator.TabIndex = 2;
            // 
            // udCount
            // 
            this.udCount.Location = new System.Drawing.Point(6, 424);
            this.udCount.Name = "udCount";
            this.udCount.Size = new System.Drawing.Size(120, 23);
            this.udCount.TabIndex = 1;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(7, 42);
            this.tb1.Name = "tb1";
            this.tb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb1.Size = new System.Drawing.Size(156, 45);
            this.tb1.TabIndex = 0;
            this.tb1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtQuery;
        private DataGridView dgName;
        private Button btnExecute;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label14;
        private TrackBar tb14;
        private Label label13;
        private TrackBar tb13;
        private Label label12;
        private TrackBar tb12;
        private Label label11;
        private TrackBar tb11;
        private Label label10;
        private TrackBar tb10;
        private Label label9;
        private TrackBar tb9;
        private Label label8;
        private TrackBar tb8;
        private Label label7;
        private TrackBar tb7;
        private Label label6;
        private TrackBar tb6;
        private Label label5;
        private TrackBar tb5;
        private Label label4;
        private TrackBar tb4;
        private Label label3;
        private TrackBar tb3;
        private Label label2;
        private TrackBar tb2;
        private Label label1;
        private Label labelBuns;
        private Label labelCount;
        private Button btnGo;
        private ProgressBar pbGenerator;
        private NumericUpDown udCount;
        private TrackBar tb1;
    }
}