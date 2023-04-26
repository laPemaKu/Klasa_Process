namespace Klasa_Process
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
            this.btnIExplorer = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnStarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIExplorer
            // 
            this.btnIExplorer.Location = new System.Drawing.Point(28, 22);
            this.btnIExplorer.Name = "btnIExplorer";
            this.btnIExplorer.Size = new System.Drawing.Size(174, 27);
            this.btnIExplorer.TabIndex = 0;
            this.btnIExplorer.Text = "Pokrenite Internet Explorer";
            this.btnIExplorer.UseVisualStyleBackColor = true;
            this.btnIExplorer.Click += new System.EventHandler(this.btnIExplorer_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(236, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(174, 27);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Pokrenite Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(28, 67);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(174, 27);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Pokrenite Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnStarInfo
            // 
            this.btnStarInfo.Location = new System.Drawing.Point(236, 67);
            this.btnStarInfo.Name = "btnStarInfo";
            this.btnStarInfo.Size = new System.Drawing.Size(174, 27);
            this.btnStarInfo.TabIndex = 3;
            this.btnStarInfo.Text = "StarInfo";
            this.btnStarInfo.UseVisualStyleBackColor = true;
            this.btnStarInfo.Click += new System.EventHandler(this.btnStarInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStarInfo);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnIExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIExplorer;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnStarInfo;
    }
}

