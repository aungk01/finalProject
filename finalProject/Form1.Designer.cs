﻿namespace finalProject
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
            this.components = new System.ComponentModel.Container();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtuPassword = new System.Windows.Forms.TextBox();
            this.txtuName = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnName = new System.Windows.Forms.Button();
            this.btnExpire = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.lblDislike = new System.Windows.Forms.Label();
            this.lblLIkecount = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.radioDislike = new System.Windows.Forms.RadioButton();
            this.radioLike = new System.Windows.Forms.RadioButton();
            this.gbProductreg = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtExpirationdate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pDataSet = new finalProject.pDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new finalProject.pDataSetTableAdapters.productsTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbRegister.SuspendLayout();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbChoice.SuspendLayout();
            this.gbProductreg.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.label4);
            this.gbRegister.Controls.Add(this.label3);
            this.gbRegister.Controls.Add(this.txtPassword);
            this.gbRegister.Controls.Add(this.txtUserName);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Location = new System.Drawing.Point(369, 27);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(198, 100);
            this.gbRegister.TabIndex = 0;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(54, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(98, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(54, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(43, 71);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.label6);
            this.gbLogin.Controls.Add(this.label5);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtuPassword);
            this.gbLogin.Controls.Add(this.txtuName);
            this.gbLogin.Location = new System.Drawing.Point(369, 133);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(198, 105);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "User Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(43, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtuPassword
            // 
            this.txtuPassword.Location = new System.Drawing.Point(85, 51);
            this.txtuPassword.Name = "txtuPassword";
            this.txtuPassword.Size = new System.Drawing.Size(73, 20);
            this.txtuPassword.TabIndex = 2;
            // 
            // txtuName
            // 
            this.txtuName.Location = new System.Drawing.Point(85, 18);
            this.txtuName.Name = "txtuName";
            this.txtuName.Size = new System.Drawing.Size(73, 20);
            this.txtuName.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productsBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(5, 27);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(361, 211);
            this.dgvProducts.TabIndex = 2;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(22, 250);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            // 
            // btnExpire
            // 
            this.btnExpire.Location = new System.Drawing.Point(115, 250);
            this.btnExpire.Name = "btnExpire";
            this.btnExpire.Size = new System.Drawing.Size(75, 23);
            this.btnExpire.TabIndex = 7;
            this.btnExpire.Text = "Expiration";
            this.btnExpire.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(222, 250);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(75, 23);
            this.btnLocation.TabIndex = 8;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.lblDislike);
            this.gbChoice.Controls.Add(this.lblLIkecount);
            this.gbChoice.Controls.Add(this.btnVote);
            this.gbChoice.Controls.Add(this.radioDislike);
            this.gbChoice.Controls.Add(this.radioLike);
            this.gbChoice.Location = new System.Drawing.Point(369, 279);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(198, 181);
            this.gbChoice.TabIndex = 9;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Opinion";
            // 
            // lblDislike
            // 
            this.lblDislike.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDislike.Location = new System.Drawing.Point(107, 47);
            this.lblDislike.Name = "lblDislike";
            this.lblDislike.Size = new System.Drawing.Size(45, 23);
            this.lblDislike.TabIndex = 4;
            // 
            // lblLIkecount
            // 
            this.lblLIkecount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLIkecount.Location = new System.Drawing.Point(107, 22);
            this.lblLIkecount.Name = "lblLIkecount";
            this.lblLIkecount.Size = new System.Drawing.Size(45, 23);
            this.lblLIkecount.TabIndex = 3;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(43, 85);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 2;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // radioDislike
            // 
            this.radioDislike.AutoSize = true;
            this.radioDislike.Location = new System.Drawing.Point(16, 51);
            this.radioDislike.Name = "radioDislike";
            this.radioDislike.Size = new System.Drawing.Size(56, 17);
            this.radioDislike.TabIndex = 1;
            this.radioDislike.Text = "Dislike";
            this.radioDislike.UseVisualStyleBackColor = true;
            // 
            // radioLike
            // 
            this.radioLike.AutoSize = true;
            this.radioLike.Checked = true;
            this.radioLike.Location = new System.Drawing.Point(16, 25);
            this.radioLike.Name = "radioLike";
            this.radioLike.Size = new System.Drawing.Size(45, 17);
            this.radioLike.TabIndex = 0;
            this.radioLike.TabStop = true;
            this.radioLike.Text = "Like";
            this.radioLike.UseVisualStyleBackColor = true;
            // 
            // gbProductreg
            // 
            this.gbProductreg.Controls.Add(this.label8);
            this.gbProductreg.Controls.Add(this.label7);
            this.gbProductreg.Controls.Add(this.label2);
            this.gbProductreg.Controls.Add(this.label1);
            this.gbProductreg.Controls.Add(this.btnSave);
            this.gbProductreg.Controls.Add(this.statusStrip1);
            this.gbProductreg.Controls.Add(this.txtLocation);
            this.gbProductreg.Controls.Add(this.txtExpirationdate);
            this.gbProductreg.Controls.Add(this.txtPrice);
            this.gbProductreg.Controls.Add(this.txtName);
            this.gbProductreg.Location = new System.Drawing.Point(2, 279);
            this.gbProductreg.Name = "gbProductreg";
            this.gbProductreg.Size = new System.Drawing.Size(361, 181);
            this.gbProductreg.TabIndex = 10;
            this.gbProductreg.TabStop = false;
            this.gbProductreg.Text = "Product Registration";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 156);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(180, 107);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(151, 20);
            this.txtLocation.TabIndex = 8;
            // 
            // txtExpirationdate
            // 
            this.txtExpirationdate.Location = new System.Drawing.Point(180, 78);
            this.txtExpirationdate.Name = "txtExpirationdate";
            this.txtExpirationdate.Size = new System.Drawing.Size(151, 20);
            this.txtExpirationdate.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(180, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 5;
            // 
            // pDataSet
            // 
            this.pDataSet.DataSetName = "pDataSet";
            this.pDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.pDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product Id";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "Expiration date";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration date";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "Store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "Store";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(296, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Expiration Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 472);
            this.Controls.Add(this.gbProductreg);
            this.Controls.Add(this.gbChoice);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnExpire);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.gbProductreg.ResumeLayout(false);
            this.gbProductreg.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtuPassword;
        private System.Windows.Forms.TextBox txtuName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnExpire;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.Label lblDislike;
        private System.Windows.Forms.Label lblLIkecount;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.RadioButton radioDislike;
        private System.Windows.Forms.RadioButton radioLike;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProductreg;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtExpirationdate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private pDataSet pDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private pDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
