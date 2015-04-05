namespace SeriesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultSource = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_DefaultDownload = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.lb_filesToMove = new System.Windows.Forms.CheckedListBox();
            this.link_checkAll = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_checklist = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultSource
            // 
            this.defaultSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.defaultSource.Location = new System.Drawing.Point(9, 34);
            this.defaultSource.Name = "defaultSource";
            this.defaultSource.Size = new System.Drawing.Size(136, 38);
            this.defaultSource.TabIndex = 1;
            this.defaultSource.Text = "Change it !";
            this.defaultSource.UseVisualStyleBackColor = false;
            this.defaultSource.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_DefaultDownload
            // 
            this.label_DefaultDownload.AutoSize = true;
            this.label_DefaultDownload.Location = new System.Drawing.Point(26, 3);
            this.label_DefaultDownload.Name = "label_DefaultDownload";
            this.label_DefaultDownload.Size = new System.Drawing.Size(128, 13);
            this.label_DefaultDownload.TabIndex = 2;
            this.label_DefaultDownload.Text = "Current download folder : ";
            // 
            // btn_move
            // 
            this.btn_move.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_move.Location = new System.Drawing.Point(9, 78);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(135, 38);
            this.btn_move.TabIndex = 4;
            this.btn_move.Text = "Move";
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // lb_filesToMove
            // 
            this.lb_filesToMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_filesToMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb_filesToMove.CheckOnClick = true;
            this.lb_filesToMove.FormattingEnabled = true;
            this.lb_filesToMove.HorizontalScrollbar = true;
            this.lb_filesToMove.Location = new System.Drawing.Point(150, 34);
            this.lb_filesToMove.Name = "lb_filesToMove";
            this.lb_filesToMove.Size = new System.Drawing.Size(526, 364);
            this.lb_filesToMove.TabIndex = 5;
            // 
            // link_checkAll
            // 
            this.link_checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.link_checkAll.AutoSize = true;
            this.link_checkAll.Location = new System.Drawing.Point(9, 160);
            this.link_checkAll.Name = "link_checkAll";
            this.link_checkAll.Size = new System.Drawing.Size(52, 13);
            this.link_checkAll.TabIndex = 6;
            this.link_checkAll.TabStop = true;
            this.link_checkAll.Text = "Check All";
            this.link_checkAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_checkAll_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 122);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(135, 23);
            this.progressBar.TabIndex = 7;
            // 
            // label_checklist
            // 
            this.label_checklist.AutoSize = true;
            this.label_checklist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_checklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checklist.Location = new System.Drawing.Point(344, 42);
            this.label_checklist.Name = "label_checklist";
            this.label_checklist.Size = new System.Drawing.Size(130, 20);
            this.label_checklist.TabIndex = 8;
            this.label_checklist.Text = "All is ordered :)";
            this.label_checklist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 439);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label_checklist);
            this.tabPage1.Controls.Add(this.lb_filesToMove);
            this.tabPage1.Controls.Add(this.link_checkAll);
            this.tabPage1.Controls.Add(this.label_DefaultDownload);
            this.tabPage1.Controls.Add(this.btn_move);
            this.tabPage1.Controls.Add(this.defaultSource);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moving";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Add episode name";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Renaming";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 437);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serie Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button defaultSource;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label_DefaultDownload;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.CheckedListBox lb_filesToMove;
        private System.Windows.Forms.LinkLabel link_checkAll;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_checklist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

