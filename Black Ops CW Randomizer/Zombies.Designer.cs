
namespace Black_Ops_CW_Randomizer
{
    partial class Zombies
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.BtnRandomize = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(3, 3);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(210, 173);
            this.lst.TabIndex = 0;
            // 
            // BtnRandomize
            // 
            this.BtnRandomize.Location = new System.Drawing.Point(3, 182);
            this.BtnRandomize.Name = "BtnRandomize";
            this.BtnRandomize.Size = new System.Drawing.Size(100, 23);
            this.BtnRandomize.TabIndex = 1;
            this.BtnRandomize.Text = "Randomize!";
            this.BtnRandomize.UseVisualStyleBackColor = true;
            this.BtnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.Location = new System.Drawing.Point(113, 182);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(100, 23);
            this.BtnOptions.TabIndex = 2;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // Zombies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnOptions);
            this.Controls.Add(this.BtnRandomize);
            this.Controls.Add(this.lst);
            this.Name = "Zombies";
            this.Size = new System.Drawing.Size(217, 235);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button BtnRandomize;
        private System.Windows.Forms.Button BtnOptions;
    }
}
