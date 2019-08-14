using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Morphcalc : Form
    {
        public Morphcalc()
        {
            InitializeComponent();
        }

        private void AddFromMorphText(object sender, EventArgs e)
        {

            if (MorphText.Text != "")
            {
                listMorph.Items.Add(MorphText.Text);
            }
        }

        private void ClearFromlistMorph(object sender, EventArgs e)
        {
            listMorph.Items.Clear();
        }

        private void RemoveFromlistMorph(object sender, EventArgs e)
        {
            string MarkeretMorph = listMorph.GetItemText(listMorph.SelectedItem);

            listMorph.Items.Remove(MarkeretMorph);
        }

        private void MixFromlistMorph(object sender, EventArgs e)
        {
            listMorph.Items.Add(new KeyValuePair(key, value);

            KeyValuePair keyValuePair = listMorph.Items[index];
            var value = keyValuePair.Value;

        }
    }
}                  
