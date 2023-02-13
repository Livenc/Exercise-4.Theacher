namespace Exercise_4.Theacher
{
    partial class BankApp
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bTransfer = new System.Windows.Forms.Button();
            this.bProposition = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(7, 234);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(63, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "пополнение";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bTransfer
            // 
            this.bTransfer.Location = new System.Drawing.Point(76, 234);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(54, 23);
            this.bTransfer.TabIndex = 1;
            this.bTransfer.Text = "переказ";
            this.bTransfer.UseVisualStyleBackColor = true;
            this.bTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // bProposition
            // 
            this.bProposition.Location = new System.Drawing.Point(136, 234);
            this.bProposition.Name = "bProposition";
            this.bProposition.Size = new System.Drawing.Size(72, 23);
            this.bProposition.TabIndex = 2;
            this.bProposition.Text = "услуги";
            this.bProposition.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(0, 420);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.back.Size = new System.Drawing.Size(280, 25);
            this.back.TabIndex = 13;
            this.back.Text = "Exit";
            this.back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(280, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bProposition);
            this.Controls.Add(this.bTransfer);
            this.Controls.Add(this.bAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankApp";
            this.Load += new System.EventHandler(this.BankApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bTransfer;
        private System.Windows.Forms.Button bProposition;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}