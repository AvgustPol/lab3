namespace AntonVlasiukSchoolDatabase
{
    partial class FormMain
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
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.buttonShowAllSubjects = new System.Windows.Forms.Button();
            this.buttonNextTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.textBoxFindByName = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(12, 17);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.RowTemplate.Height = 24;
            this.dataGridViewTables.Size = new System.Drawing.Size(467, 304);
            this.dataGridViewTables.TabIndex = 1;
            // 
            // buttonShowAllSubjects
            // 
            this.buttonShowAllSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllSubjects.Location = new System.Drawing.Point(12, 380);
            this.buttonShowAllSubjects.Name = "buttonShowAllSubjects";
            this.buttonShowAllSubjects.Size = new System.Drawing.Size(124, 88);
            this.buttonShowAllSubjects.TabIndex = 2;
            this.buttonShowAllSubjects.Text = "Show all subjects";
            this.buttonShowAllSubjects.UseVisualStyleBackColor = true;
            this.buttonShowAllSubjects.Click += new System.EventHandler(this.buttonShowAllSubjects_Click);
            // 
            // buttonNextTable
            // 
            this.buttonNextTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextTable.Location = new System.Drawing.Point(352, 380);
            this.buttonNextTable.Name = "buttonNextTable";
            this.buttonNextTable.Size = new System.Drawing.Size(124, 88);
            this.buttonNextTable.TabIndex = 3;
            this.buttonNextTable.Text = "Next table";
            this.buttonNextTable.UseVisualStyleBackColor = true;
            this.buttonNextTable.Click += new System.EventHandler(this.buttonNextTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(505, 17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(175, 80);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(505, 130);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(175, 80);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModify.Location = new System.Drawing.Point(505, 241);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(175, 80);
            this.buttonModify.TabIndex = 6;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdd.Location = new System.Drawing.Point(742, 17);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(175, 30);
            this.textBoxAdd.TabIndex = 9;
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldName.Location = new System.Drawing.Point(742, 241);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.Size = new System.Drawing.Size(175, 30);
            this.textBoxOldName.TabIndex = 11;
            this.textBoxOldName.Text = "Write old name";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelete.Location = new System.Drawing.Point(742, 130);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(175, 30);
            this.textBoxDelete.TabIndex = 13;
            // 
            // textBoxFindByName
            // 
            this.textBoxFindByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFindByName.Location = new System.Drawing.Point(617, 438);
            this.textBoxFindByName.Name = "textBoxFindByName";
            this.textBoxFindByName.Size = new System.Drawing.Size(175, 30);
            this.textBoxFindByName.TabIndex = 15;
            this.textBoxFindByName.TextChanged += new System.EventHandler(this.textBoxFindByName_TextChanged_1);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewName.Location = new System.Drawing.Point(742, 291);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(175, 30);
            this.textBoxNewName.TabIndex = 16;
            this.textBoxNewName.Text = "New name";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(559, 388);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(285, 25);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "Write name of subject to search";
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowStudents.Location = new System.Drawing.Point(182, 380);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(124, 88);
            this.buttonShowStudents.TabIndex = 18;
            this.buttonShowStudents.Text = "Show students ";
            this.buttonShowStudents.UseVisualStyleBackColor = true;
            this.buttonShowStudents.Click += new System.EventHandler(this.buttonShowStudents_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 505);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.textBoxFindByName);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.textBoxOldName);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNextTable);
            this.Controls.Add(this.buttonShowAllSubjects);
            this.Controls.Add(this.dataGridViewTables);
            this.Name = "FormMain";
            this.Text = "School";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Button buttonShowAllSubjects;
        private System.Windows.Forms.Button buttonNextTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.TextBox textBoxFindByName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonShowStudents;
    }
}

