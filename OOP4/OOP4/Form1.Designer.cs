namespace OOP4
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
            this.cmb_Disks = new System.Windows.Forms.ComboBox();
            this.lb_Disks = new System.Windows.Forms.Label();
            this.b_Refresh = new System.Windows.Forms.Button();
            this.lb_Type = new System.Windows.Forms.Label();
            this.lb_Amount = new System.Windows.Forms.Label();
            this.lb_Free = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstbox_About = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_Disks
            // 
            this.cmb_Disks.FormattingEnabled = true;
            this.cmb_Disks.Location = new System.Drawing.Point(68, 12);
            this.cmb_Disks.Name = "cmb_Disks";
            this.cmb_Disks.Size = new System.Drawing.Size(121, 21);
            this.cmb_Disks.TabIndex = 0;
            this.cmb_Disks.SelectedIndexChanged += new System.EventHandler(this.cmb_Disks_SelectedIndexChanged);
            // 
            // lb_Disks
            // 
            this.lb_Disks.AutoSize = true;
            this.lb_Disks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Disks.Location = new System.Drawing.Point(12, 13);
            this.lb_Disks.Name = "lb_Disks";
            this.lb_Disks.Size = new System.Drawing.Size(50, 16);
            this.lb_Disks.TabIndex = 1;
            this.lb_Disks.Text = "Диски:";
            // 
            // b_Refresh
            // 
            this.b_Refresh.Location = new System.Drawing.Point(195, 10);
            this.b_Refresh.Name = "b_Refresh";
            this.b_Refresh.Size = new System.Drawing.Size(75, 23);
            this.b_Refresh.TabIndex = 2;
            this.b_Refresh.Text = "Оновити";
            this.b_Refresh.UseVisualStyleBackColor = true;
            this.b_Refresh.Click += new System.EventHandler(this.b_Refresh_Click);
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Location = new System.Drawing.Point(12, 52);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(62, 13);
            this.lb_Type.TabIndex = 3;
            this.lb_Type.Text = "Тип диска:";
            this.lb_Type.Visible = false;
            // 
            // lb_Amount
            // 
            this.lb_Amount.AutoSize = true;
            this.lb_Amount.Location = new System.Drawing.Point(12, 75);
            this.lb_Amount.Name = "lb_Amount";
            this.lb_Amount.Size = new System.Drawing.Size(74, 13);
            this.lb_Amount.TabIndex = 4;
            this.lb_Amount.Text = "Обсяг диска:";
            this.lb_Amount.Visible = false;
            // 
            // lb_Free
            // 
            this.lb_Free.AutoSize = true;
            this.lb_Free.Location = new System.Drawing.Point(12, 99);
            this.lb_Free.Name = "lb_Free";
            this.lb_Free.Size = new System.Drawing.Size(74, 13);
            this.lb_Free.TabIndex = 5;
            this.lb_Free.Text = "Вільне місце:";
            this.lb_Free.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 316);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstbox_About
            // 
            this.lstbox_About.FormattingEnabled = true;
            this.lstbox_About.Location = new System.Drawing.Point(475, 55);
            this.lstbox_About.Name = "lstbox_About";
            this.lstbox_About.Size = new System.Drawing.Size(313, 134);
            this.lstbox_About.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbox_About);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lb_Free);
            this.Controls.Add(this.lb_Amount);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.b_Refresh);
            this.Controls.Add(this.lb_Disks);
            this.Controls.Add(this.cmb_Disks);
            this.Name = "Form1";
            this.Text = "lstbox_Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Disks;
        private System.Windows.Forms.Label lb_Disks;
        private System.Windows.Forms.Button b_Refresh;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.Label lb_Amount;
        private System.Windows.Forms.Label lb_Free;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstbox_About;
    }
}

