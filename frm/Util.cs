using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVendas
{
    class Util
    {

        public void HabilitaBotoes(bool hab, Control.ControlCollection control)
        {
            foreach (Control item in control)
            {
                if (item is Button || item is NumericUpDown)
                {
                    item.Enabled = hab;
                    if (item.Name == "btnGravar" || item.Name == "btnCancelar" || item.Name == "btnPesquisar") 
                    {
                        item.Enabled = !hab;
                    }
                }
            }
        }
        public void HabilitaCampos(bool hab, Control.ControlCollection control)
        {
            foreach (Control item in control)
            {
                if ((item is Label) || (item is ComboBox) || (item is TextBox) || (item is MaskedTextBox) || (item is DateTimePicker) || (item is NumericUpDown))
                {
                    item.Enabled = hab;
                }
            }
        }

        public void LimparCampos(Control.ControlCollection control)
        {
            foreach (Control item in control)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedValue.ToString();
                }
                if ((item is NumericUpDown))
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }
    }
}
