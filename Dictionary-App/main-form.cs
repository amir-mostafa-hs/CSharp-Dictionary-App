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
        public mainForm()
        {
            InitializeComponent();
        }
        private void tsbAddNewWord_Click(object sender, EventArgs e)
        {
            add_word_form addWordFrm = new add_word_form();
            addWordFrm.ShowDialog();
        }

        private void tsbEditWord_Click(object sender, EventArgs e)
        {
            edit_word_form editWordFrm = new edit_word_form();
            var selectedWordData = dataGvAllword.CurrentRow.Cells;

            editWordFrm.txtWord.Text = selectedWordData[1].Value.ToString();
            editWordFrm.txtPersianTranslate.Text = selectedWordData[2].Value.ToString();
            editWordFrm.txtArabicTranslate.Text = selectedWordData[3].Value.ToString();
            editWordFrm.txtPronounce.Text = selectedWordData[4].Value.ToString();
            editWordFrm.txtDescriptions.Text = selectedWordData[6].Value.ToString();

            if (selectedWordData[5].Value != null)
            {
                editWordFrm.picBoxPronounce.Image = Image.FromFile(selectedWordData[5].Value.ToString());
            }

            editWordFrm.ShowDialog();
        }

        private void tsbSearchWord_Click(object sender, EventArgs e)
        {
            search_word_form searchWordFrm = new search_word_form();
            searchWordFrm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();
            dataGvAllword.DataSource = wordDatabase.WordsTables;
        }

        private void tsbDeleteWord_Click(object sender, EventArgs e)
        {
            var selectedWordData = dataGvAllword.CurrentRow.Cells;
            DialogResult isDeleteWord = MessageBox.Show("Are you sure you want to delete the *(" + selectedWordData[1].Value + ")* with ID *(" + selectedWordData[0].Value + ")* ?", "Delete word data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isDeleteWord == DialogResult.Yes)
            {
                dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();

                wordDatabase.WordsTables.DeleteOnSubmit((from WordsTable in wordDatabase.WordsTables
                                                         where WordsTable.WordId == (int)selectedWordData[0].Value
                                                         select WordsTable).Single());
                wordDatabase.SubmitChanges();
                dataGvAllword.DataSource = wordDatabase.WordsTables;
            }
        }
    }
}
