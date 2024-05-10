namespace DHL
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.newShippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippingmenustrip = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachtxtbox = new System.Windows.Forms.TextBox();
            this.refNolbl = new System.Windows.Forms.Label();
            this.Refnumtxtbox = new System.Windows.Forms.TextBox();
            this.shippernamelbl = new System.Windows.Forms.Label();
            this.shippernametxtbox = new System.Windows.Forms.TextBox();
            this.pckglbl = new System.Windows.Forms.Label();
            this.enveloperadiobtn = new System.Windows.Forms.RadioButton();
            this.boxradiobtn = new System.Windows.Forms.RadioButton();
            this.pckgweightlbl = new System.Windows.Forms.Label();
            this.pckgweightnumUD = new System.Windows.Forms.NumericUpDown();
            this.gmlbl = new System.Windows.Forms.Label();
            this.shipperadresslbl = new System.Windows.Forms.Label();
            this.shipperaddytxtbox = new System.Windows.Forms.TextBox();
            this.detailsgroupbox = new System.Windows.Forms.GroupBox();
            this.nametxtbox2 = new System.Windows.Forms.TextBox();
            this.namettbox2 = new System.Windows.Forms.Label();
            this.naetxtbox = new System.Windows.Forms.TextBox();
            this.nametxtbox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.destlbl = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.shippingmenustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckgweightnumUD)).BeginInit();
            this.detailsgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newShippingToolStripMenuItem
            // 
            this.newShippingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newShippingToolStripMenuItem.Image")));
            this.newShippingToolStripMenuItem.Name = "newShippingToolStripMenuItem";
            this.newShippingToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.newShippingToolStripMenuItem.Text = "New Shipping";
            this.newShippingToolStripMenuItem.Click += new System.EventHandler(this.newShippingToolStripMenuItem_Click);
            // 
            // updateExistingToolStripMenuItem
            // 
            this.updateExistingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateExistingToolStripMenuItem.Image")));
            this.updateExistingToolStripMenuItem.Name = "updateExistingToolStripMenuItem";
            this.updateExistingToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.updateExistingToolStripMenuItem.Text = "Update Existing";
            this.updateExistingToolStripMenuItem.Click += new System.EventHandler(this.updateExistingToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteRecordToolStripMenuItem.Image")));
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // shippingmenustrip
            // 
            this.shippingmenustrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.shippingmenustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.shippingmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newShippingToolStripMenuItem,
            this.updateExistingToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.shippingmenustrip.Location = new System.Drawing.Point(0, 0);
            this.shippingmenustrip.Name = "shippingmenustrip";
            this.shippingmenustrip.Size = new System.Drawing.Size(153, 450);
            this.shippingmenustrip.TabIndex = 0;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // seachtxtbox
            // 
            this.seachtxtbox.Location = new System.Drawing.Point(23, 102);
            this.seachtxtbox.Name = "seachtxtbox";
            this.seachtxtbox.Size = new System.Drawing.Size(100, 24);
            this.seachtxtbox.TabIndex = 1;
            this.seachtxtbox.TextChanged += new System.EventHandler(this.seachtxtbox_TextChanged);
            // 
            // refNolbl
            // 
            this.refNolbl.AutoSize = true;
            this.refNolbl.Location = new System.Drawing.Point(182, 21);
            this.refNolbl.Name = "refNolbl";
            this.refNolbl.Size = new System.Drawing.Size(85, 17);
            this.refNolbl.TabIndex = 2;
            this.refNolbl.Text = "Ref. Number";
            this.refNolbl.Click += new System.EventHandler(this.refNolbl_Click);
            // 
            // Refnumtxtbox
            // 
            this.Refnumtxtbox.Location = new System.Drawing.Point(304, 21);
            this.Refnumtxtbox.Name = "Refnumtxtbox";
            this.Refnumtxtbox.Size = new System.Drawing.Size(100, 24);
            this.Refnumtxtbox.TabIndex = 3;
            this.Refnumtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shippernamelbl
            // 
            this.shippernamelbl.AutoSize = true;
            this.shippernamelbl.Location = new System.Drawing.Point(183, 60);
            this.shippernamelbl.Name = "shippernamelbl";
            this.shippernamelbl.Size = new System.Drawing.Size(93, 17);
            this.shippernamelbl.TabIndex = 4;
            this.shippernamelbl.Text = "Shipper Name";
            // 
            // shippernametxtbox
            // 
            this.shippernametxtbox.Location = new System.Drawing.Point(304, 60);
            this.shippernametxtbox.Name = "shippernametxtbox";
            this.shippernametxtbox.Size = new System.Drawing.Size(197, 24);
            this.shippernametxtbox.TabIndex = 5;
            this.shippernametxtbox.TextChanged += new System.EventHandler(this.shippernametxtbox_TextChanged);
            // 
            // pckglbl
            // 
            this.pckglbl.AutoSize = true;
            this.pckglbl.Location = new System.Drawing.Point(182, 102);
            this.pckglbl.Name = "pckglbl";
            this.pckglbl.Size = new System.Drawing.Size(94, 17);
            this.pckglbl.TabIndex = 6;
            this.pckglbl.Text = "Package Type";
            // 
            // enveloperadiobtn
            // 
            this.enveloperadiobtn.AutoSize = true;
            this.enveloperadiobtn.Location = new System.Drawing.Point(304, 100);
            this.enveloperadiobtn.Name = "enveloperadiobtn";
            this.enveloperadiobtn.Size = new System.Drawing.Size(85, 21);
            this.enveloperadiobtn.TabIndex = 7;
            this.enveloperadiobtn.Text = "Envelope";
            this.enveloperadiobtn.UseVisualStyleBackColor = true;
            this.enveloperadiobtn.CheckedChanged += new System.EventHandler(this.enveloperadiobtn_CheckedChanged);
            // 
            // boxradiobtn
            // 
            this.boxradiobtn.AutoSize = true;
            this.boxradiobtn.Checked = true;
            this.boxradiobtn.Location = new System.Drawing.Point(405, 100);
            this.boxradiobtn.Name = "boxradiobtn";
            this.boxradiobtn.Size = new System.Drawing.Size(53, 21);
            this.boxradiobtn.TabIndex = 8;
            this.boxradiobtn.TabStop = true;
            this.boxradiobtn.Text = "Box";
            this.boxradiobtn.UseVisualStyleBackColor = true;
            this.boxradiobtn.CheckedChanged += new System.EventHandler(this.boxradiobtn_CheckedChanged);
            // 
            // pckgweightlbl
            // 
            this.pckgweightlbl.AutoSize = true;
            this.pckgweightlbl.Location = new System.Drawing.Point(181, 139);
            this.pckgweightlbl.Name = "pckgweightlbl";
            this.pckgweightlbl.Size = new System.Drawing.Size(107, 17);
            this.pckgweightlbl.TabIndex = 9;
            this.pckgweightlbl.Text = "Package Weight";
            // 
            // pckgweightnumUD
            // 
            this.pckgweightnumUD.Location = new System.Drawing.Point(304, 137);
            this.pckgweightnumUD.Name = "pckgweightnumUD";
            this.pckgweightnumUD.Size = new System.Drawing.Size(120, 24);
            this.pckgweightnumUD.TabIndex = 10;
            this.pckgweightnumUD.ValueChanged += new System.EventHandler(this.pckgweightnumUD_ValueChanged);
            // 
            // gmlbl
            // 
            this.gmlbl.AutoSize = true;
            this.gmlbl.Location = new System.Drawing.Point(430, 144);
            this.gmlbl.Name = "gmlbl";
            this.gmlbl.Size = new System.Drawing.Size(28, 17);
            this.gmlbl.TabIndex = 11;
            this.gmlbl.Text = "gm";
            this.gmlbl.Click += new System.EventHandler(this.gmlbl_Click);
            // 
            // shipperadresslbl
            // 
            this.shipperadresslbl.AutoSize = true;
            this.shipperadresslbl.Location = new System.Drawing.Point(183, 178);
            this.shipperadresslbl.Name = "shipperadresslbl";
            this.shipperadresslbl.Size = new System.Drawing.Size(106, 17);
            this.shipperadresslbl.TabIndex = 12;
            this.shipperadresslbl.Text = "Shipper Address";
            // 
            // shipperaddytxtbox
            // 
            this.shipperaddytxtbox.Location = new System.Drawing.Point(304, 178);
            this.shipperaddytxtbox.Multiline = true;
            this.shipperaddytxtbox.Name = "shipperaddytxtbox";
            this.shipperaddytxtbox.Size = new System.Drawing.Size(184, 84);
            this.shipperaddytxtbox.TabIndex = 13;
            this.shipperaddytxtbox.TextChanged += new System.EventHandler(this.shipperaddytxtbox_TextChanged);
            // 
            // detailsgroupbox
            // 
            this.detailsgroupbox.Controls.Add(this.nametxtbox2);
            this.detailsgroupbox.Controls.Add(this.namettbox2);
            this.detailsgroupbox.Controls.Add(this.naetxtbox);
            this.detailsgroupbox.Controls.Add(this.nametxtbox);
            this.detailsgroupbox.Controls.Add(this.comboBox1);
            this.detailsgroupbox.Controls.Add(this.destlbl);
            this.detailsgroupbox.Location = new System.Drawing.Point(184, 279);
            this.detailsgroupbox.Name = "detailsgroupbox";
            this.detailsgroupbox.Size = new System.Drawing.Size(374, 146);
            this.detailsgroupbox.TabIndex = 14;
            this.detailsgroupbox.TabStop = false;
            this.detailsgroupbox.Text = "Consinee Details";
            // 
            // nametxtbox2
            // 
            this.nametxtbox2.Location = new System.Drawing.Point(168, 87);
            this.nametxtbox2.Name = "nametxtbox2";
            this.nametxtbox2.Size = new System.Drawing.Size(165, 24);
            this.nametxtbox2.TabIndex = 18;
            this.nametxtbox2.TextChanged += new System.EventHandler(this.nametxtbox2_TextChanged);
            // 
            // namettbox2
            // 
            this.namettbox2.AutoSize = true;
            this.namettbox2.Location = new System.Drawing.Point(6, 87);
            this.namettbox2.Name = "namettbox2";
            this.namettbox2.Size = new System.Drawing.Size(110, 17);
            this.namettbox2.TabIndex = 17;
            this.namettbox2.Text = "Consignee Name";
            // 
            // naetxtbox
            // 
            this.naetxtbox.Location = new System.Drawing.Point(168, 49);
            this.naetxtbox.Name = "naetxtbox";
            this.naetxtbox.Size = new System.Drawing.Size(165, 24);
            this.naetxtbox.TabIndex = 16;
            this.naetxtbox.TextChanged += new System.EventHandler(this.naetxtbox_TextChanged);
            // 
            // nametxtbox
            // 
            this.nametxtbox.AutoSize = true;
            this.nametxtbox.Location = new System.Drawing.Point(6, 56);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(110, 17);
            this.nametxtbox.TabIndex = 15;
            this.nametxtbox.Text = "Consignee Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jordan",
            "South Korea",
            "USA",
            "KSA",
            "UAE",
            "Mexico",
            "France",
            "UK"});
            this.comboBox1.Location = new System.Drawing.Point(168, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // destlbl
            // 
            this.destlbl.AutoSize = true;
            this.destlbl.Location = new System.Drawing.Point(-1, 24);
            this.destlbl.Name = "destlbl";
            this.destlbl.Size = new System.Drawing.Size(141, 17);
            this.destlbl.TabIndex = 13;
            this.destlbl.Text = "Destination (Country)";
            this.destlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(23, 132);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 15;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.detailsgroupbox);
            this.Controls.Add(this.shipperaddytxtbox);
            this.Controls.Add(this.shipperadresslbl);
            this.Controls.Add(this.gmlbl);
            this.Controls.Add(this.pckgweightnumUD);
            this.Controls.Add(this.pckgweightlbl);
            this.Controls.Add(this.boxradiobtn);
            this.Controls.Add(this.enveloperadiobtn);
            this.Controls.Add(this.pckglbl);
            this.Controls.Add(this.shippernametxtbox);
            this.Controls.Add(this.shippernamelbl);
            this.Controls.Add(this.Refnumtxtbox);
            this.Controls.Add(this.refNolbl);
            this.Controls.Add(this.seachtxtbox);
            this.Controls.Add(this.shippingmenustrip);
            this.MainMenuStrip = this.shippingmenustrip;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.shippingmenustrip.ResumeLayout(false);
            this.shippingmenustrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckgweightnumUD)).EndInit();
            this.detailsgroupbox.ResumeLayout(false);
            this.detailsgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem newShippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.MenuStrip shippingmenustrip;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.TextBox seachtxtbox;
        private System.Windows.Forms.Label refNolbl;
        private System.Windows.Forms.TextBox Refnumtxtbox;
        private System.Windows.Forms.Label shippernamelbl;
        private System.Windows.Forms.TextBox shippernametxtbox;
        private System.Windows.Forms.Label pckglbl;
        private System.Windows.Forms.RadioButton enveloperadiobtn;
        private System.Windows.Forms.RadioButton boxradiobtn;
        private System.Windows.Forms.Label pckgweightlbl;
        private System.Windows.Forms.NumericUpDown pckgweightnumUD;
        private System.Windows.Forms.Label gmlbl;
        private System.Windows.Forms.Label shipperadresslbl;
        private System.Windows.Forms.TextBox shipperaddytxtbox;
        private System.Windows.Forms.GroupBox detailsgroupbox;
        private System.Windows.Forms.Label destlbl;
        private System.Windows.Forms.TextBox nametxtbox2;
        private System.Windows.Forms.Label namettbox2;
        private System.Windows.Forms.TextBox naetxtbox;
        private System.Windows.Forms.Label nametxtbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchbtn;
    }
}