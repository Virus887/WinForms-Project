namespace DamianBisWinFormsTask
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Bitmapa = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddFurniture = new System.Windows.Forms.GroupBox();
            this.FurnituresFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.kitchen_table = new System.Windows.Forms.Button();
            this.double_bed = new System.Windows.Forms.Button();
            this.sofa = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.wall = new System.Windows.Forms.Button();
            this.CreatedFurniture = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlueprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.LanuagePolish = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bitmapa)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.AddFurniture.SuspendLayout();
            this.FurnituresFlowLayout.SuspendLayout();
            this.CreatedFurniture.SuspendLayout();
            this.MainLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.Bitmapa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightPanel);
            this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // Bitmapa
            // 
            resources.ApplyResources(this.Bitmapa, "Bitmapa");
            this.Bitmapa.Name = "Bitmapa";
            this.Bitmapa.TabStop = false;
            this.Bitmapa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.Bitmapa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bitmapa_MouseMove);
            // 
            // RightPanel
            // 
            resources.ApplyResources(this.RightPanel, "RightPanel");
            this.RightPanel.Controls.Add(this.AddFurniture, 0, 0);
            this.RightPanel.Controls.Add(this.CreatedFurniture, 0, 1);
            this.RightPanel.Name = "RightPanel";
            // 
            // AddFurniture
            // 
            this.AddFurniture.Controls.Add(this.FurnituresFlowLayout);
            resources.ApplyResources(this.AddFurniture, "AddFurniture");
            this.AddFurniture.Name = "AddFurniture";
            this.AddFurniture.TabStop = false;
            // 
            // FurnituresFlowLayout
            // 
            resources.ApplyResources(this.FurnituresFlowLayout, "FurnituresFlowLayout");
            this.FurnituresFlowLayout.Controls.Add(this.kitchen_table);
            this.FurnituresFlowLayout.Controls.Add(this.double_bed);
            this.FurnituresFlowLayout.Controls.Add(this.sofa);
            this.FurnituresFlowLayout.Controls.Add(this.table);
            this.FurnituresFlowLayout.Controls.Add(this.wall);
            this.FurnituresFlowLayout.Name = "FurnituresFlowLayout";
            // 
            // kitchen_table
            // 
            this.kitchen_table.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kitchen_table.BackgroundImage = global::DamianBisWinFormsTask.Properties.Resources.coffee_table;
            resources.ApplyResources(this.kitchen_table, "kitchen_table");
            this.kitchen_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchen_table.Name = "kitchen_table";
            this.kitchen_table.UseVisualStyleBackColor = false;
            // 
            // double_bed
            // 
            this.double_bed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.double_bed.BackgroundImage = global::DamianBisWinFormsTask.Properties.Resources.double_bed;
            resources.ApplyResources(this.double_bed, "double_bed");
            this.double_bed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.double_bed.Name = "double_bed";
            this.double_bed.UseVisualStyleBackColor = false;
            // 
            // sofa
            // 
            this.sofa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sofa.BackgroundImage = global::DamianBisWinFormsTask.Properties.Resources.sofa;
            resources.ApplyResources(this.sofa, "sofa");
            this.sofa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sofa.Name = "sofa";
            this.sofa.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table.BackgroundImage = global::DamianBisWinFormsTask.Properties.Resources.table;
            resources.ApplyResources(this.table, "table");
            this.table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table.Name = "table";
            this.table.UseVisualStyleBackColor = false;
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wall.BackgroundImage = global::DamianBisWinFormsTask.Properties.Resources.wall;
            resources.ApplyResources(this.wall, "wall");
            this.wall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wall.Name = "wall";
            this.wall.UseVisualStyleBackColor = false;
            // 
            // CreatedFurniture
            // 
            this.CreatedFurniture.Controls.Add(this.ListBox);
            resources.ApplyResources(this.CreatedFurniture, "CreatedFurniture");
            this.CreatedFurniture.Name = "CreatedFurniture";
            this.CreatedFurniture.TabStop = false;
            // 
            // ListBox
            // 
            resources.ApplyResources(this.ListBox, "ListBox");
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Name = "ListBox";
            // 
            // MainLayoutPanel
            // 
            resources.ApplyResources(this.MainLayoutPanel, "MainLayoutPanel");
            this.MainLayoutPanel.Controls.Add(this.splitContainer1, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBlueprintToolStripMenuItem,
            this.OpenSchema,
            this.SaveSchema,
            this.Language});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newBlueprintToolStripMenuItem
            // 
            this.newBlueprintToolStripMenuItem.Name = "newBlueprintToolStripMenuItem";
            resources.ApplyResources(this.newBlueprintToolStripMenuItem, "newBlueprintToolStripMenuItem");
            this.newBlueprintToolStripMenuItem.Click += new System.EventHandler(this.newBlueprintToolStripMenuItem_Click);
            // 
            // OpenSchema
            // 
            this.OpenSchema.Name = "OpenSchema";
            resources.ApplyResources(this.OpenSchema, "OpenSchema");
            this.OpenSchema.Click += new System.EventHandler(this.OpenSchema_Click);
            // 
            // SaveSchema
            // 
            this.SaveSchema.Name = "SaveSchema";
            resources.ApplyResources(this.SaveSchema, "SaveSchema");
            this.SaveSchema.Click += new System.EventHandler(this.SaveSchema_Click);
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanuagePolish,
            this.LanguageEnglish});
            this.Language.Name = "Language";
            resources.ApplyResources(this.Language, "Language");
            // 
            // LanuagePolish
            // 
            this.LanuagePolish.Name = "LanuagePolish";
            resources.ApplyResources(this.LanuagePolish, "LanuagePolish");
            this.LanuagePolish.Click += new System.EventHandler(this.LanuagePolish_Click);
            // 
            // LanguageEnglish
            // 
            this.LanguageEnglish.Name = "LanguageEnglish";
            resources.ApplyResources(this.LanguageEnglish, "LanguageEnglish");
            this.LanguageEnglish.Click += new System.EventHandler(this.LanguageEnglish_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutPanel);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bitmapa)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.AddFurniture.ResumeLayout(false);
            this.FurnituresFlowLayout.ResumeLayout(false);
            this.CreatedFurniture.ResumeLayout(false);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox Bitmapa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBlueprintToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel RightPanel;
        private System.Windows.Forms.GroupBox AddFurniture;
        private System.Windows.Forms.FlowLayoutPanel FurnituresFlowLayout;
        private System.Windows.Forms.Button kitchen_table;
        private System.Windows.Forms.Button double_bed;
        private System.Windows.Forms.Button sofa;
        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button wall;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ToolStripMenuItem OpenSchema;
        private System.Windows.Forms.ToolStripMenuItem SaveSchema;
        private System.Windows.Forms.GroupBox CreatedFurniture;
        private System.Windows.Forms.ToolStripMenuItem Language;
        private System.Windows.Forms.ToolStripMenuItem LanuagePolish;
        private System.Windows.Forms.ToolStripMenuItem LanguageEnglish;
    }
}

