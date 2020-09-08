using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndAuthors
{
    public partial class FindAuthor : Form
    {
        private bool isActive = false;
        public FindAuthor()
        {
            InitializeComponent();
        }

       private void BookAuthors_Load(object sender, EventArgs e)
        {

        }

        private void toggleAuthorsButton_Click(object sender, EventArgs e)
        {
            isActive = !isActive;
            this.authorLabel.Visible = isActive;
            this.margaretmitchelLabel.Visible = isActive;
            this.alexHaleyLabel.Visible = isActive;
            this.aynRandLabel.Visible = isActive;
            this.toggleAuthorsButton.Text = isActive ? "Hide Authors" : "Show Authors";
        }
    }
}
