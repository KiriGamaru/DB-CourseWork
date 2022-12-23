namespace DBGenerator
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbErase = new System.Windows.Forms.PictureBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbSecretIngredient = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbErase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер секретного ингредиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(194, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер";
            // 
            // pbErase
            // 
            this.pbErase.Image = ((System.Drawing.Image)(resources.GetObject("pbErase.Image")));
            this.pbErase.Location = new System.Drawing.Point(399, 17);
            this.pbErase.Name = "pbErase";
            this.pbErase.Size = new System.Drawing.Size(42, 40);
            this.pbErase.TabIndex = 5;
            this.pbErase.TabStop = false;
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSize.Location = new System.Drawing.Point(262, 138);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(179, 29);
            this.tbSize.TabIndex = 11;
            // 
            // tbSecretIngredient
            // 
            this.tbSecretIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSecretIngredient.Location = new System.Drawing.Point(262, 103);
            this.tbSecretIngredient.Name = "tbSecretIngredient";
            this.tbSecretIngredient.Size = new System.Drawing.Size(179, 29);
            this.tbSecretIngredient.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(262, 68);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 29);
            this.tbName.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(33, 178);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(408, 39);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 230);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbSecretIngredient);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbErase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbErase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pbErase;
        private TextBox tbSize;
        private TextBox tbSecretIngredient;
        private TextBox tbName;
        private Button buttonSave;
    }
}