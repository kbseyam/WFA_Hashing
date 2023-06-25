namespace WFA_Hashing {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHashed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Items.AddRange(new object[] {
            "MD-5",
            "RIPEMD-160",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cbAlgorithm.Location = new System.Drawing.Point(92, 261);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(260, 21);
            this.cbAlgorithm.Sorted = true;
            this.cbAlgorithm.TabIndex = 1;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.CbAlgorithm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plain text:";
            // 
            // tbPlain
            // 
            this.tbPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlain.Location = new System.Drawing.Point(15, 33);
            this.tbPlain.Multiline = true;
            this.tbPlain.Name = "tbPlain";
            this.tbPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlain.Size = new System.Drawing.Size(337, 215);
            this.tbPlain.TabIndex = 3;
            this.tbPlain.TextChanged += new System.EventHandler(this.TbPlain_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Algorithm:";
            // 
            // tbHashed
            // 
            this.tbHashed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHashed.Location = new System.Drawing.Point(390, 33);
            this.tbHashed.Multiline = true;
            this.tbHashed.Name = "tbHashed";
            this.tbHashed.ReadOnly = true;
            this.tbHashed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHashed.Size = new System.Drawing.Size(337, 215);
            this.tbHashed.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hashed text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHashed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAlgorithm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hashing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHashed;
        private System.Windows.Forms.Label label4;
    }
}

