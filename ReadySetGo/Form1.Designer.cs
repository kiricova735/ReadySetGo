namespace ReadySetGo
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
            this.backroundLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.gameCounter = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backroundLabel
            // 
            this.backroundLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backroundLabel.Location = new System.Drawing.Point(-3, -2);
            this.backroundLabel.Name = "backroundLabel";
            this.backroundLabel.Size = new System.Drawing.Size(804, 461);
            this.backroundLabel.TabIndex = 0;
            this.backroundLabel.Text = "label1";
            this.backroundLabel.Click += new System.EventHandler(this.BackroundLabel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Location = new System.Drawing.Point(305, 218);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(198, 67);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gameCounter
            // 
            this.gameCounter.AutoSize = true;
            this.gameCounter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gameCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.gameCounter.Location = new System.Drawing.Point(305, 180);
            this.gameCounter.Name = "gameCounter";
            this.gameCounter.Size = new System.Drawing.Size(180, 25);
            this.gameCounter.TabIndex = 3;
            this.gameCounter.Text = "Game Will Start In: ";
            this.gameCounter.Click += new System.EventHandler(this.GameCounter_Click);
            // 
            // number3
            // 
            this.number3.AutoSize = true;
            this.number3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.number3.ForeColor = System.Drawing.SystemColors.Control;
            this.number3.Location = new System.Drawing.Point(480, 180);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(23, 25);
            this.number3.TabIndex = 4;
            this.number3.Text = "3";
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.BackColor = System.Drawing.Color.Lime;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.go.ForeColor = System.Drawing.SystemColors.Control;
            this.go.Location = new System.Drawing.Point(382, 288);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(56, 29);
            this.go.TabIndex = 7;
            this.go.Text = "GO!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.gameCounter);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.backroundLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backroundLabel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label gameCounter;
        private System.Windows.Forms.Label number3;
        private System.Windows.Forms.Label go;
    }
}

