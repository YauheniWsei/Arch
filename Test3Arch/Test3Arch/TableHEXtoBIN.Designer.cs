namespace Test3Arch
{
    partial class TableHEXtoBIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableHEXtoBIN));
            this.table_dec_hex_bin = new System.Windows.Forms.PictureBox();
            this.close_table_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_dec_hex_bin)).BeginInit();
            this.SuspendLayout();
            // 
            // table_dec_hex_bin
            // 
            this.table_dec_hex_bin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_dec_hex_bin.Image = ((System.Drawing.Image)(resources.GetObject("table_dec_hex_bin.Image")));
            this.table_dec_hex_bin.Location = new System.Drawing.Point(0, 0);
            this.table_dec_hex_bin.Name = "table_dec_hex_bin";
            this.table_dec_hex_bin.Size = new System.Drawing.Size(440, 527);
            this.table_dec_hex_bin.TabIndex = 0;
            this.table_dec_hex_bin.TabStop = false;
            // 
            // close_table_but
            // 
            this.close_table_but.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_table_but.Location = new System.Drawing.Point(26, 462);
            this.close_table_but.Name = "close_table_but";
            this.close_table_but.Size = new System.Drawing.Size(75, 42);
            this.close_table_but.TabIndex = 1;
            this.close_table_but.Text = "Close";
            this.close_table_but.UseVisualStyleBackColor = true;
            this.close_table_but.Click += new System.EventHandler(this.close_table_but_Click);
            // 
            // TableHEXtoBIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 527);
            this.Controls.Add(this.close_table_but);
            this.Controls.Add(this.table_dec_hex_bin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableHEXtoBIN";
            this.Text = "TableHEXtoBIN";
            ((System.ComponentModel.ISupportInitialize)(this.table_dec_hex_bin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox table_dec_hex_bin;
        private System.Windows.Forms.Button close_table_but;
    }
}