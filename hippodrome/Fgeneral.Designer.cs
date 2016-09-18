namespace hippodrome
{
    partial class Fgeneral
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
            this.tabResultatCourse = new System.Windows.Forms.TabPage();
            this.cbChevaux = new System.Windows.Forms.ComboBox();
            this.dgResultatCheval = new System.Windows.Forms.DataGridView();
            this.tabgeneral = new System.Windows.Forms.TabControl();
            this.tabCheval = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgRésultatsCourse = new System.Windows.Forms.DataGridView();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.tabResultats = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCheval = new System.Windows.Forms.ComboBox();
            this.dgParticipation = new System.Windows.Forms.DataGridView();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabResultatCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultatCheval)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.tabCheval.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRésultatsCourse)).BeginInit();
            this.tabResultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParticipation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabResultatCourse
            // 
            this.tabResultatCourse.Controls.Add(this.cbChevaux);
            this.tabResultatCourse.Controls.Add(this.dgResultatCheval);
            this.tabResultatCourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResultatCourse.Location = new System.Drawing.Point(4, 28);
            this.tabResultatCourse.Name = "tabResultatCourse";
            this.tabResultatCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultatCourse.Size = new System.Drawing.Size(1043, 472);
            this.tabResultatCourse.TabIndex = 1;
            this.tabResultatCourse.Text = "Résultats par chevaux";
            this.tabResultatCourse.UseVisualStyleBackColor = true;
            // 
            // cbChevaux
            // 
            this.cbChevaux.FormattingEnabled = true;
            this.cbChevaux.Location = new System.Drawing.Point(52, 27);
            this.cbChevaux.Name = "cbChevaux";
            this.cbChevaux.Size = new System.Drawing.Size(509, 27);
            this.cbChevaux.TabIndex = 1;
            this.cbChevaux.Text = "Sélectionnez le cheval";
            // 
            // dgResultatCheval
            // 
            this.dgResultatCheval.AllowUserToAddRows = false;
            this.dgResultatCheval.AllowUserToDeleteRows = false;
            this.dgResultatCheval.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgResultatCheval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultatCheval.Location = new System.Drawing.Point(30, 103);
            this.dgResultatCheval.Name = "dgResultatCheval";
            this.dgResultatCheval.ReadOnly = true;
            this.dgResultatCheval.Size = new System.Drawing.Size(548, 290);
            this.dgResultatCheval.TabIndex = 0;
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabCheval);
            this.tabgeneral.Controls.Add(this.tabResultatCourse);
            this.tabgeneral.Controls.Add(this.tabResultats);
            this.tabgeneral.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(4, 5);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1051, 504);
            this.tabgeneral.TabIndex = 0;
            // 
            // tabCheval
            // 
            this.tabCheval.Controls.Add(this.button1);
            this.tabCheval.Controls.Add(this.tabControl1);
            this.tabCheval.Controls.Add(this.dgRésultatsCourse);
            this.tabCheval.Controls.Add(this.cbCourse);
            this.tabCheval.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCheval.Location = new System.Drawing.Point(4, 28);
            this.tabCheval.Name = "tabCheval";
            this.tabCheval.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheval.Size = new System.Drawing.Size(1043, 472);
            this.tabCheval.TabIndex = 0;
            this.tabCheval.Text = "Résultats par course";
            this.tabCheval.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(358, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgRésultatsCourse
            // 
            this.dgRésultatsCourse.AllowUserToAddRows = false;
            this.dgRésultatsCourse.AllowUserToDeleteRows = false;
            this.dgRésultatsCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRésultatsCourse.Location = new System.Drawing.Point(19, 77);
            this.dgRésultatsCourse.Name = "dgRésultatsCourse";
            this.dgRésultatsCourse.ReadOnly = true;
            this.dgRésultatsCourse.Size = new System.Drawing.Size(480, 320);
            this.dgRésultatsCourse.TabIndex = 1;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(31, 23);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(483, 27);
            this.cbCourse.TabIndex = 0;
            this.cbCourse.Text = "Sélectionnez le cheval";
            // 
            // tabResultats
            // 
            this.tabResultats.Controls.Add(this.label1);
            this.tabResultats.Controls.Add(this.cbCheval);
            this.tabResultats.Controls.Add(this.dgParticipation);
            this.tabResultats.Controls.Add(this.cbCourses);
            this.tabResultats.Location = new System.Drawing.Point(4, 28);
            this.tabResultats.Name = "tabResultats";
            this.tabResultats.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultats.Size = new System.Drawing.Size(1043, 472);
            this.tabResultats.TabIndex = 2;
            this.tabResultats.Text = "Résultat d\'un cheval à une course";
            this.tabResultats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Résultat du cheval pour la course :";
            // 
            // cbCheval
            // 
            this.cbCheval.FormattingEnabled = true;
            this.cbCheval.Location = new System.Drawing.Point(391, 30);
            this.cbCheval.Name = "cbCheval";
            this.cbCheval.Size = new System.Drawing.Size(426, 27);
            this.cbCheval.TabIndex = 2;
            this.cbCheval.Text = "Sélectionnez le cheval";
            // 
            // dgParticipation
            // 
            this.dgParticipation.AllowUserToAddRows = false;
            this.dgParticipation.AllowUserToDeleteRows = false;
            this.dgParticipation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParticipation.Location = new System.Drawing.Point(37, 110);
            this.dgParticipation.Name = "dgParticipation";
            this.dgParticipation.ReadOnly = true;
            this.dgParticipation.Size = new System.Drawing.Size(805, 184);
            this.dgParticipation.TabIndex = 1;
            // 
            // cbCourses
            // 
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(37, 25);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(310, 27);
            this.cbCourses.TabIndex = 0;
            this.cbCourses.Text = "Sélectionnez la course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Monbouton";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Fgeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 511);
            this.Controls.Add(this.tabgeneral);
            this.Name = "Fgeneral";
            this.Text = "Fgeneral";
            this.Load += new System.EventHandler(this.Fgeneral_Load);
            this.tabResultatCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultatCheval)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.tabCheval.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRésultatsCourse)).EndInit();
            this.tabResultats.ResumeLayout(false);
            this.tabResultats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParticipation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabResultatCourse;
        private System.Windows.Forms.DataGridView dgResultatCheval;
        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.TabPage tabCheval;
        private System.Windows.Forms.ComboBox cbChevaux;
        private System.Windows.Forms.DataGridView dgRésultatsCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabResultats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCheval;
        private System.Windows.Forms.DataGridView dgParticipation;
        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Button button1;
    }
}