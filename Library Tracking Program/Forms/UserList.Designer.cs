
namespace Library_Tracking_Program
{
    partial class UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.dgv_user_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_member_no = new System.Windows.Forms.TextBox();
            this.tb_tc_no = new System.Windows.Forms.TextBox();
            this.tb_name_surname = new System.Windows.Forms.TextBox();
            this.tb_born_place = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user_list
            // 
            this.dgv_user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_list.Location = new System.Drawing.Point(13, 102);
            this.dgv_user_list.Name = "dgv_user_list";
            this.dgv_user_list.RowTemplate.Height = 25;
            this.dgv_user_list.Size = new System.Drawing.Size(775, 204);
            this.dgv_user_list.TabIndex = 0;
            this.dgv_user_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_user_list_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abone No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doğum Yeri:";
            // 
            // tb_member_no
            // 
            this.tb_member_no.Location = new System.Drawing.Point(83, 50);
            this.tb_member_no.Name = "tb_member_no";
            this.tb_member_no.Size = new System.Drawing.Size(100, 23);
            this.tb_member_no.TabIndex = 5;
            this.tb_member_no.TextChanged += new System.EventHandler(this.tb_member_no_TextChanged);
            // 
            // tb_tc_no
            // 
            this.tb_tc_no.Location = new System.Drawing.Point(287, 50);
            this.tb_tc_no.Name = "tb_tc_no";
            this.tb_tc_no.Size = new System.Drawing.Size(100, 23);
            this.tb_tc_no.TabIndex = 6;
            this.tb_tc_no.TextChanged += new System.EventHandler(this.tb_tc_no_TextChanged);
            // 
            // tb_name_surname
            // 
            this.tb_name_surname.Location = new System.Drawing.Point(474, 50);
            this.tb_name_surname.Name = "tb_name_surname";
            this.tb_name_surname.Size = new System.Drawing.Size(100, 23);
            this.tb_name_surname.TabIndex = 7;
            this.tb_name_surname.TextChanged += new System.EventHandler(this.tb_name_surname_TextChanged);
            // 
            // tb_born_place
            // 
            this.tb_born_place.Location = new System.Drawing.Point(673, 50);
            this.tb_born_place.Name = "tb_born_place";
            this.tb_born_place.Size = new System.Drawing.Size(100, 23);
            this.tb_born_place.TabIndex = 8;
            this.tb_born_place.TextChanged += new System.EventHandler(this.tb_born_place_TextChanged);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.Location = new System.Drawing.Point(422, 324);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 77);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Sil";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(595, 325);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(112, 76);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Çıkış";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(13, 342);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 19);
            this.label_warning.TabIndex = 11;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.tb_born_place);
            this.Controls.Add(this.tb_name_surname);
            this.Controls.Add(this.tb_tc_no);
            this.Controls.Add(this.tb_member_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_user_list);
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abone Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_member_no;
        private System.Windows.Forms.TextBox tb_tc_no;
        private System.Windows.Forms.TextBox tb_name_surname;
        private System.Windows.Forms.TextBox tb_born_place;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_warning;
    }
}