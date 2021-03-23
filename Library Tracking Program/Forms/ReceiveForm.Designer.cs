
namespace Library_Tracking_Program
{
    partial class ReceiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name_surname = new System.Windows.Forms.TextBox();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.dtp_receive_date = new System.Windows.Forms.DateTimePicker();
            this.cb_book_status = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yukarıdaki bilgileri kontrol ediniz !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslim Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasar Durumu:";
            // 
            // tb_name_surname
            // 
            this.tb_name_surname.Location = new System.Drawing.Point(119, 25);
            this.tb_name_surname.Name = "tb_name_surname";
            this.tb_name_surname.ReadOnly = true;
            this.tb_name_surname.Size = new System.Drawing.Size(181, 23);
            this.tb_name_surname.TabIndex = 5;
            this.tb_name_surname.WordWrap = false;
            // 
            // tb_book_name
            // 
            this.tb_book_name.Location = new System.Drawing.Point(119, 62);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.ReadOnly = true;
            this.tb_book_name.Size = new System.Drawing.Size(181, 23);
            this.tb_book_name.TabIndex = 6;
            // 
            // dtp_receive_date
            // 
            this.dtp_receive_date.Location = new System.Drawing.Point(119, 170);
            this.dtp_receive_date.Name = "dtp_receive_date";
            this.dtp_receive_date.Size = new System.Drawing.Size(181, 23);
            this.dtp_receive_date.TabIndex = 7;
            this.dtp_receive_date.Value = new System.DateTime(2021, 2, 25, 20, 0, 43, 0);
            // 
            // cb_book_status
            // 
            this.cb_book_status.FormattingEnabled = true;
            this.cb_book_status.Location = new System.Drawing.Point(119, 217);
            this.cb_book_status.Name = "cb_book_status";
            this.cb_book_status.Size = new System.Drawing.Size(181, 23);
            this.cb_book_status.TabIndex = 8;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.White;
            this.button_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Image = ((System.Drawing.Image)(resources.GetObject("button_ok.Image")));
            this.button_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ok.Location = new System.Drawing.Point(351, 42);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(109, 81);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "Tamam";
            this.button_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.White;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_cancel.Image")));
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cancel.Location = new System.Drawing.Point(351, 154);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(109, 81);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "İptal";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 268);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.cb_book_status);
            this.Controls.Add(this.dtp_receive_date);
            this.Controls.Add(this.tb_book_name);
            this.Controls.Add(this.tb_name_surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceiveForm";
            this.Text = "Teslim Formu";
            this.Load += new System.EventHandler(this.ReceiveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name_surname;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.DateTimePicker dtp_receive_date;
        private System.Windows.Forms.ComboBox cb_book_status;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}