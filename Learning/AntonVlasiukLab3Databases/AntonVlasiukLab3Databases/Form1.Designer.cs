namespace AntonVlasiukLab3Databases
{
    partial class Form1
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
            this.dataGridViewZoo = new System.Windows.Forms.DataGridView();
            this.buttonShowAllAnimals = new System.Windows.Forms.Button();
            this.ShowAllSloths = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZoo
            // 
            this.dataGridViewZoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoo.Location = new System.Drawing.Point(285, 34);
            this.dataGridViewZoo.Name = "dataGridViewZoo";
            this.dataGridViewZoo.RowTemplate.Height = 24;
            this.dataGridViewZoo.Size = new System.Drawing.Size(467, 304);
            this.dataGridViewZoo.TabIndex = 0;
            // 
            // buttonShowAllAnimals
            // 
            this.buttonShowAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllAnimals.Location = new System.Drawing.Point(285, 365);
            this.buttonShowAllAnimals.Name = "buttonShowAllAnimals";
            this.buttonShowAllAnimals.Size = new System.Drawing.Size(175, 80);
            this.buttonShowAllAnimals.TabIndex = 1;
            this.buttonShowAllAnimals.Text = "Show all animals";
            this.buttonShowAllAnimals.UseVisualStyleBackColor = true;
            this.buttonShowAllAnimals.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowAllSloths
            // 
            this.ShowAllSloths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllSloths.Location = new System.Drawing.Point(577, 365);
            this.ShowAllSloths.Name = "ShowAllSloths";
            this.ShowAllSloths.Size = new System.Drawing.Size(175, 80);
            this.ShowAllSloths.TabIndex = 2;
            this.ShowAllSloths.Text = "Show all animals";
            this.ShowAllSloths.UseVisualStyleBackColor = true;
            this.ShowAllSloths.Click += new System.EventHandler(this.ShowAllSloths_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(857, 242);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(129, 23);
            this.buttonAddAnimal.TabIndex = 3;
            this.buttonAddAnimal.Text = "Add animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(832, 137);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(832, 189);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(180, 22);
            this.textBoxAmount.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 498);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.ShowAllSloths);
            this.Controls.Add(this.buttonShowAllAnimals);
            this.Controls.Add(this.dataGridViewZoo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZoo;
        private System.Windows.Forms.Button buttonShowAllAnimals;
        private System.Windows.Forms.Button ShowAllSloths;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}

