using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksShelf
{
    public partial class BooksShelf : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private BooksStore booksStore = new BooksStore();

        public enum Binding
        {
            Paperback,
            Hardcover,
            Coalwood,
            Unknown
        };

        public BooksShelf()
        {
            InitializeComponent();
        }

        private void btnLoadBooks_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;
                var books = booksStore.LoadBooksFromCvs(filePath);
                for (int i = 0; i < books.Count; i++)
                {
                    bindingSource.Add(books[i]);
                }
                
                // Initialize the DataGridView.
                dataGridView.AutoGenerateColumns = false;
                dataGridView.AutoSize = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.DataSource = bindingSource;

                // Initialize and add a text box column.
                DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
                titleColumn.DataPropertyName = "Title";
                titleColumn.Name = "Title";
                dataGridView.Columns.Add(titleColumn);

                DataGridViewColumn authorColumn = new DataGridViewTextBoxColumn();
                authorColumn.DataPropertyName = "Author";
                authorColumn.Name = "Author";
                dataGridView.Columns.Add(authorColumn);

                DataGridViewColumn priceColumn = new DataGridViewTextBoxColumn();
                priceColumn.DataPropertyName = "Price";
                priceColumn.Name = "Price";
                dataGridView.Columns.Add(priceColumn);

                DataGridViewColumn yearColumn = new DataGridViewTextBoxColumn();
                yearColumn.DataPropertyName = "Year";
                yearColumn.Name = "Year";
                dataGridView.Columns.Add(yearColumn);

                DataGridViewCheckBoxColumn inStockColumn = new DataGridViewCheckBoxColumn();
                inStockColumn.DataPropertyName = "InStock";
                inStockColumn.Name = "InStock";
                dataGridView.Columns.Add(inStockColumn);
               
                dataGridView.Columns.Add(CreateComboBoxWithEnums());

                //DataGridViewButtonColumn descriptionColumn = new DataGridViewButtonColumn();
                //descriptionColumn.Name = "Description";
                //descriptionColumn.HeaderText = "Description";
                //descriptionColumn.UseColumnTextForButtonValue = true;
                //descriptionColumn.Text = "Description";
                //descriptionColumn.Tag = "Description";
                //dataGridView.Columns.Add(descriptionColumn);

                DataGridViewImageColumn descriptionColumn = new DataGridViewImageColumn();
                descriptionColumn.Name = "Description";
                descriptionColumn.HeaderText = "Description";
                descriptionColumn.Image = new Bitmap(SystemIcons.Information.ToBitmap(), 15, 15);
                dataGridView.Columns.Add(descriptionColumn);

                dataGridView.CellClick += DataGridView_CellClick;
                dataGridView.DataError += DataGridView_DataError;
                dataGridView.CellFormatting += DataGridView_CellFormatting;
                this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    var inStockValue = row.Cells["InStock"].Value;

                    if(inStockValue != null)
                    {
                        if (!Boolean.Parse(inStockValue.ToString()))
                        {
                            row.DefaultCellStyle.BackColor = Color.Tomato;
                        }
                    }
                }

                this.AutoSize = true;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Description"].Index)
            {
                var title = dataGridView[0, e.RowIndex].Value.ToString();
                var description = booksStore.getDescription(title);
                MessageBox.Show(description, "Description", MessageBoxButtons.OK);
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        DataGridViewComboBoxColumn CreateComboBoxWithEnums()
        {
            try
            {
                DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
                combo.FlatStyle = FlatStyle.Flat;
                combo.DataPropertyName = "Binding";
                combo.Name = "Binding";
                combo.Items.AddRange("Paperback", "Hardcover", "Coalwood", "Unknown");
                return combo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnDeleteAllBooksNotInStock_Click(object sender, EventArgs e)
        {
            //bindingSource.Clear();
            //var books = booksStore.getBooksOnlyInStock();
            //for (int i = 0; i < books.Count; i++)
            //{
            //    bindingSource.Add(books[i]);
            //}
            //dataGridView.DataSource = bindingSource;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var inStockValue = row.Cells["InStock"].Value;

                if (inStockValue != null)
                {
                    if (!Boolean.Parse(inStockValue.ToString()))
                    {
                        dataGridView.Rows.Remove(row);
                    }
                }
            }
        }
    }
}
