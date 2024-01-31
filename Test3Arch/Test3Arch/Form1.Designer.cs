namespace Test3Arch
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_but = new System.Windows.Forms.Button();
            this.close_but = new System.Windows.Forms.Button();
            this.start_label = new System.Windows.Forms.Label();
            this.guide_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_but
            // 
            this.start_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_but.Location = new System.Drawing.Point(87, 125);
            this.start_but.Name = "start_but";
            this.start_but.Size = new System.Drawing.Size(180, 50);
            this.start_but.TabIndex = 0;
            this.start_but.Text = "Start";
            this.start_but.UseVisualStyleBackColor = true;
            this.start_but.Click += new System.EventHandler(this.start_but_Click);
            // 
            // close_but
            // 
            this.close_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_but.Location = new System.Drawing.Point(87, 237);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(180, 50);
            this.close_but.TabIndex = 2;
            this.close_but.Text = "Close";
            this.close_but.UseVisualStyleBackColor = true;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_label.Location = new System.Drawing.Point(12, 42);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(321, 66);
            this.start_label.TabIndex = 3;
            this.start_label.Text = "Hello!\r\nTo begin a job, click \"Start\"";
            this.start_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guide_but
            // 
            this.guide_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guide_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guide_but.Location = new System.Drawing.Point(87, 181);
            this.guide_but.Name = "guide_but";
            this.guide_but.Size = new System.Drawing.Size(180, 50);
            this.guide_but.TabIndex = 4;
            this.guide_but.Text = "Guide";
            this.guide_but.UseVisualStyleBackColor = true;
            this.guide_but.Click += new System.EventHandler(this.guide_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 300);
            this.Controls.Add(this.guide_but);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.start_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_but;
        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.Button guide_but;
    }
}

