
namespace Black_Ops_CW_Randomizer
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
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnZom = new System.Windows.Forms.Button();
            this.zombies1 = new Black_Ops_CW_Randomizer.Zombies();
            this.SuspendLayout();
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(12, 12);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(146, 30);
            this.BtnMult.TabIndex = 0;
            this.BtnMult.Text = "Multiplayer";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnZom
            // 
            this.BtnZom.Location = new System.Drawing.Point(12, 60);
            this.BtnZom.Name = "BtnZom";
            this.BtnZom.Size = new System.Drawing.Size(146, 30);
            this.BtnZom.TabIndex = 1;
            this.BtnZom.Text = "Zombies";
            this.BtnZom.UseVisualStyleBackColor = true;
            this.BtnZom.Click += new System.EventHandler(this.BtnZom_Click);
            // 
            // zombies1
            // 
            this.zombies1.Location = new System.Drawing.Point(12, 12);
            this.zombies1.Name = "zombies1";
            this.zombies1.Size = new System.Drawing.Size(150, 150);
            this.zombies1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.zombies1);
            this.Controls.Add(this.BtnZom);
            this.Controls.Add(this.BtnMult);
            this.Name = "Form1";
            this.Text = "BlopCW Randomizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnZom;
        private Zombies zombies1;
    }
}

