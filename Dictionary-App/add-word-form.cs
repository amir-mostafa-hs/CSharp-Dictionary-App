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
    public partial class add_word_form : Form
    {
        public add_word_form()
        {
            InitializeComponent();
        }

        private void btnSubmitWord_Click(object sender, EventArgs e)
        {
            DialogResult isAddWord =  MessageBox.Show("Are you sure to add this data?","submit new word data",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (isAddWord == DialogResult.Yes)
            {
                dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();
                WordsTable wordTable = new WordsTable();

                wordTable.Word = txtWord.Text;
                wordTable.PersianTranslate = txtPersianTranslate.Text;
                wordTable.ArabicTranslate = txtArabicTranslate.Text;
                wordTable.Pronounce = txtPronounce.Text;
                wordTable.Descriptions = txtDescriptions.Text;

                if (openFileDialogImage.FileName != "openFileDialog1")
                {
                    wordTable.PronounceImage = openFileDialogImage.FileName;
                }
                else
                {
                    wordTable.PronounceImage = null;
                }

                try
                {
                    wordDatabase.WordsTables.InsertOnSubmit(wordTable);
                    wordDatabase.SubmitChanges();
                    MessageBox.Show("Add new word is successfully", "Adding word result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtWord.Text = "";
                    txtPersianTranslate.Text = "";
                    txtArabicTranslate.Text = "";
                    txtPronounce.Text = "";
                    txtDescriptions.Text = "";

                    mainForm mainFrm = (mainForm)Application.OpenForms["mainForm"];
                    mainFrm.dataGvAllword.DataSource = wordDatabase.WordsTables;
                }
                catch
                {
                    MessageBox.Show("There was a problem adding a new word", "Adding word result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddPronouncePic_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp;*.wmf";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                picBoxPronounce.Image = Image.FromFile(openFileDialogImage.FileName);
            }
        }
    }
}
