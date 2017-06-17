using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindSourse
{
    public partial class MySuperForm : Form
    {
        private BindingList<Man> lm;
        private bool _updFlag;
        public MySuperForm()
        {
            InitializeComponent();
            _updFlag = false;
            lm = new BindingList<Man>();
            bindingsComboBox.DataSource = lm;
            bindingsListBox.DataSource = lm;
            bindingsListBox.ValueMember = "Id";
            bindingsComboBox.DisplayMember = "Name";
            bindingsComboBox.ValueMember = "Id";
            lm.Add(new Man("Vadim", 19));
            lm.Add(new Man("Vasia", 20));
            lm.Add(new Man("Petia", 18));
            lm.Add(new Man("Kirill", 17));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Man m = new Man {Name = nameTextBox.Text };
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            m.Id = id;
            lm.Add(m);
            this.BindingContext[lm].Position = lm.Count;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            lm.RemoveAt(this.BindingContext[lm].Position);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_updFlag)
            {
                _updFlag = false;
                idTextBox.DataBindings.Clear();
                nameTextBox.DataBindings.Clear();
                idTextBox.Text = String.Empty;
                nameTextBox.Text = String.Empty;
                (sender as Button).Text = "Update";
            }
            else
            {
                _updFlag = true;
                idTextBox.DataBindings.Add("Text", lm, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
                nameTextBox.DataBindings.Add("Text", lm, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
                (sender as Button).Text = "Apply";
            }
        }

    }
}
