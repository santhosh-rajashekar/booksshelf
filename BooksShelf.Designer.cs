namespace BooksShelf
{
    partial class BooksShelf
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteAllBooksNotInStock = new System.Windows.Forms.Button();
            this.btnLoadBooks = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteAllBooksNotInStock);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadBooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 663);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteAllBooksNotInStock
            // 
            this.btnDeleteAllBooksNotInStock.Location = new System.Drawing.Point(221, 21);
            this.btnDeleteAllBooksNotInStock.Name = "btnDeleteAllBooksNotInStock";
            this.btnDeleteAllBooksNotInStock.Size = new System.Drawing.Size(305, 51);
            this.btnDeleteAllBooksNotInStock.TabIndex = 1;
            this.btnDeleteAllBooksNotInStock.Text = "Delete All Books Not In Stock";
            this.btnDeleteAllBooksNotInStock.UseVisualStyleBackColor = true;
            this.btnDeleteAllBooksNotInStock.Click += new System.EventHandler(this.btnDeleteAllBooksNotInStock_Click);
            // 
            // btnLoadBooks
            // 
            this.btnLoadBooks.Location = new System.Drawing.Point(22, 21);
            this.btnLoadBooks.Name = "btnLoadBooks";
            this.btnLoadBooks.Size = new System.Drawing.Size(171, 51);
            this.btnLoadBooks.TabIndex = 0;
            this.btnLoadBooks.Text = "Load Books";
            this.btnLoadBooks.UseVisualStyleBackColor = true;
            this.btnLoadBooks.Click += new System.EventHandler(this.btnLoadBooks_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1089, 568);
            this.dataGridView.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "selectBooksFileDialog";
            this.openFileDialog.Filter = "\"Csv Files|*.csv|All files|*.*\"";
            this.openFileDialog.InitialDirectory = "%DOCUMENTS%";
            // 
            // BooksShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 663);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BooksShelf";
            this.Text = "BooksShelf";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDeleteAllBooksNotInStock;
        private System.Windows.Forms.Button btnLoadBooks;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

