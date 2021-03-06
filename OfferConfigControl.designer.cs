namespace Cliver.PdfMailer2
{
    partial class OfferConfigControl
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
            this._0_tabControl4 = new System.Windows.Forms.TabControl();
            this._0_tabPage7 = new System.Windows.Forms.TabPage();
            this.CloseOfEscrow = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Emd = new System.Windows.Forms.TextBox();
            this._0_tabPage9 = new System.Windows.Forms.TabPage();
            this.DeleteAttachment = new System.Windows.Forms.Button();
            this.bImportAttachment = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.Attachments = new System.Windows.Forms.CheckedListBox();
            this.ShortSaleAddendum = new System.Windows.Forms.CheckBox();
            this.OtherAddendum2 = new System.Windows.Forms.CheckBox();
            this.OtherAddendum1 = new System.Windows.Forms.CheckBox();
            this._0_tabPage11 = new System.Windows.Forms.TabPage();
            this.EmailBody = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.EmailSubject = new System.Windows.Forms.TextBox();
            this.EmailTemplateProfiles = new Cliver.PdfMailer2.ProfilesControl();
            this.group_box.SuspendLayout();
            this._0_tabControl4.SuspendLayout();
            this._0_tabPage7.SuspendLayout();
            this._0_tabPage9.SuspendLayout();
            this._0_tabPage11.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_box
            // 
            this.group_box.Controls.Add(this._0_tabControl4);
            this.group_box.Size = new System.Drawing.Size(498, 364);
            this.group_box.Text = "TestCustom";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 100000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // _0_tabControl4
            // 
            this._0_tabControl4.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this._0_tabControl4.Controls.Add(this._0_tabPage7);
            this._0_tabControl4.Controls.Add(this._0_tabPage9);
            this._0_tabControl4.Controls.Add(this._0_tabPage11);
            this._0_tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._0_tabControl4.Location = new System.Drawing.Point(3, 16);
            this._0_tabControl4.Name = "_0_tabControl4";
            this._0_tabControl4.SelectedIndex = 0;
            this._0_tabControl4.Size = new System.Drawing.Size(492, 345);
            this._0_tabControl4.TabIndex = 0;
            // 
            // _0_tabPage7
            // 
            this._0_tabPage7.Controls.Add(this.CloseOfEscrow);
            this._0_tabPage7.Controls.Add(this.label19);
            this._0_tabPage7.Controls.Add(this.label20);
            this._0_tabPage7.Controls.Add(this.Emd);
            this._0_tabPage7.Location = new System.Drawing.Point(4, 25);
            this._0_tabPage7.Name = "_0_tabPage7";
            this._0_tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this._0_tabPage7.Size = new System.Drawing.Size(484, 316);
            this._0_tabPage7.TabIndex = 0;
            this._0_tabPage7.Text = "Offer";
            this._0_tabPage7.UseVisualStyleBackColor = true;
            // 
            // CloseOfEscrow
            // 
            this.CloseOfEscrow.Location = new System.Drawing.Point(17, 41);
            this.CloseOfEscrow.Name = "CloseOfEscrow";
            this.CloseOfEscrow.Size = new System.Drawing.Size(136, 20);
            this.CloseOfEscrow.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(203, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "EMD:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(14, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Close of Escrow:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Emd
            // 
            this.Emd.Location = new System.Drawing.Point(206, 41);
            this.Emd.Name = "Emd";
            this.Emd.Size = new System.Drawing.Size(150, 20);
            this.Emd.TabIndex = 1;
            // 
            // _0_tabPage9
            // 
            this._0_tabPage9.Controls.Add(this.DeleteAttachment);
            this._0_tabPage9.Controls.Add(this.bImportAttachment);
            this._0_tabPage9.Controls.Add(this.label21);
            this._0_tabPage9.Controls.Add(this.Attachments);
            this._0_tabPage9.Controls.Add(this.ShortSaleAddendum);
            this._0_tabPage9.Controls.Add(this.OtherAddendum2);
            this._0_tabPage9.Controls.Add(this.OtherAddendum1);
            this._0_tabPage9.Location = new System.Drawing.Point(4, 25);
            this._0_tabPage9.Name = "_0_tabPage9";
            this._0_tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this._0_tabPage9.Size = new System.Drawing.Size(484, 316);
            this._0_tabPage9.TabIndex = 1;
            this._0_tabPage9.Text = "Attachments and Addendums";
            this._0_tabPage9.UseVisualStyleBackColor = true;
            // 
            // DeleteAttachment
            // 
            this.DeleteAttachment.Location = new System.Drawing.Point(452, 235);
            this.DeleteAttachment.Name = "DeleteAttachment";
            this.DeleteAttachment.Size = new System.Drawing.Size(24, 23);
            this.DeleteAttachment.TabIndex = 5;
            this.DeleteAttachment.Text = "-";
            this.DeleteAttachment.UseVisualStyleBackColor = true;
            this.DeleteAttachment.Click += new System.EventHandler(this.DeleteAttachment_Click);
            // 
            // bImportAttachment
            // 
            this.bImportAttachment.Location = new System.Drawing.Point(422, 235);
            this.bImportAttachment.Name = "bImportAttachment";
            this.bImportAttachment.Size = new System.Drawing.Size(24, 23);
            this.bImportAttachment.TabIndex = 4;
            this.bImportAttachment.Text = "+";
            this.bImportAttachment.UseVisualStyleBackColor = true;
            this.bImportAttachment.Click += new System.EventHandler(this.bImportAttachment_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(3, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Attachments:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Attachments
            // 
            this.Attachments.FormattingEnabled = true;
            this.Attachments.HorizontalScrollbar = true;
            this.Attachments.Location = new System.Drawing.Point(6, 105);
            this.Attachments.Name = "Attachments";
            this.Attachments.Size = new System.Drawing.Size(470, 124);
            this.Attachments.TabIndex = 3;
            // 
            // ShortSaleAddendum
            // 
            this.ShortSaleAddendum.AutoSize = true;
            this.ShortSaleAddendum.Location = new System.Drawing.Point(6, 15);
            this.ShortSaleAddendum.Name = "ShortSaleAddendum";
            this.ShortSaleAddendum.Size = new System.Drawing.Size(129, 17);
            this.ShortSaleAddendum.TabIndex = 0;
            this.ShortSaleAddendum.Text = "Short Sale Addendum";
            this.ShortSaleAddendum.UseVisualStyleBackColor = true;
            // 
            // OtherAddendum2
            // 
            this.OtherAddendum2.AutoSize = true;
            this.OtherAddendum2.Location = new System.Drawing.Point(6, 61);
            this.OtherAddendum2.Name = "OtherAddendum2";
            this.OtherAddendum2.Size = new System.Drawing.Size(112, 17);
            this.OtherAddendum2.TabIndex = 2;
            this.OtherAddendum2.Text = "Other Addendum2";
            this.OtherAddendum2.UseVisualStyleBackColor = true;
            // 
            // OtherAddendum1
            // 
            this.OtherAddendum1.AutoSize = true;
            this.OtherAddendum1.Location = new System.Drawing.Point(6, 38);
            this.OtherAddendum1.Name = "OtherAddendum1";
            this.OtherAddendum1.Size = new System.Drawing.Size(112, 17);
            this.OtherAddendum1.TabIndex = 1;
            this.OtherAddendum1.Text = "Other Addendum1";
            this.OtherAddendum1.UseVisualStyleBackColor = true;
            // 
            // _0_tabPage11
            // 
            this._0_tabPage11.Controls.Add(this.EmailBody);
            this._0_tabPage11.Controls.Add(this.label24);
            this._0_tabPage11.Controls.Add(this.label25);
            this._0_tabPage11.Controls.Add(this.EmailSubject);
            this._0_tabPage11.Controls.Add(this.EmailTemplateProfiles);
            this._0_tabPage11.Location = new System.Drawing.Point(4, 25);
            this._0_tabPage11.Name = "_0_tabPage11";
            this._0_tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this._0_tabPage11.Size = new System.Drawing.Size(484, 316);
            this._0_tabPage11.TabIndex = 2;
            this._0_tabPage11.Text = "Email Template";
            this._0_tabPage11.UseVisualStyleBackColor = true;
            // 
            // EmailBody
            // 
            this.EmailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailBody.Location = new System.Drawing.Point(6, 99);
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(472, 237);
            this.EmailBody.TabIndex = 2;
            this.EmailBody.Text = "";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Body:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Subject:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailSubject
            // 
            this.EmailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailSubject.Location = new System.Drawing.Point(6, 57);
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.Size = new System.Drawing.Size(472, 20);
            this.EmailSubject.TabIndex = 1;
            // 
            // EmailTemplateProfiles
            // 
            this.EmailTemplateProfiles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EmailTemplateProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTemplateProfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailTemplateProfiles.Location = new System.Drawing.Point(3, 3);
            this.EmailTemplateProfiles.Name = "EmailTemplateProfiles";
            this.EmailTemplateProfiles.Size = new System.Drawing.Size(478, 31);
            this.EmailTemplateProfiles.TabIndex = 0;
            // 
            // OfferConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "OfferConfigControl";
            this.Size = new System.Drawing.Size(498, 364);
            this.group_box.ResumeLayout(false);
            this._0_tabControl4.ResumeLayout(false);
            this._0_tabPage7.ResumeLayout(false);
            this._0_tabPage7.PerformLayout();
            this._0_tabPage9.ResumeLayout(false);
            this._0_tabPage9.PerformLayout();
            this._0_tabPage11.ResumeLayout(false);
            this._0_tabPage11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.TabControl _0_tabControl4;
        private System.Windows.Forms.TabPage _0_tabPage7;
        private System.Windows.Forms.DateTimePicker CloseOfEscrow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Emd;
        private System.Windows.Forms.TabPage _0_tabPage9;
        internal System.Windows.Forms.Button DeleteAttachment;
        internal System.Windows.Forms.Button bImportAttachment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckedListBox Attachments;
        private System.Windows.Forms.CheckBox ShortSaleAddendum;
        private System.Windows.Forms.CheckBox OtherAddendum2;
        private System.Windows.Forms.CheckBox OtherAddendum1;
        private System.Windows.Forms.TabPage _0_tabPage11;
        private System.Windows.Forms.RichTextBox EmailBody;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox EmailSubject;
        private PdfMailer2.ProfilesControl EmailTemplateProfiles;
    }
}
