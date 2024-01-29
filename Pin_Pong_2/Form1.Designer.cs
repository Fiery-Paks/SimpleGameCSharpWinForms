namespace Pin_Pong_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.Lab_GW = new System.Windows.Forms.Label();
            this.Lab_PW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP1
            // 
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP1.Location = new System.Drawing.Point(70, 10);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(70, 30);
            this.labelP1.TabIndex = 1;
            this.labelP1.Text = "pause_lab";
            // 
            // labelP2
            // 
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2.Location = new System.Drawing.Point(660, 10);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(70, 30);
            this.labelP2.TabIndex = 2;
            this.labelP2.Text = "pause_lab";
            // 
            // Lab_GW
            // 
            this.Lab_GW.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Lab_GW.Location = new System.Drawing.Point(70, 400);
            this.Lab_GW.Name = "Lab_GW";
            this.Lab_GW.Size = new System.Drawing.Size(30, 30);
            this.Lab_GW.TabIndex = 3;
            this.Lab_GW.Text = "0";
            // 
            // Lab_PW
            // 
            this.Lab_PW.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Lab_PW.Location = new System.Drawing.Point(690, 400);
            this.Lab_PW.Name = "Lab_PW";
            this.Lab_PW.Size = new System.Drawing.Size(30, 30);
            this.Lab_PW.TabIndex = 4;
            this.Lab_PW.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.Lab_PW);
            this.Controls.Add(this.Lab_GW);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Ping Pong First MOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label Lab_GW;
        private System.Windows.Forms.Label Lab_PW;
    }
}

