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
    public partial class mainForm : Form
    {
        dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();
        WordsTable wordTable = new WordsTable();
        public mainForm()
        {
            InitializeComponent();
        }

        private void tsbAddNewWord_Click(object sender, EventArgs e)
        {
            Form addWordFrm = new add_word_form();
            addWordFrm.ShowDialog();
        }

        private void tsbEditWord_Click(object sender, EventArgs e)
        {
            Form editWordFrm = new edit_word_form();
            editWordFrm.ShowDialog();
        }

        private void tsbSearchWord_Click(object sender, EventArgs e)
        {
            Form searchWordFrm = new search_word_form();
            searchWordFrm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dataGvAllword.DataSource = wordDatabase.WordsTables;
        }
    }
}
