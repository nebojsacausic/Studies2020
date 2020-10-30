namespace Studies2020
{
    partial class AddStudentForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxIme1 = new System.Windows.Forms.TextBox();
            this.textBoxPrezime1 = new System.Windows.Forms.TextBox();
            this.textBoxIndexBroj1 = new System.Windows.Forms.TextBox();
            this.textBoxIndexGodina1 = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(168, 372);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 47);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxIme1
            // 
            this.textBoxIme1.Location = new System.Drawing.Point(168, 131);
            this.textBoxIme1.Name = "textBoxIme1";
            this.textBoxIme1.Size = new System.Drawing.Size(158, 22);
            this.textBoxIme1.TabIndex = 1;
            // 
            // textBoxPrezime1
            // 
            this.textBoxPrezime1.Location = new System.Drawing.Point(168, 184);
            this.textBoxPrezime1.Name = "textBoxPrezime1";
            this.textBoxPrezime1.Size = new System.Drawing.Size(158, 22);
            this.textBoxPrezime1.TabIndex = 2;
            // 
            // textBoxIndexBroj1
            // 
            this.textBoxIndexBroj1.Location = new System.Drawing.Point(168, 238);
            this.textBoxIndexBroj1.Name = "textBoxIndexBroj1";
            this.textBoxIndexBroj1.Size = new System.Drawing.Size(158, 22);
            this.textBoxIndexBroj1.TabIndex = 3;
            // 
            // textBoxIndexGodina1
            // 
            this.textBoxIndexGodina1.Location = new System.Drawing.Point(168, 290);
            this.textBoxIndexGodina1.Name = "textBoxIndexGodina1";
            this.textBoxIndexGodina1.Size = new System.Drawing.Size(158, 22);
            this.textBoxIndexGodina1.TabIndex = 4;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(54, 134);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(34, 17);
            this.Ime.TabIndex = 5;
            this.Ime.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj indeksa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Godina indeksa";
            // 
            // AddStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(472, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.textBoxIndexGodina1);
            this.Controls.Add(this.textBoxIndexBroj1);
            this.Controls.Add(this.textBoxPrezime1);
            this.Controls.Add(this.textBoxIme1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIndexBroj;
        private System.Windows.Forms.TextBox textBoxIndexGodina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxIme1;
        private System.Windows.Forms.TextBox textBoxPrezime1;
        private System.Windows.Forms.TextBox textBoxIndexBroj1;
        private System.Windows.Forms.TextBox textBoxIndexGodina1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}