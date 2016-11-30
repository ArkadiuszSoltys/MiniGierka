namespace MiniGierka
{
    partial class OknoGry
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGry = new System.Windows.Forms.Panel();
            this.label_Klikajabyzaczac = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.panelGry.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.oAutorachToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(480, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.graToolStripMenuItem.Text = "&Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nowaGraToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nowaGraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.nowaGraToolStripMenuItem.Text = "&Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zakończToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zakończToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zakończToolStripMenuItem.Text = "&Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // oAutorachToolStripMenuItem
            // 
            this.oAutorachToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oAutorachToolStripMenuItem.Name = "oAutorachToolStripMenuItem";
            this.oAutorachToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.oAutorachToolStripMenuItem.Text = "O Autorach...";
            this.oAutorachToolStripMenuItem.Click += new System.EventHandler(this.oAutorachToolStripMenuItem_Click);
            // 
            // panelGry
            // 
            this.panelGry.BackColor = System.Drawing.Color.Transparent;
            this.panelGry.BackgroundImage = global::MiniGierka.Properties.Resources.tlo_1;
            this.panelGry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelGry.Controls.Add(this.label_Klikajabyzaczac);
            this.panelGry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelGry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGry.Location = new System.Drawing.Point(0, 24);
            this.panelGry.Margin = new System.Windows.Forms.Padding(0);
            this.panelGry.Name = "panelGry";
            this.panelGry.Size = new System.Drawing.Size(480, 360);
            this.panelGry.TabIndex = 1;
            this.panelGry.Click += new System.EventHandler(this.panelGry_Click);
            this.panelGry.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGry_Paint);
            // 
            // label_Klikajabyzaczac
            // 
            this.label_Klikajabyzaczac.AutoSize = true;
            this.label_Klikajabyzaczac.Location = new System.Drawing.Point(165, 171);
            this.label_Klikajabyzaczac.Name = "label_Klikajabyzaczac";
            this.label_Klikajabyzaczac.Size = new System.Drawing.Size(190, 13);
            this.label_Klikajabyzaczac.TabIndex = 0;
            this.label_Klikajabyzaczac.Text = "Kliknij tutaj aby rozpocząć grę...";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelGry, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(480, 384);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // OknoGry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(480, 384);
            this.Controls.Add(this.tableLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "OknoGry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGierka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OknoGry_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OknoGry_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelGry.ResumeLayout(false);
            this.panelGry.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorachToolStripMenuItem;
        private System.Windows.Forms.Panel panelGry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label_Klikajabyzaczac;
    }
}