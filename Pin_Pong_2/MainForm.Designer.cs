namespace Pin_Pong_2
{
    partial class MainForm
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
            this.Start_But = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Options_But = new System.Windows.Forms.Button();
            this.infoBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_But
            // 
            this.Start_But.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_But.Location = new System.Drawing.Point(290, 225);
            this.Start_But.Name = "Start_But";
            this.Start_But.Size = new System.Drawing.Size(200, 70);
            this.Start_But.TabIndex = 0;
            this.Start_But.Text = "Start";
            this.Start_But.UseVisualStyleBackColor = true;
            this.Start_But.Click += new System.EventHandler(this.Start_But_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 185);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Options_But
            // 
            this.Options_But.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Options_But.Location = new System.Drawing.Point(622, 405);
            this.Options_But.Name = "Options_But";
            this.Options_But.Size = new System.Drawing.Size(150, 45);
            this.Options_But.TabIndex = 2;
            this.Options_But.Text = "Options";
            this.Options_But.UseVisualStyleBackColor = true;
            this.Options_But.Click += new System.EventHandler(this.Options_But_Click);
            // 
            // infoBut
            // 
            this.infoBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.infoBut.Location = new System.Drawing.Point(12, 408);
            this.infoBut.Name = "infoBut";
            this.infoBut.Size = new System.Drawing.Size(150, 45);
            this.infoBut.TabIndex = 3;
            this.infoBut.Text = "Info";
            this.infoBut.UseVisualStyleBackColor = true;
            this.infoBut.Click += new System.EventHandler(this.infoBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.infoBut);
            this.Controls.Add(this.Options_But);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_But);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_But;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Options_But;
        private System.Windows.Forms.Button infoBut;
    }
}