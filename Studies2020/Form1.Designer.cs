namespace Studies2020
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
            this.comboBoxPredmets = new System.Windows.Forms.ComboBox();
            this.listViewStudentIspit = new System.Windows.Forms.ListView();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentIspit = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentIspit)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPredmets
            // 
            this.comboBoxPredmets.FormattingEnabled = true;
            this.comboBoxPredmets.Location = new System.Drawing.Point(39, 12);
            this.comboBoxPredmets.Name = "comboBoxPredmets";
            this.comboBoxPredmets.Size = new System.Drawing.Size(135, 24);
            this.comboBoxPredmets.TabIndex = 0;
            this.comboBoxPredmets.SelectedIndexChanged += new System.EventHandler(this.comboBoxPredmets_SelectedIndexChanged);
            // 
            // listViewStudentIspit
            // 
            this.listViewStudentIspit.HideSelection = false;
            this.listViewStudentIspit.Location = new System.Drawing.Point(12, 52);
            this.listViewStudentIspit.Name = "listViewStudentIspit";
            this.listViewStudentIspit.Size = new System.Drawing.Size(1055, 171);
            this.listViewStudentIspit.TabIndex = 1;
            this.listViewStudentIspit.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(531, 244);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // dataGridViewStudentIspit
            // 
            this.dataGridViewStudentIspit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentIspit.Location = new System.Drawing.Point(549, 284);
            this.dataGridViewStudentIspit.Name = "dataGridViewStudentIspit";
            this.dataGridViewStudentIspit.RowHeadersWidth = 51;
            this.dataGridViewStudentIspit.RowTemplate.Height = 24;
            this.dataGridViewStudentIspit.Size = new System.Drawing.Size(518, 244);
            this.dataGridViewStudentIspit.TabIndex = 3;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(12, 243);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(97, 35);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(137, 243);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(97, 35);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(269, 243);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 35);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(397, 243);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(97, 35);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Refresh";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 540);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewStudentIspit);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.listViewStudentIspit);
            this.Controls.Add(this.comboBoxPredmets);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentIspit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPredmets;
        private System.Windows.Forms.ListView listViewStudentIspit;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudentIspit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
    }
}

