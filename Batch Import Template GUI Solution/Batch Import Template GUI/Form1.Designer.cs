namespace Batch_Import_Template_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbSelectedHpo = new System.Windows.Forms.ListBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.tbSearchInput = new System.Windows.Forms.TextBox();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.colLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1248, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currently Added ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search for HPO Label";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2092, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "Status...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2092, 44);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(71, 36);
            this.File.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1668, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Export as .csv File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1364, 700);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 8;
            // 
            // lbSelectedHpo
            // 
            this.lbSelectedHpo.FormattingEnabled = true;
            this.lbSelectedHpo.ItemHeight = 25;
            this.lbSelectedHpo.Location = new System.Drawing.Point(1254, 237);
            this.lbSelectedHpo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSelectedHpo.Name = "lbSelectedHpo";
            this.lbSelectedHpo.Size = new System.Drawing.Size(762, 929);
            this.lbSelectedHpo.TabIndex = 9;
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(60, 183);
            this.lblSearchResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(158, 25);
            this.lblSearchResults.TabIndex = 11;
            this.lblSearchResults.Text = "Search Results";
            this.lblSearchResults.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbSearchInput
            // 
            this.tbSearchInput.Location = new System.Drawing.Point(66, 106);
            this.tbSearchInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSearchInput.Name = "tbSearchInput";
            this.tbSearchInput.Size = new System.Drawing.Size(630, 31);
            this.tbSearchInput.TabIndex = 12;
            this.tbSearchInput.TextChanged += new System.EventHandler(this.tbSearchInput_TextChanged);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLabel});
            this.listViewResults.GridLines = true;
            this.listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(66, 237);
            this.listViewResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(1092, 929);
            this.listViewResults.TabIndex = 13;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // colLabel
            // 
            this.colLabel.Text = "Label";
            this.colLabel.Width = 666;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2092, 1256);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.tbSearchInput);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.lbSelectedHpo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Batch Import Human Phenotype Ontology Helpr";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbSelectedHpo;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.TextBox tbSearchInput;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader colLabel;
    }
}

