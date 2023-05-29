using System;
using System.Windows.Forms;

namespace Calendar.FormForCRUD
{
    public partial class AddForm : Form2
    {
        public AddForm(DateTime dateTime) : base(dateTime)
        {
            Prepare();
        }

        private void Prepare()
        {
            Text = "Новое событие";
            BtnActionChangeText("Создать событие");
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
