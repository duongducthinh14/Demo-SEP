﻿namespace Demo.GUI
{
    partial class GUI_Account_Manager_AddEdit
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtAccountManagerEmail = new System.Windows.Forms.TextBox();
            this.lblAccountManagerEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAccountManagerPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAccountManagerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboAccountManagerType = new System.Windows.Forms.ComboBox();
            this.lblAccountManagerType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnAccountManagerSave = new System.Windows.Forms.Button();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAccountManagerSave);
            this.layoutControl1.Controls.Add(this.cboAccountManagerType);
            this.layoutControl1.Controls.Add(this.textBox3);
            this.layoutControl1.Controls.Add(this.textBox2);
            this.layoutControl1.Controls.Add(this.txtAccountManagerEmail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(497, 245);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblAccountManagerEmail,
            this.lblAccountManagerPass,
            this.lblAccountManagerName,
            this.lblAccountManagerType,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem1,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(497, 245);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtAccountManagerEmail
            // 
            this.txtAccountManagerEmail.Location = new System.Drawing.Point(84, 36);
            this.txtAccountManagerEmail.Name = "txtAccountManagerEmail";
            this.txtAccountManagerEmail.Size = new System.Drawing.Size(401, 20);
            this.txtAccountManagerEmail.TabIndex = 4;
            // 
            // lblAccountManagerEmail
            // 
            this.lblAccountManagerEmail.Control = this.txtAccountManagerEmail;
            this.lblAccountManagerEmail.Location = new System.Drawing.Point(0, 24);
            this.lblAccountManagerEmail.Name = "lblAccountManagerEmail";
            this.lblAccountManagerEmail.Size = new System.Drawing.Size(477, 24);
            this.lblAccountManagerEmail.Text = "Email";
            this.lblAccountManagerEmail.TextSize = new System.Drawing.Size(69, 13);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblAccountManagerPass
            // 
            this.lblAccountManagerPass.Control = this.textBox2;
            this.lblAccountManagerPass.Location = new System.Drawing.Point(0, 48);
            this.lblAccountManagerPass.Name = "lblAccountManagerPass";
            this.lblAccountManagerPass.Size = new System.Drawing.Size(477, 24);
            this.lblAccountManagerPass.Text = "Mật Khẩu";
            this.lblAccountManagerPass.TextSize = new System.Drawing.Size(69, 13);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(401, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblAccountManagerName
            // 
            this.lblAccountManagerName.Control = this.textBox3;
            this.lblAccountManagerName.Location = new System.Drawing.Point(0, 72);
            this.lblAccountManagerName.Name = "lblAccountManagerName";
            this.lblAccountManagerName.Size = new System.Drawing.Size(477, 24);
            this.lblAccountManagerName.Text = "Họ và Tên";
            this.lblAccountManagerName.TextSize = new System.Drawing.Size(69, 13);
            // 
            // cboAccountManagerType
            // 
            this.cboAccountManagerType.FormattingEnabled = true;
            this.cboAccountManagerType.Location = new System.Drawing.Point(84, 108);
            this.cboAccountManagerType.Name = "cboAccountManagerType";
            this.cboAccountManagerType.Size = new System.Drawing.Size(401, 21);
            this.cboAccountManagerType.TabIndex = 9;
            // 
            // lblAccountManagerType
            // 
            this.lblAccountManagerType.Control = this.cboAccountManagerType;
            this.lblAccountManagerType.Location = new System.Drawing.Point(0, 96);
            this.lblAccountManagerType.Name = "lblAccountManagerType";
            this.lblAccountManagerType.Size = new System.Drawing.Size(477, 25);
            this.lblAccountManagerType.Text = "Loại Tài Khoản";
            this.lblAccountManagerType.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(477, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 199);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(477, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnAccountManagerSave
            // 
            this.btnAccountManagerSave.Location = new System.Drawing.Point(12, 160);
            this.btnAccountManagerSave.Name = "btnAccountManagerSave";
            this.btnAccountManagerSave.Size = new System.Drawing.Size(473, 47);
            this.btnAccountManagerSave.TabIndex = 10;
            this.btnAccountManagerSave.Text = "Lưu Lại";
            this.btnAccountManagerSave.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAccountManagerSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(477, 51);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(477, 27);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // GUI_Account_Manager_AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 245);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GUI_Account_Manager_AddEdit";
            this.Text = "Chỉnh Sửa Thông Tin";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountManagerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Button btnAccountManagerSave;
        private System.Windows.Forms.ComboBox cboAccountManagerType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAccountManagerEmail;
        private DevExpress.XtraLayout.LayoutControlItem lblAccountManagerEmail;
        private DevExpress.XtraLayout.LayoutControlItem lblAccountManagerPass;
        private DevExpress.XtraLayout.LayoutControlItem lblAccountManagerName;
        private DevExpress.XtraLayout.LayoutControlItem lblAccountManagerType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}