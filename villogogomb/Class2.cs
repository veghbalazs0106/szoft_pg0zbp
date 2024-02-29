using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class SzínezőGomb : Button
    {
        public SzínezőGomb()
        {
            Height = 20;
            Width = 20;

            MouseClick += SzínezőGomb_MouseClick;
        }

        private void SzínezőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor != Color.Fuchsia)
            {
                BackColor = Color.Fuchsia;
            }
            else
            {
                BackColor = SystemColors.ButtonFace;
            }
        }
    }
}
