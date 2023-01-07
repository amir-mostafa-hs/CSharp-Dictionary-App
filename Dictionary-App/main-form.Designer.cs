namespace Dictionary_App
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbAddNewWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeleteWord = new System.Windows.Forms.ToolStripButton();
            this.dataGvAllword = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAllword)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNewWord,
            this.toolStripSeparator1,
            this.tsbEditWord,
            this.toolStripSeparator2,
            this.tsbSearchWord,
            this.toolStripSeparator3,
            this.tsbDeleteWord});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(684, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tsbAddNewWord
            // 
            this.tsbAddNewWord.Image = global::Dictionary_App.Properties.Resources.add;
            this.tsbAddNewWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewWord.Name = "tsbAddNewWord";
            this.tsbAddNewWord.Size = new System.Drawing.Size(112, 24);
            this.tsbAddNewWord.Text = "Add New Word";
            this.tsbAddNewWord.Click += new System.EventHandler(this.tsbAddNewWord_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbEditWord
            // 
            this.tsbEditWord.Image = global::Dictionary_App.Properties.Resources.edit;
            this.tsbEditWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditWord.Name = "tsbEditWord";
            this.tsbEditWord.Size = new System.Drawing.Size(83, 24);
            this.tsbEditWord.Text = "Edit Word";
            this.tsbEditWord.Click += new System.EventHandler(this.tsbEditWord_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSearchWord
            // 
            this.tsbSearchWord.Image = global::Dictionary_App.Properties.Resources.search;
            this.tsbSearchWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchWord.Name = "tsbSearchWord";
            this.tsbSearchWord.Size = new System.Drawing.Size(98, 24);
            this.tsbSearchWord.Text = "Search Word";
            this.tsbSearchWord.Click += new System.EventHandler(this.tsbSearchWord_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDeleteWord
            // 
            this.tsbDeleteWord.Image = global::Dictionary_App.Properties.Resources.delete;
            this.tsbDeleteWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteWord.Name = "tsbDeleteWord";
            this.tsbDeleteWord.Size = new System.Drawing.Size(96, 24);
            this.tsbDeleteWord.Text = "Delete Word";
            this.tsbDeleteWord.Click += new System.EventHandler(this.tsbDeleteWord_Click);
            // 
            // dataGvAllword
            // 
            this.dataGvAllword.AllowUserToAddRows = false;
            this.dataGvAllword.AllowUserToDeleteRows = false;
            this.dataGvAllword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvAllword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGvAllword.Location = new System.Drawing.Point(0, 27);
            this.dataGvAllword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGvAllword.Name = "dataGvAllword";
            this.dataGvAllword.ReadOnly = true;
            this.dataGvAllword.RowTemplate.Height = 24;
            this.dataGvAllword.Size = new System.Drawing.Size(684, 434);
            this.dataGvAllword.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dataGvAllword);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary App";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAllword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton tsbAddNewWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSearchWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDeleteWord;
        public System.Windows.Forms.DataGridView dataGvAllword;
    }
}