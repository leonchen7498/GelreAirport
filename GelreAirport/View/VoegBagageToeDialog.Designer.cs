namespace GelreAirport.View
{
    partial class VoegBagageToeDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.gewichtTextBox = new System.Windows.Forms.TextBox();
            this.opslaanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer gewicht in:";
            // 
            // gewichtTextBox
            // 
            this.gewichtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gewichtTextBox.Location = new System.Drawing.Point(36, 56);
            this.gewichtTextBox.Name = "gewichtTextBox";
            this.gewichtTextBox.Size = new System.Drawing.Size(135, 26);
            this.gewichtTextBox.TabIndex = 1;
            // 
            // opslaanBtn
            // 
            this.opslaanBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.opslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanBtn.Location = new System.Drawing.Point(36, 88);
            this.opslaanBtn.Name = "opslaanBtn";
            this.opslaanBtn.Size = new System.Drawing.Size(135, 34);
            this.opslaanBtn.TabIndex = 2;
            this.opslaanBtn.Text = "Opslaan";
            this.opslaanBtn.UseVisualStyleBackColor = true;
            this.opslaanBtn.Click += new System.EventHandler(this.opslaanBtn_Click);
            // 
            // VoegBagageToeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 163);
            this.Controls.Add(this.opslaanBtn);
            this.Controls.Add(this.gewichtTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoegBagageToeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bagage toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gewichtTextBox;
        private System.Windows.Forms.Button opslaanBtn;
    }
}