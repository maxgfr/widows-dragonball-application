using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Views
{
    public interface IView
    {
        void Close();
        bool? ShowDialog();
        void Show();
    }
}
