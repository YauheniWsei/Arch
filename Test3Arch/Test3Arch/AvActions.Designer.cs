namespace Test3Arch
{
    partial class AvActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvActions));
            this.actions = new System.Windows.Forms.Label();
            this.close_actions_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actions
            // 
            this.actions.AutoSize = true;
            this.actions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actions.Location = new System.Drawing.Point(12, 9);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(620, 484);
            this.actions.TabIndex = 0;
            this.actions.Text = resources.GetString("actions.Text");
            // 
            // close_actions_but
            // 
            this.close_actions_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_actions_but.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_actions_but.Location = new System.Drawing.Point(16, 529);
            this.close_actions_but.Name = "close_actions_but";
            this.close_actions_but.Size = new System.Drawing.Size(95, 39);
            this.close_actions_but.TabIndex = 1;
            this.close_actions_but.Text = "Close";
            this.close_actions_but.UseVisualStyleBackColor = true;
            this.close_actions_but.Click += new System.EventHandler(this.close_actions_but_Click);
            // 
            // AvActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 580);
            this.Controls.Add(this.close_actions_but);
            this.Controls.Add(this.actions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvActions";
            this.Text = "AvActions";
            this.Load += new System.EventHandler(this.AvActions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actions;
        private System.Windows.Forms.Button close_actions_but;
    }
}