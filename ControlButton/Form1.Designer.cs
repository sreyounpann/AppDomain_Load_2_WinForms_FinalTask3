namespace ControlButton
{
    partial class Form1
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Lime;
            this.btnLeft.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnLeft.Location = new System.Drawing.Point(147, 166);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(120, 114);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "LEFT 10px";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Lime;
            this.btnDown.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDown.Location = new System.Drawing.Point(276, 288);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(120, 114);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "DOWN 10px";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Lime;
            this.btnRight.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnRight.Location = new System.Drawing.Point(410, 166);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(120, 114);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "RIGHT 10px";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Lime;
            this.btnUp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnUp.Location = new System.Drawing.Point(276, 46);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(120, 114);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "UP 10px";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(641, 478);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
    }
}

