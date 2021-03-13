using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WolvenKit.W3SavegameEditor.Core.Common
{
    public class ReadSavegameProgress : IReadSavegameProgress, INotifyPropertyChanged
    {
        #region Fields

        private bool _indeterministic;
        private int _max;
        private bool _running;
        private int _value;

        #endregion Fields

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        public bool Indeterministic
        {
            get { return _indeterministic; }
            set
            {
                if (_indeterministic != value)
                {
                    _indeterministic = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Max
        {
            get { return _max; }
            set
            {
                if (_max != value)
                {
                    _max = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Running
        {
            get { return _running; }
            set
            {
                if (_running != value)
                {
                    _running = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion Properties

        #region Methods

        public void Report(bool running, bool indeterministic, int value, int max)
        {
            Running = running;
            Indeterministic = indeterministic;
            Value = value;
            Max = max;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Methods
    }
}
