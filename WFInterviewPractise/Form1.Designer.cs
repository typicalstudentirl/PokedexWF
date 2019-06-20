namespace WFInterviewPractise
{
    partial class Pokedex
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
            this.btn_randm = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_capture_rate = new System.Windows.Forms.Label();
            this.dvd_1 = new System.Windows.Forms.Label();
            this.lbl_name_resp = new System.Windows.Forms.Label();
            this.lbl_capture_rate_resp = new System.Windows.Forms.Label();
            this.lbl_id_resp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_randm
            // 
            this.btn_randm.ForeColor = System.Drawing.Color.Black;
            this.btn_randm.Location = new System.Drawing.Point(236, 226);
            this.btn_randm.Name = "btn_randm";
            this.btn_randm.Size = new System.Drawing.Size(105, 23);
            this.btn_randm.TabIndex = 0;
            this.btn_randm.Text = "Random";
            this.btn_randm.UseVisualStyleBackColor = true;
            this.btn_randm.Click += new System.EventHandler(this.btn_randm_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Id.Location = new System.Drawing.Point(114, 112);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(78, 15);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "Pokedex #:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_name.Location = new System.Drawing.Point(114, 153);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 15);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_capture_rate
            // 
            this.lbl_capture_rate.AutoSize = true;
            this.lbl_capture_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capture_rate.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_capture_rate.Location = new System.Drawing.Point(114, 191);
            this.lbl_capture_rate.Name = "lbl_capture_rate";
            this.lbl_capture_rate.Size = new System.Drawing.Size(95, 15);
            this.lbl_capture_rate.TabIndex = 4;
            this.lbl_capture_rate.Text = "Capture Rate:";
            // 
            // dvd_1
            // 
            this.dvd_1.AutoSize = true;
            this.dvd_1.Location = new System.Drawing.Point(84, 134);
            this.dvd_1.Name = "dvd_1";
            this.dvd_1.Size = new System.Drawing.Size(0, 13);
            this.dvd_1.TabIndex = 5;
            // 
            // lbl_name_resp
            // 
            this.lbl_name_resp.BackColor = System.Drawing.Color.White;
            this.lbl_name_resp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_name_resp.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_resp.Location = new System.Drawing.Point(215, 153);
            this.lbl_name_resp.Name = "lbl_name_resp";
            this.lbl_name_resp.Size = new System.Drawing.Size(150, 15);
            this.lbl_name_resp.TabIndex = 6;
            // 
            // lbl_capture_rate_resp
            // 
            this.lbl_capture_rate_resp.BackColor = System.Drawing.Color.White;
            this.lbl_capture_rate_resp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_capture_rate_resp.ForeColor = System.Drawing.Color.Black;
            this.lbl_capture_rate_resp.Location = new System.Drawing.Point(215, 193);
            this.lbl_capture_rate_resp.Name = "lbl_capture_rate_resp";
            this.lbl_capture_rate_resp.Size = new System.Drawing.Size(150, 15);
            this.lbl_capture_rate_resp.TabIndex = 7;
            // 
            // lbl_id_resp
            // 
            this.lbl_id_resp.BackColor = System.Drawing.Color.White;
            this.lbl_id_resp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_id_resp.ForeColor = System.Drawing.Color.Black;
            this.lbl_id_resp.Location = new System.Drawing.Point(215, 114);
            this.lbl_id_resp.Name = "lbl_id_resp";
            this.lbl_id_resp.Size = new System.Drawing.Size(150, 15);
            this.lbl_id_resp.TabIndex = 8;
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(549, 329);
            this.Controls.Add(this.lbl_id_resp);
            this.Controls.Add(this.lbl_capture_rate_resp);
            this.Controls.Add(this.lbl_name_resp);
            this.Controls.Add(this.dvd_1);
            this.Controls.Add(this.lbl_capture_rate);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_randm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_randm;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_capture_rate;
        private System.Windows.Forms.Label dvd_1;
        private System.Windows.Forms.Label lbl_name_resp;
        private System.Windows.Forms.Label lbl_capture_rate_resp;
        private System.Windows.Forms.Label lbl_id_resp;
    }
}

