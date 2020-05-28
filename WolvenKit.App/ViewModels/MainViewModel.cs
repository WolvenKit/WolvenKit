using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.Common;

namespace WolvenKit.App.ViewModels
{
    public class MainViewModel : ViewModel
    {
        #region Properties
        #region Title
        private string _title;
        public virtual string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

       

        #endregion

        #region Fields
        
        #endregion


        public MainViewModel()
        {
            Title = "WolvenKit";

           
        }


    }
}
