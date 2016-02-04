namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button pause;
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.colon = new System.Windows.Forms.Label();
            this.pause_sec = new System.Windows.Forms.Label();
            this.pause_min = new System.Windows.Forms.Label();
            pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pause
            // 
            pause.BackColor = System.Drawing.Color.Lime;
            pause.Location = new System.Drawing.Point(61, 99);
            pause.Name = "pause";
            pause.Size = new System.Drawing.Size(75, 23);
            pause.TabIndex = 0;
            pause.Text = "Skip Break";
            pause.UseVisualStyleBackColor = false;
            pause.Click += new System.EventHandler(this.pause_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.colon);
            this.Controls.Add(this.pause_sec);
            this.Controls.Add(this.pause_min);
            this.Controls.Add(pause);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Label pause_sec;
        private System.Windows.Forms.Label pause_min;
    }
}