﻿namespace Z.Tools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.rPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tipL = new System.Windows.Forms.Label();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.msgLB = new System.Windows.Forms.ListBox();
            this.isBackUp = new System.Windows.Forms.CheckBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.rPLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rPMenuItem,
            this.noneMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(782, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "菜单";
            // 
            // rPMenuItem
            // 
            this.rPMenuItem.Name = "rPMenuItem";
            this.rPMenuItem.Size = new System.Drawing.Size(68, 24);
            this.rPMenuItem.Text = "去括号";
            this.rPMenuItem.Click += new System.EventHandler(this.rPMenuItem_Click);
            // 
            // noneMenuItem
            // 
            this.noneMenuItem.Name = "noneMenuItem";
            this.noneMenuItem.Size = new System.Drawing.Size(60, 24);
            this.noneMenuItem.Text = "none";
            this.noneMenuItem.Click += new System.EventHandler(this.noneMenuItem_Click);
            // 
            // rPLayoutPanel
            // 
            this.rPLayoutPanel.ColumnCount = 4;
            this.rPLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.44118F));
            this.rPLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.55882F));
            this.rPLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rPLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.rPLayoutPanel.Controls.Add(this.tipL, 0, 0);
            this.rPLayoutPanel.Controls.Add(this.pathTB, 1, 0);
            this.rPLayoutPanel.Controls.Add(this.selectFileBtn, 2, 0);
            this.rPLayoutPanel.Controls.Add(this.msgLB, 0, 1);
            this.rPLayoutPanel.Controls.Add(this.isBackUp, 2, 2);
            this.rPLayoutPanel.Controls.Add(this.changeBtn, 2, 3);
            this.rPLayoutPanel.Controls.Add(this.clearBtn, 2, 4);
            this.rPLayoutPanel.Controls.Add(this.selectFolderBtn, 3, 0);
            this.rPLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.rPLayoutPanel.Name = "rPLayoutPanel";
            this.rPLayoutPanel.RowCount = 6;
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rPLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.rPLayoutPanel.Size = new System.Drawing.Size(782, 425);
            this.rPLayoutPanel.TabIndex = 1;
            // 
            // tipL
            // 
            this.tipL.AutoSize = true;
            this.tipL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipL.Location = new System.Drawing.Point(3, 0);
            this.tipL.Name = "tipL";
            this.tipL.Size = new System.Drawing.Size(83, 30);
            this.tipL.TabIndex = 1;
            this.tipL.Text = "文件位置:";
            this.tipL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathTB
            // 
            this.pathTB.AllowDrop = true;
            this.pathTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTB.Location = new System.Drawing.Point(92, 3);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(482, 25);
            this.pathTB.TabIndex = 3;
            this.pathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.pathTB_DragDrop);
            this.pathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.pathTB_DragEnter);
            this.pathTB.Enter += new System.EventHandler(this.pathTB_Enter);
            this.pathTB.Leave += new System.EventHandler(this.pathTB_Leave);
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFileBtn.Location = new System.Drawing.Point(580, 3);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(94, 24);
            this.selectFileBtn.TabIndex = 2;
            this.selectFileBtn.Text = "选择文件";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // msgLB
            // 
            this.rPLayoutPanel.SetColumnSpan(this.msgLB, 2);
            this.msgLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgLB.FormattingEnabled = true;
            this.msgLB.ItemHeight = 15;
            this.msgLB.Location = new System.Drawing.Point(3, 33);
            this.msgLB.Name = "msgLB";
            this.rPLayoutPanel.SetRowSpan(this.msgLB, 5);
            this.msgLB.Size = new System.Drawing.Size(571, 389);
            this.msgLB.TabIndex = 3;
            // 
            // isBackUp
            // 
            this.isBackUp.AutoSize = true;
            this.rPLayoutPanel.SetColumnSpan(this.isBackUp, 2);
            this.isBackUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isBackUp.Location = new System.Drawing.Point(584, 103);
            this.isBackUp.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.isBackUp.Name = "isBackUp";
            this.isBackUp.Size = new System.Drawing.Size(195, 24);
            this.isBackUp.TabIndex = 4;
            this.isBackUp.Text = "对原文件备份";
            this.isBackUp.UseVisualStyleBackColor = true;
            // 
            // changeBtn
            // 
            this.rPLayoutPanel.SetColumnSpan(this.changeBtn, 2);
            this.changeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeBtn.Enabled = false;
            this.changeBtn.Location = new System.Drawing.Point(580, 133);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(199, 24);
            this.changeBtn.TabIndex = 5;
            this.changeBtn.Text = "修改";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // clearBtn
            // 
            this.rPLayoutPanel.SetColumnSpan(this.clearBtn, 2);
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Location = new System.Drawing.Point(580, 163);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(199, 24);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFolderBtn.Location = new System.Drawing.Point(680, 3);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(99, 24);
            this.selectFolderBtn.TabIndex = 7;
            this.selectFolderBtn.Text = "选择文件夹";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.rPLayoutPanel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.rPLayoutPanel.ResumeLayout(false);
            this.rPLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem rPMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneMenuItem;
        private System.Windows.Forms.TableLayoutPanel rPLayoutPanel;
        private System.Windows.Forms.Label tipL;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.ListBox msgLB;
        private System.Windows.Forms.CheckBox isBackUp;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button selectFolderBtn;
    }
}

