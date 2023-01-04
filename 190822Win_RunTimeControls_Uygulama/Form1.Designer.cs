namespace _190822Win_RunTimeControls_Uygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipler = new System.Windows.Forms.ComboBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(10, 31);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(99, 22);
            this.nudAdet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip:";
            // 
            // cmbTipler
            // 
            this.cmbTipler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipler.FormattingEnabled = true;
            this.cmbTipler.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "ComboBox",
            "PictureBox",
            "ListBox"});
            this.cmbTipler.Location = new System.Drawing.Point(115, 31);
            this.cmbTipler.Name = "cmbTipler";
            this.cmbTipler.Size = new System.Drawing.Size(184, 24);
            this.cmbTipler.TabIndex = 3;
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(305, 31);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(116, 26);
            this.btnUret.TabIndex = 4;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 309);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.cmbTipler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipler;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

