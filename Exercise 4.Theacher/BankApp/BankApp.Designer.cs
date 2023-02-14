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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdd.FlatAppearance.BorderSize = 0;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Location = new System.Drawing.Point(7, 234);
            this.bAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(63, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "пополнение";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bTransfer
            // 
            this.bTransfer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTransfer.FlatAppearance.BorderSize = 0;
            this.bTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransfer.Location = new System.Drawing.Point(76, 234);
            this.bTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(54, 23);
            this.bTransfer.TabIndex = 1;
            this.bTransfer.Text = "переказ";
            this.bTransfer.UseVisualStyleBackColor = true;
            this.bTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // bProposition
            // 
            this.bProposition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bProposition.FlatAppearance.BorderSize = 0;
            this.bProposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProposition.Location = new System.Drawing.Point(136, 234);
            this.bProposition.Margin = new System.Windows.Forms.Padding(0);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(0, 0);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(135, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(280, 444);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
    }
}