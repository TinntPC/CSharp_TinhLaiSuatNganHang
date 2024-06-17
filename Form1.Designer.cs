namespace CSharp_TinhLaiSuatNganHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtLaisuat = new System.Windows.Forms.TextBox();
            this.txtSonamgui = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lsbKQ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lãi suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số năm gửi";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(208, 23);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(302, 26);
            this.txtSotien.TabIndex = 1;
            this.txtSotien.Text = "100";
            // 
            // txtLaisuat
            // 
            this.txtLaisuat.Location = new System.Drawing.Point(208, 79);
            this.txtLaisuat.Name = "txtLaisuat";
            this.txtLaisuat.Size = new System.Drawing.Size(302, 26);
            this.txtLaisuat.TabIndex = 1;
            this.txtLaisuat.Text = "5";
            // 
            // txtSonamgui
            // 
            this.txtSonamgui.Location = new System.Drawing.Point(208, 145);
            this.txtSonamgui.Name = "txtSonamgui";
            this.txtSonamgui.Size = new System.Drawing.Size(302, 26);
            this.txtSonamgui.TabIndex = 1;
            this.txtSonamgui.Text = "1";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(164, 203);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(236, 85);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lsbKQ
            // 
            this.lsbKQ.FormattingEnabled = true;
            this.lsbKQ.ItemHeight = 18;
            this.lsbKQ.Location = new System.Drawing.Point(58, 319);
            this.lsbKQ.Name = "lsbKQ";
            this.lsbKQ.Size = new System.Drawing.Size(452, 256);
            this.lsbKQ.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 623);
            this.Controls.Add(this.lsbKQ);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSonamgui);
            this.Controls.Add(this.txtLaisuat);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtLaisuat;
        private System.Windows.Forms.TextBox txtSonamgui;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lsbKQ;
    }
}

