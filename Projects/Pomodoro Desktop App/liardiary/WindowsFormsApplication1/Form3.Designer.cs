namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.colon = new System.Windows.Forms.Label();
            this.pause_sec = new System.Windows.Forms.Label();
            this.pause_min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_sec = new System.Windows.Forms.Label();
            this.edit_min = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.edit_plus = new System.Windows.Forms.Button();
            this.edit_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colon
            // 
            this.colon.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colon.Location = new System.Drawing.Point(85, 36);
            this.colon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(26, 51);
            this.colon.TabIndex = 13;
            this.colon.Text = ":";
            // 
            // pause_sec
            // 
            this.pause_sec.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_sec.Location = new System.Drawing.Point(106, 36);
            this.pause_sec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pause_sec.Name = "pause_sec";
            this.pause_sec.Size = new System.Drawing.Size(70, 51);
            this.pause_sec.TabIndex = 12;
            // 
            // pause_min
            // 
            this.pause_min.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_min.Location = new System.Drawing.Point(32, 36);
            this.pause_min.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pause_min.Name = "pause_min";
            this.pause_min.Size = new System.Drawing.Size(70, 51);
            this.pause_min.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = ":";
            // 
            // edit_sec
            // 
            this.edit_sec.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_sec.Location = new System.Drawing.Point(99, 35);
            this.edit_sec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edit_sec.Name = "edit_sec";
            this.edit_sec.Size = new System.Drawing.Size(70, 51);
            this.edit_sec.TabIndex = 15;
            // 
            // edit_min
            // 
            this.edit_min.Font = new System.Drawing.Font("Meiryo", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_min.Location = new System.Drawing.Point(25, 35);
            this.edit_min.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edit_min.Name = "edit_min";
            this.edit_min.Size = new System.Drawing.Size(70, 51);
            this.edit_min.TabIndex = 14;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(184, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(26, 26);
            this.back.TabIndex = 17;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // edit_plus
            // 
            this.edit_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_plus.BackgroundImage")));
            this.edit_plus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.edit_plus.FlatAppearance.BorderSize = 0;
            this.edit_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_plus.Location = new System.Drawing.Point(129, 110);
            this.edit_plus.Name = "edit_plus";
            this.edit_plus.Size = new System.Drawing.Size(16, 14);
            this.edit_plus.TabIndex = 20;
            this.edit_plus.UseVisualStyleBackColor = true;
            this.edit_plus.Click += new System.EventHandler(this.edit_plus_Click);
            // 
            // edit_minus
            // 
            this.edit_minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_minus.BackgroundImage")));
            this.edit_minus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.edit_minus.FlatAppearance.BorderSize = 0;
            this.edit_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_minus.Location = new System.Drawing.Point(34, 110);
            this.edit_minus.Name = "edit_minus";
            this.edit_minus.Size = new System.Drawing.Size(16, 14);
            this.edit_minus.TabIndex = 21;
            this.edit_minus.UseVisualStyleBackColor = true;
            this.edit_minus.Click += new System.EventHandler(this.edit_minus_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.edit_minus);
            this.Controls.Add(this.edit_plus);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_sec);
            this.Controls.Add(this.edit_min);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Label pause_sec;
        private System.Windows.Forms.Label pause_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label edit_sec;
        private System.Windows.Forms.Label edit_min;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit_plus;
        private System.Windows.Forms.Button edit_minus;

    }
}