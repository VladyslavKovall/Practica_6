namespace WinAsynchMethod
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
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(325, 166);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Робота";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(57, 166);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Сума";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(54, 43);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(83, 16);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Значення А";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(317, 43);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(83, 16);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Значення В";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(57, 62);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 22);
            this.txbA.TabIndex = 4;
            this.txbA.Text = "10";
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(300, 62);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 22);
            this.txbB.TabIndex = 5;
            this.txbB.Text = "21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 219);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
    }
}

