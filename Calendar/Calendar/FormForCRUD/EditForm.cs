using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calendar.FormForCRUD
{
    public partial class EditForm : Form2
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private protected override void BtnAction_Click(object sender, EventArgs e)
        {
            bool resAdd = true;
            // actions with db

            if (resAdd)
            {

                Close();
            }
            else
            {
                MessageBox.Show("Невозможно добавить событие");
            }
        }
    }
}
