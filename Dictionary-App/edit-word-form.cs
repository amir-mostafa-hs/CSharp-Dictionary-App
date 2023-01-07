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
    public partial class edit_word_form : Form
    {
        public edit_word_form()
        {
            InitializeComponent();
        }

        private void btnAddPronouncePic_Click(object sender, EventArgs e)
        {
            openFileDialogEditImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp;*.wmf";
            if (openFileDialogEditImage.ShowDialog() == DialogResult.OK)
            {
                picBoxPronounce.Image = Image.FromFile(openFileDialogEditImage.FileName);
            }
        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            dbClassWordTableDataContext wordDatabase = new dbClassWordTableDataContext();
            mainForm mainFrm = (mainForm)Application.OpenForms["mainForm"];
            int wordSelectedId = Convert.ToInt32(mainFrm.dataGvAllword.CurrentRow.Cells[0].Value);
            var selectWordFromDB = (from WordsTable in wordDatabase.WordsTables
                                    where WordsTable.WordId == wordSelectedId
                                    select WordsTable).Single();

            selectWordFromDB.Word = txtWord.Text;
            selectWordFromDB.PersianTranslate = txtPersianTranslate.Text;
            selectWordFromDB.ArabicTranslate = txtArabicTranslate.Text;
            selectWordFromDB.Pronounce = txtPronounce.Text;
            selectWordFromDB.Descriptions = txtDescriptions.Text;
            
            if (openFileDialogEditImage.FileName != "openFileDialog1")
            {
                selectWordFromDB.PronounceImage = openFileDialogEditImage.FileName;
            }
            else if(mainFrm.dataGvAllword.CurrentRow.Cells[5].Value != null)
            {
                selectWordFromDB.PronounceImage = mainFrm.dataGvAllword.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                selectWordFromDB.PronounceImage = null;
            }

            wordDatabase.SubmitChanges();
            mainFrm.dataGvAllword.DataSource = wordDatabase.WordsTables;

            MessageBox.Show("Edit word is successfully", "Edit word result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
