namespace DHL
{
    partial class SearchResult
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
            this.searchDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDGV
            // 
            this.searchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDGV.Location = new System.Drawing.Point(-2, 0);
            this.searchDGV.Name = "searchDGV";
            this.searchDGV.RowHeadersWidth = 51;
            this.searchDGV.RowTemplate.Height = 26;
            this.searchDGV.Size = new System.Drawing.Size(804, 456);
            this.searchDGV.TabIndex = 0;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchDGV);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            this.Load += new System.EventHandler(this.SearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchDGV;
    }
}