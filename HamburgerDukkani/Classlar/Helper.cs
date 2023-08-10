using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani.Classlar
{
    internal class Helper
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection) 
            {
                if(control is ListBox) 
                {
                    ((ListBox)control).Items.Clear();
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked=false; 
                }
                else if (control is Label)
                {
                    Label lbl = new Label();
                    lbl= ((Label)control);
                    if (lbl.Name == "lblGenelToplam")
                        lbl.Text = "";
                }
                else if (control is TextBox)
                {
                    TextBox tbx = new TextBox();
                    tbx = ((TextBox)control);
                    tbx.Text = "";
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown nud = new NumericUpDown();
                    nud = ((NumericUpDown)control);
                    nud.Value = 0;
                }

                else if(control is ComboBox) 
                {
                    ((ComboBox)control).SelectedItem = 0;
                }
                else if(control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if(rb.Name=="Büyük")
                    {
                        rb.Checked = true;
                    }
                    else { rb.Checked = false; }
                }
                else if( control is FlowLayoutPanel)
                {
                    FlowLayoutPanel fly = (FlowLayoutPanel)control;
                    Temizle(fly.Controls);
                }
            }
        }
        
    }
}
