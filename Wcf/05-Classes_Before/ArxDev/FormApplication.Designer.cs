﻿namespace ArxDev
{
    partial class FormApplication
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.applicationStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAoo = new System.Windows.Forms.TabPage();
            this.buttonAooForArchivePa = new System.Windows.Forms.Button();
            this.buttonAooForArchive = new System.Windows.Forms.Button();
            this.buttonAooForSearch = new System.Windows.Forms.Button();
            this.dgAoo = new System.Windows.Forms.DataGridView();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAoo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(783, 439);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // applicationStrip
            // 
            this.applicationStrip.Name = "applicationStrip";
            this.applicationStrip.Size = new System.Drawing.Size(39, 17);
            this.applicationStrip.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAoo);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 421);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAoo
            // 
            this.tabPageAoo.Controls.Add(this.buttonAooForArchivePa);
            this.tabPageAoo.Controls.Add(this.buttonAooForArchive);
            this.tabPageAoo.Controls.Add(this.buttonAooForSearch);
            this.tabPageAoo.Controls.Add(this.dgAoo);
            this.tabPageAoo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAoo.Name = "tabPageAoo";
            this.tabPageAoo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAoo.Size = new System.Drawing.Size(838, 395);
            this.tabPageAoo.TabIndex = 1;
            this.tabPageAoo.Text = "Aoo";
            this.tabPageAoo.UseVisualStyleBackColor = true;
            // 
            // buttonAooForArchivePa
            // 
            this.buttonAooForArchivePa.Location = new System.Drawing.Point(6, 64);
            this.buttonAooForArchivePa.Name = "buttonAooForArchivePa";
            this.buttonAooForArchivePa.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForArchivePa.TabIndex = 3;
            this.buttonAooForArchivePa.Text = "Get Aoo for Archive Pa ";
            this.buttonAooForArchivePa.UseVisualStyleBackColor = true;
            this.buttonAooForArchivePa.Click += new System.EventHandler(this.buttonAooForArchivePa_Click);
            // 
            // buttonAooForArchive
            // 
            this.buttonAooForArchive.Location = new System.Drawing.Point(6, 35);
            this.buttonAooForArchive.Name = "buttonAooForArchive";
            this.buttonAooForArchive.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForArchive.TabIndex = 2;
            this.buttonAooForArchive.Text = "Get Aoo for Archive";
            this.buttonAooForArchive.UseVisualStyleBackColor = true;
            this.buttonAooForArchive.Click += new System.EventHandler(this.buttonAooForArchive_Click);
            // 
            // buttonAooForSearch
            // 
            this.buttonAooForSearch.Location = new System.Drawing.Point(6, 6);
            this.buttonAooForSearch.Name = "buttonAooForSearch";
            this.buttonAooForSearch.Size = new System.Drawing.Size(170, 23);
            this.buttonAooForSearch.TabIndex = 1;
            this.buttonAooForSearch.Text = "Get Aoo for Search";
            this.buttonAooForSearch.UseVisualStyleBackColor = true;
            this.buttonAooForSearch.Click += new System.EventHandler(this.buttonAooForSearch_Click);
            // 
            // dgAoo
            // 
            this.dgAoo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAoo.Location = new System.Drawing.Point(182, 6);
            this.dgAoo.Name = "dgAoo";
            this.dgAoo.Size = new System.Drawing.Size(650, 383);
            this.dgAoo.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(838, 395);
            this.tabPageClasses.TabIndex = 2;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAoo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel applicationStrip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAoo;
        private System.Windows.Forms.Button buttonAooForArchivePa;
        private System.Windows.Forms.Button buttonAooForArchive;
        private System.Windows.Forms.Button buttonAooForSearch;
        private System.Windows.Forms.DataGridView dgAoo;
        private System.Windows.Forms.TabPage tabPageClasses;
    }
}