using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP77Tools.Services
{
    public interface IMainController : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public Dictionary<ulong, string>  Hashdict { get; set; }
    }
}
