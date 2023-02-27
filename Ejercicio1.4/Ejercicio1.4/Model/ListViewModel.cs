using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_4.Model
{
    internal class ListViewModel
    {

        #region Attributes
        public object listViewSource;
        #endregion

        #region Properties
        public object ListViewSource { get { return listViewSource; } set { listViewSource = value; } }
        //set { setValue(ref listViewSource, value);  } }
        #endregion

        #region Methods
        public async Task LoadData()
        {
            ListViewSource = await App.BD.ListaImagen();
        }
        #endregion

        #region Constructor
        public ListViewModel()
        {
            LoadData();
        }
        #endregion
    }
}
