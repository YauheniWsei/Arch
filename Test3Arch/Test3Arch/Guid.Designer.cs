namespace Test3Arch
{
    partial class Guid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guid));
            this.guide_text = new System.Windows.Forms.Label();
            this.back_guide_but = new System.Windows.Forms.Button();
            this.table_hextobin_but = new System.Windows.Forms.Button();
            this.available_actions_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guide_text
            // 
            this.guide_text.AutoSize = true;
            this.guide_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.guide_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guide_text.Location = new System.Drawing.Point(0, 0);
            this.guide_text.Name = "guide_text";
            this.guide_text.Size = new System.Drawing.Size(586, 550);
            this.guide_text.TabIndex = 0;
            this.guide_text.Text = resources.GetString("guide_text.Text");
            // 
            // back_guide_but
            // 
            this.back_guide_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_guide_but.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_guide_but.Location = new System.Drawing.Point(12, 591);
            this.back_guide_but.Name = "back_guide_but";
            this.back_guide_but.Size = new System.Drawing.Size(117, 70);
            this.back_guide_but.TabIndex = 1;
            this.back_guide_but.Text = "Back";
            this.back_guide_but.UseVisualStyleBackColor = true;
            this.back_guide_but.Click += new System.EventHandler(this.back_guide_but_Click);
            // 
            // table_hextobin_but
            // 
            this.table_hextobin_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table_hextobin_but.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.table_hextobin_but.Location = new System.Drawing.Point(377, 591);
            this.table_hextobin_but.Name = "table_hextobin_but";
            this.table_hextobin_but.Size = new System.Drawing.Size(182, 32);
            this.table_hextobin_but.TabIndex = 2;
            this.table_hextobin_but.Text = "Table HEX to BIN";
            this.table_hextobin_but.UseVisualStyleBackColor = true;
            this.table_hextobin_but.Click += new System.EventHandler(this.table_hextobin_but_Click);
            // 
            // available_actions_but
            // 
            this.available_actions_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.available_actions_but.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.available_actions_but.Location = new System.Drawing.Point(377, 629);
            this.available_actions_but.Name = "available_actions_but";
            this.available_actions_but.Size = new System.Drawing.Size(182, 32);
            this.available_actions_but.TabIndex = 3;
            this.available_actions_but.Text = "Available actions";
            this.available_actions_but.UseVisualStyleBackColor = true;
            this.available_actions_but.Click += new System.EventHandler(this.available_actions_but_Click);
            // 
            // Guid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 689);
            this.Controls.Add(this.available_actions_but);
            this.Controls.Add(this.table_hextobin_but);
            this.Controls.Add(this.back_guide_but);
            this.Controls.Add(this.guide_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guid";
            this.Text = "Guid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guide_text;
        private System.Windows.Forms.Button back_guide_but;
        private System.Windows.Forms.Button table_hextobin_but;
        private System.Windows.Forms.Button available_actions_but;
    }
}