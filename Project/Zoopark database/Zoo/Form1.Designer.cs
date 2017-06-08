namespace Zoo
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
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonSloths = new System.Windows.Forms.Button();
            this.textBoxZookeeperName = new System.Windows.Forms.TextBox();
            this.textBoxZookeeperSurname = new System.Windows.Forms.TextBox();
            this.buttonAddZookeeper = new System.Windows.Forms.Button();
            this.buttonShowAllZookeepers = new System.Windows.Forms.Button();
            this.textBoxFindSloths = new System.Windows.Forms.TextBox();
            this.textBoxAgeLeft = new System.Windows.Forms.TextBox();
            this.textBoxAgeRight = new System.Windows.Forms.TextBox();
            this.labelBetween = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonFindAge = new System.Windows.Forms.Button();
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.buttonMoreAnimal = new System.Windows.Forms.Button();
            this.labelSlothsName = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelKeeperName = new System.Windows.Forms.Label();
            this.labelKeeperSurname = new System.Windows.Forms.Label();
            this.textBoxNimberOfNewAnimals = new System.Windows.Forms.TextBox();
            this.labelNumberOfNewAnimals = new System.Windows.Forms.Label();
            this.buttonDeleteZookeeper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZoo
            // 
            this.dataGridViewZoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoo.Location = new System.Drawing.Point(33, 15);
            this.dataGridViewZoo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewZoo.Name = "dataGridViewZoo";
            this.dataGridViewZoo.Size = new System.Drawing.Size(869, 250);
            this.dataGridViewZoo.TabIndex = 0;
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Location = new System.Drawing.Point(727, 294);
            this.buttonAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(176, 49);
            this.buttonAnimals.TabIndex = 1;
            this.buttonAnimals.Text = "Zwierzątka";
            this.buttonAnimals.UseVisualStyleBackColor = true;
            this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
            // 
            // buttonSloths
            // 
            this.buttonSloths.Location = new System.Drawing.Point(727, 366);
            this.buttonSloths.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSloths.Name = "buttonSloths";
            this.buttonSloths.Size = new System.Drawing.Size(176, 49);
            this.buttonSloths.TabIndex = 2;
            this.buttonSloths.Text = "Leniwce";
            this.buttonSloths.UseVisualStyleBackColor = true;
            this.buttonSloths.Click += new System.EventHandler(this.buttonSloths_Click);
            // 
            // textBoxZookeeperName
            // 
            this.textBoxZookeeperName.Location = new System.Drawing.Point(513, 294);
            this.textBoxZookeeperName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZookeeperName.Name = "textBoxZookeeperName";
            this.textBoxZookeeperName.Size = new System.Drawing.Size(132, 22);
            this.textBoxZookeeperName.TabIndex = 3;
            // 
            // textBoxZookeeperSurname
            // 
            this.textBoxZookeeperSurname.Location = new System.Drawing.Point(513, 326);
            this.textBoxZookeeperSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZookeeperSurname.Name = "textBoxZookeeperSurname";
            this.textBoxZookeeperSurname.Size = new System.Drawing.Size(132, 22);
            this.textBoxZookeeperSurname.TabIndex = 4;
            // 
            // buttonAddZookeeper
            // 
            this.buttonAddZookeeper.Location = new System.Drawing.Point(471, 361);
            this.buttonAddZookeeper.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddZookeeper.Name = "buttonAddZookeeper";
            this.buttonAddZookeeper.Size = new System.Drawing.Size(176, 49);
            this.buttonAddZookeeper.TabIndex = 5;
            this.buttonAddZookeeper.Text = "Dodaj Opiekuna";
            this.buttonAddZookeeper.UseVisualStyleBackColor = true;
            this.buttonAddZookeeper.Click += new System.EventHandler(this.buttonAddZookeeper_Click);
            // 
            // buttonShowAllZookeepers
            // 
            this.buttonShowAllZookeepers.Location = new System.Drawing.Point(727, 436);
            this.buttonShowAllZookeepers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAllZookeepers.Name = "buttonShowAllZookeepers";
            this.buttonShowAllZookeepers.Size = new System.Drawing.Size(176, 49);
            this.buttonShowAllZookeepers.TabIndex = 6;
            this.buttonShowAllZookeepers.Text = "Opiekunowie";
            this.buttonShowAllZookeepers.UseVisualStyleBackColor = true;
            this.buttonShowAllZookeepers.Click += new System.EventHandler(this.buttonShowAllZookeepers_Click);
            // 
            // textBoxFindSloths
            // 
            this.textBoxFindSloths.Location = new System.Drawing.Point(63, 294);
            this.textBoxFindSloths.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFindSloths.Name = "textBoxFindSloths";
            this.textBoxFindSloths.Size = new System.Drawing.Size(132, 22);
            this.textBoxFindSloths.TabIndex = 7;
            this.textBoxFindSloths.TextChanged += new System.EventHandler(this.textBoxFindSloths_TextChanged);
            // 
            // textBoxAgeLeft
            // 
            this.textBoxAgeLeft.Location = new System.Drawing.Point(45, 379);
            this.textBoxAgeLeft.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAgeLeft.Name = "textBoxAgeLeft";
            this.textBoxAgeLeft.Size = new System.Drawing.Size(41, 22);
            this.textBoxAgeLeft.TabIndex = 9;
            // 
            // textBoxAgeRight
            // 
            this.textBoxAgeRight.Location = new System.Drawing.Point(117, 379);
            this.textBoxAgeRight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAgeRight.Name = "textBoxAgeRight";
            this.textBoxAgeRight.Size = new System.Drawing.Size(41, 22);
            this.textBoxAgeRight.TabIndex = 10;
            // 
            // labelBetween
            // 
            this.labelBetween.AutoSize = true;
            this.labelBetween.Location = new System.Drawing.Point(96, 383);
            this.labelBetween.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBetween.Name = "labelBetween";
            this.labelBetween.Size = new System.Drawing.Size(12, 17);
            this.labelBetween.TabIndex = 11;
            this.labelBetween.Text = ":";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(80, 350);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 17);
            this.labelAge.TabIndex = 12;
            this.labelAge.Text = "WIEK";
            // 
            // buttonFindAge
            // 
            this.buttonFindAge.Location = new System.Drawing.Point(208, 354);
            this.buttonFindAge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindAge.Name = "buttonFindAge";
            this.buttonFindAge.Size = new System.Drawing.Size(176, 49);
            this.buttonFindAge.TabIndex = 13;
            this.buttonFindAge.Text = "Daj leniwca";
            this.buttonFindAge.UseVisualStyleBackColor = true;
            this.buttonFindAge.Click += new System.EventHandler(this.buttonFindAge_Click);
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Location = new System.Drawing.Point(35, 459);
            this.comboBoxSpecies.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSpecies.TabIndex = 14;
            // 
            // buttonMoreAnimal
            // 
            this.buttonMoreAnimal.Location = new System.Drawing.Point(208, 459);
            this.buttonMoreAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoreAnimal.Name = "buttonMoreAnimal";
            this.buttonMoreAnimal.Size = new System.Drawing.Size(176, 57);
            this.buttonMoreAnimal.TabIndex = 16;
            this.buttonMoreAnimal.Text = "Dodaj więcej zwierzad";
            this.buttonMoreAnimal.UseVisualStyleBackColor = true;
            this.buttonMoreAnimal.Click += new System.EventHandler(this.buttonOneMoreAnimal_Click);
            // 
            // labelSlothsName
            // 
            this.labelSlothsName.AutoSize = true;
            this.labelSlothsName.Location = new System.Drawing.Point(16, 294);
            this.labelSlothsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSlothsName.Name = "labelSlothsName";
            this.labelSlothsName.Size = new System.Drawing.Size(37, 17);
            this.labelSlothsName.TabIndex = 17;
            this.labelSlothsName.Text = "Imię:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(40, 428);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(66, 17);
            this.labelSpecies.TabIndex = 18;
            this.labelSpecies.Text = "Gatunek:";
            // 
            // labelKeeperName
            // 
            this.labelKeeperName.AutoSize = true;
            this.labelKeeperName.Location = new System.Drawing.Point(431, 294);
            this.labelKeeperName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeeperName.Name = "labelKeeperName";
            this.labelKeeperName.Size = new System.Drawing.Size(37, 17);
            this.labelKeeperName.TabIndex = 19;
            this.labelKeeperName.Text = "Imię:";
            // 
            // labelKeeperSurname
            // 
            this.labelKeeperSurname.AutoSize = true;
            this.labelKeeperSurname.Location = new System.Drawing.Point(431, 335);
            this.labelKeeperSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeeperSurname.Name = "labelKeeperSurname";
            this.labelKeeperSurname.Size = new System.Drawing.Size(71, 17);
            this.labelKeeperSurname.TabIndex = 20;
            this.labelKeeperSurname.Text = "Nazwisko:";
            // 
            // textBoxNimberOfNewAnimals
            // 
            this.textBoxNimberOfNewAnimals.Location = new System.Drawing.Point(117, 495);
            this.textBoxNimberOfNewAnimals.Name = "textBoxNimberOfNewAnimals";
            this.textBoxNimberOfNewAnimals.Size = new System.Drawing.Size(78, 22);
            this.textBoxNimberOfNewAnimals.TabIndex = 21;
            this.textBoxNimberOfNewAnimals.Text = "1";
            // 
            // labelNumberOfNewAnimals
            // 
            this.labelNumberOfNewAnimals.AutoSize = true;
            this.labelNumberOfNewAnimals.Location = new System.Drawing.Point(40, 498);
            this.labelNumberOfNewAnimals.Name = "labelNumberOfNewAnimals";
            this.labelNumberOfNewAnimals.Size = new System.Drawing.Size(65, 17);
            this.labelNumberOfNewAnimals.TabIndex = 22;
            this.labelNumberOfNewAnimals.Text = "Ile dodac";
            // 
            // buttonDeleteZookeeper
            // 
            this.buttonDeleteZookeeper.Location = new System.Drawing.Point(471, 436);
            this.buttonDeleteZookeeper.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteZookeeper.Name = "buttonDeleteZookeeper";
            this.buttonDeleteZookeeper.Size = new System.Drawing.Size(176, 49);
            this.buttonDeleteZookeeper.TabIndex = 23;
            this.buttonDeleteZookeeper.Text = "Usun Opiekuna";
            this.buttonDeleteZookeeper.UseVisualStyleBackColor = true;
            this.buttonDeleteZookeeper.Click += new System.EventHandler(this.buttonDeleteZookeeper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 529);
            this.Controls.Add(this.buttonDeleteZookeeper);
            this.Controls.Add(this.labelNumberOfNewAnimals);
            this.Controls.Add(this.textBoxNimberOfNewAnimals);
            this.Controls.Add(this.labelKeeperSurname);
            this.Controls.Add(this.labelKeeperName);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelSlothsName);
            this.Controls.Add(this.buttonMoreAnimal);
            this.Controls.Add(this.comboBoxSpecies);
            this.Controls.Add(this.buttonFindAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelBetween);
            this.Controls.Add(this.textBoxAgeRight);
            this.Controls.Add(this.textBoxAgeLeft);
            this.Controls.Add(this.textBoxFindSloths);
            this.Controls.Add(this.buttonShowAllZookeepers);
            this.Controls.Add(this.buttonAddZookeeper);
            this.Controls.Add(this.textBoxZookeeperSurname);
            this.Controls.Add(this.textBoxZookeeperName);
            this.Controls.Add(this.buttonSloths);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.dataGridViewZoo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZoo;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonSloths;
        private System.Windows.Forms.TextBox textBoxZookeeperName;
        private System.Windows.Forms.TextBox textBoxZookeeperSurname;
        private System.Windows.Forms.Button buttonAddZookeeper;
        private System.Windows.Forms.Button buttonShowAllZookeepers;
        private System.Windows.Forms.TextBox textBoxFindSloths;
        private System.Windows.Forms.TextBox textBoxAgeLeft;
        private System.Windows.Forms.TextBox textBoxAgeRight;
        private System.Windows.Forms.Label labelBetween;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonFindAge;
        private System.Windows.Forms.ComboBox comboBoxSpecies;
        private System.Windows.Forms.Button buttonMoreAnimal;
        private System.Windows.Forms.Label labelSlothsName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelKeeperName;
        private System.Windows.Forms.Label labelKeeperSurname;
        private System.Windows.Forms.TextBox textBoxNimberOfNewAnimals;
        private System.Windows.Forms.Label labelNumberOfNewAnimals;
        private System.Windows.Forms.Button buttonDeleteZookeeper;
    }
}

