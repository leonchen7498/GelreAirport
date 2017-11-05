namespace GelreAirport.View
{
    partial class DetailedPassagierVluchtWindow
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
            this.bagageDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passagierNrTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.geslachtTextBox = new System.Windows.Forms.TextBox();
            this.geboortedatumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vluchtenDataGrid = new System.Windows.Forms.DataGridView();
            this.toevoegenBagageBtn = new System.Windows.Forms.Button();
            this.verwijderenBagageBtn = new System.Windows.Forms.Button();
            this.opslaanBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bagageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vluchtenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bagageDataGrid
            // 
            this.bagageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagageDataGrid.Location = new System.Drawing.Point(12, 324);
            this.bagageDataGrid.Name = "bagageDataGrid";
            this.bagageDataGrid.Size = new System.Drawing.Size(561, 125);
            this.bagageDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passagiernummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Geslacht:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Geboortedatum:";
            // 
            // passagierNrTextBox
            // 
            this.passagierNrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passagierNrTextBox.Location = new System.Drawing.Point(154, 12);
            this.passagierNrTextBox.Name = "passagierNrTextBox";
            this.passagierNrTextBox.ReadOnly = true;
            this.passagierNrTextBox.Size = new System.Drawing.Size(111, 26);
            this.passagierNrTextBox.TabIndex = 5;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamTextBox.Location = new System.Drawing.Point(154, 44);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.ReadOnly = true;
            this.naamTextBox.Size = new System.Drawing.Size(111, 26);
            this.naamTextBox.TabIndex = 6;
            // 
            // geslachtTextBox
            // 
            this.geslachtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geslachtTextBox.Location = new System.Drawing.Point(414, 12);
            this.geslachtTextBox.Name = "geslachtTextBox";
            this.geslachtTextBox.ReadOnly = true;
            this.geslachtTextBox.Size = new System.Drawing.Size(32, 26);
            this.geslachtTextBox.TabIndex = 7;
            // 
            // geboortedatumTextBox
            // 
            this.geboortedatumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geboortedatumTextBox.Location = new System.Drawing.Point(415, 44);
            this.geboortedatumTextBox.Name = "geboortedatumTextBox";
            this.geboortedatumTextBox.ReadOnly = true;
            this.geboortedatumTextBox.Size = new System.Drawing.Size(158, 26);
            this.geboortedatumTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reeds ingecheckte bagage";
            // 
            // vluchtenDataGrid
            // 
            this.vluchtenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vluchtenDataGrid.Location = new System.Drawing.Point(12, 143);
            this.vluchtenDataGrid.Name = "vluchtenDataGrid";
            this.vluchtenDataGrid.Size = new System.Drawing.Size(561, 147);
            this.vluchtenDataGrid.TabIndex = 10;
            // 
            // toevoegenBagageBtn
            // 
            this.toevoegenBagageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toevoegenBagageBtn.Location = new System.Drawing.Point(12, 456);
            this.toevoegenBagageBtn.Name = "toevoegenBagageBtn";
            this.toevoegenBagageBtn.Size = new System.Drawing.Size(136, 36);
            this.toevoegenBagageBtn.TabIndex = 11;
            this.toevoegenBagageBtn.Text = "Toevoegen";
            this.toevoegenBagageBtn.UseVisualStyleBackColor = true;
            // 
            // verwijderenBagageBtn
            // 
            this.verwijderenBagageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verwijderenBagageBtn.Location = new System.Drawing.Point(154, 456);
            this.verwijderenBagageBtn.Name = "verwijderenBagageBtn";
            this.verwijderenBagageBtn.Size = new System.Drawing.Size(136, 36);
            this.verwijderenBagageBtn.TabIndex = 12;
            this.verwijderenBagageBtn.Text = "Verwijderen";
            this.verwijderenBagageBtn.UseVisualStyleBackColor = true;
            // 
            // opslaanBtn
            // 
            this.opslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanBtn.Location = new System.Drawing.Point(437, 456);
            this.opslaanBtn.Name = "opslaanBtn";
            this.opslaanBtn.Size = new System.Drawing.Size(136, 36);
            this.opslaanBtn.TabIndex = 13;
            this.opslaanBtn.Text = "Opslaan";
            this.opslaanBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Geboekte vluchten";
            // 
            // DetailedPassagierVluchtWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.opslaanBtn);
            this.Controls.Add(this.verwijderenBagageBtn);
            this.Controls.Add(this.toevoegenBagageBtn);
            this.Controls.Add(this.vluchtenDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.geboortedatumTextBox);
            this.Controls.Add(this.geslachtTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.passagierNrTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bagageDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedPassagierVluchtWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelre Airport";
            this.Load += new System.EventHandler(this.DetailedPassagierVluchtWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bagageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vluchtenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bagageDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passagierNrTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox geslachtTextBox;
        private System.Windows.Forms.TextBox geboortedatumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView vluchtenDataGrid;
        private System.Windows.Forms.Button toevoegenBagageBtn;
        private System.Windows.Forms.Button verwijderenBagageBtn;
        private System.Windows.Forms.Button opslaanBtn;
        private System.Windows.Forms.Label label6;
    }
}