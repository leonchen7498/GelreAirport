namespace GelreAirport
{
    partial class ZoekenPassagierWindow
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
            this.zoekTerm = new System.Windows.Forms.TextBox();
            this.zoekOptie = new System.Windows.Forms.ComboBox();
            this.zoekenBtn = new System.Windows.Forms.Button();
            this.zoekResultaatDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zoekResultaatDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // zoekTerm
            // 
            this.zoekTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoekTerm.Location = new System.Drawing.Point(12, 12);
            this.zoekTerm.Name = "zoekTerm";
            this.zoekTerm.Size = new System.Drawing.Size(180, 26);
            this.zoekTerm.TabIndex = 0;
            // 
            // zoekOptie
            // 
            this.zoekOptie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoekOptie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoekOptie.FormattingEnabled = true;
            this.zoekOptie.Items.AddRange(new object[] {
            "Passagiersnaam",
            "Vluchtnummer",
            "Bestemming",
            "Maatschappij",
            "Vertrekdatum"});
            this.zoekOptie.Location = new System.Drawing.Point(198, 12);
            this.zoekOptie.Name = "zoekOptie";
            this.zoekOptie.Size = new System.Drawing.Size(150, 28);
            this.zoekOptie.TabIndex = 1;
            // 
            // zoekenBtn
            // 
            this.zoekenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoekenBtn.Location = new System.Drawing.Point(354, 12);
            this.zoekenBtn.Name = "zoekenBtn";
            this.zoekenBtn.Size = new System.Drawing.Size(318, 28);
            this.zoekenBtn.TabIndex = 5;
            this.zoekenBtn.Text = "Zoeken";
            this.zoekenBtn.UseVisualStyleBackColor = true;
            // 
            // zoekResultaatDataGrid
            // 
            this.zoekResultaatDataGrid.AllowUserToAddRows = false;
            this.zoekResultaatDataGrid.AllowUserToDeleteRows = false;
            this.zoekResultaatDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoekResultaatDataGrid.Location = new System.Drawing.Point(12, 46);
            this.zoekResultaatDataGrid.Name = "zoekResultaatDataGrid";
            this.zoekResultaatDataGrid.ReadOnly = true;
            this.zoekResultaatDataGrid.RowHeadersVisible = false;
            this.zoekResultaatDataGrid.Size = new System.Drawing.Size(660, 403);
            this.zoekResultaatDataGrid.TabIndex = 6;
            // 
            // ZoekenPassagierWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.zoekResultaatDataGrid);
            this.Controls.Add(this.zoekenBtn);
            this.Controls.Add(this.zoekOptie);
            this.Controls.Add(this.zoekTerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZoekenPassagierWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelre Airport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZoekenPassagierWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.zoekResultaatDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zoekTerm;
        private System.Windows.Forms.ComboBox zoekOptie;
        private System.Windows.Forms.Button zoekenBtn;
        private System.Windows.Forms.DataGridView zoekResultaatDataGrid;
    }
}