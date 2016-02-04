namespace TaskTrayApplication
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.actionButton = new System.Windows.Forms.Button();
            this.pomodoroTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionButton
            // 
            this.actionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButton.BackColor = System.Drawing.Color.Maroon;
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.FlatAppearance.BorderSize = 0;
            this.actionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButton.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionButton.Location = new System.Drawing.Point(71, 110);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(126, 38);
            this.actionButton.TabIndex = 1;
            this.actionButton.Text = "START";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.button);
            // 
            // pomodoroTime
            // 
            this.pomodoroTime.AccessibleName = "label";
            this.pomodoroTime.AllowDrop = true;
            this.pomodoroTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pomodoroTime.AutoSize = true;
            this.pomodoroTime.Font = new System.Drawing.Font("Lato", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroTime.Location = new System.Drawing.Point(19, 9);
            this.pomodoroTime.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.pomodoroTime.Name = "pomodoroTime";
            this.pomodoroTime.Size = new System.Drawing.Size(229, 77);
            this.pomodoroTime.TabIndex = 3;
            this.pomodoroTime.Text = "25 : 00";
            this.pomodoroTime.UseMnemonic = false;
            this.pomodoroTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Pomodoro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(270, 160);
            this.ControlBox = false;
            this.Controls.Add(this.pomodoroTime);
            this.Controls.Add(this.actionButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label pomodoroTime;
    }
}

