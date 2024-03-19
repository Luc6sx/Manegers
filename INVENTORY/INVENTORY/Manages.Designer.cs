namespace INVENTORY
{
    partial class Manages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nametx = new System.Windows.Forms.TextBox();
            this.FullNametx = new System.Windows.Forms.TextBox();
            this.Passwordtx = new System.Windows.Forms.TextBox();
            this.TelePhonetx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.usersgd = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(785, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nametx
            // 
            this.nametx.Location = new System.Drawing.Point(37, 177);
            this.nametx.Name = "nametx";
            this.nametx.Size = new System.Drawing.Size(200, 20);
            this.nametx.TabIndex = 2;
            // 
            // FullNametx
            // 
            this.FullNametx.Location = new System.Drawing.Point(37, 227);
            this.FullNametx.Name = "FullNametx";
            this.FullNametx.Size = new System.Drawing.Size(200, 20);
            this.FullNametx.TabIndex = 3;
            this.FullNametx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Passwordtx
            // 
            this.Passwordtx.Location = new System.Drawing.Point(39, 278);
            this.Passwordtx.Name = "Passwordtx";
            this.Passwordtx.Size = new System.Drawing.Size(200, 20);
            this.Passwordtx.TabIndex = 4;
            // 
            // TelePhonetx
            // 
            this.TelePhonetx.Location = new System.Drawing.Point(37, 327);
            this.TelePhonetx.Name = "TelePhonetx";
            this.TelePhonetx.Size = new System.Drawing.Size(200, 20);
            this.TelePhonetx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FullName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PassWord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TelePhone";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(12, 375);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 34);
            this.add.TabIndex = 10;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(99, 375);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(81, 34);
            this.edit.TabIndex = 11;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(186, 375);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 34);
            this.delete.TabIndex = 12;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(99, 415);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(81, 34);
            this.home.TabIndex = 13;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = false;
            // 
            // usersgd
            // 
            this.usersgd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgd.Location = new System.Drawing.Point(273, 72);
            this.usersgd.Name = "usersgd";
            this.usersgd.Size = new System.Drawing.Size(515, 495);
            this.usersgd.TabIndex = 14;
            this.usersgd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgd_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(111, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "show list";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Manages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.usersgd);
            this.Controls.Add(this.home);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelePhonetx);
            this.Controls.Add(this.Passwordtx);
            this.Controls.Add(this.FullNametx);
            this.Controls.Add(this.nametx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manages";
            this.Text = "Manages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nametx;
        private System.Windows.Forms.TextBox FullNametx;
        private System.Windows.Forms.TextBox Passwordtx;
        private System.Windows.Forms.TextBox TelePhonetx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.DataGridView usersgd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}