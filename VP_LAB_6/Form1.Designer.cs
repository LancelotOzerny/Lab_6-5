namespace VP_LAB_6
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
            this.label_AngleValue = new System.Windows.Forms.Label();
            this.myElement1 = new VP_LAB_6.MyElement();
            this.SuspendLayout();
            // 
            // label_AngleValue
            // 
            this.label_AngleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_AngleValue.AutoSize = true;
            this.label_AngleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_AngleValue.Location = new System.Drawing.Point(13, 487);
            this.label_AngleValue.Name = "label_AngleValue";
            this.label_AngleValue.Size = new System.Drawing.Size(75, 24);
            this.label_AngleValue.TabIndex = 1;
            this.label_AngleValue.Text = "Angle : ";
            // 
            // myElement1
            // 
            this.myElement1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myElement1.Location = new System.Drawing.Point(12, 12);
            this.myElement1.Name = "myElement1";
            this.myElement1.Size = new System.Drawing.Size(397, 430);
            this.myElement1.TabIndex = 2;
            this.myElement1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.myElement1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(421, 530);
            this.Controls.Add(this.myElement1);
            this.Controls.Add(this.label_AngleValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_AngleValue;
        private MyElement myElement1;
    }
}

