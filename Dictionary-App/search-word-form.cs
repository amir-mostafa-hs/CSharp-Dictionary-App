using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_App
{
    public partial class search_word_form : Form
    {
        public search_word_form()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();

            if (txtSearchWord.Text != "" || txtSearchPersian.Text != "" || txtSearchArabic.Text != "")
            {
                dataGvSearch.DataSource = from WordsTable in wordDatabase.WordsTables
                                          where WordsTable.Word == txtSearchWord.Text
                                          || WordsTable.PersianTranslate == txtSearchPersian.Text
                                          || WordsTable.ArabicTranslate == txtSearchArabic.Text
                                          select WordsTable;
            }
            else
            {
                MessageBox.Show("All inputs are empty!\nPlease enter one of the requested values to search", "Inputs are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
