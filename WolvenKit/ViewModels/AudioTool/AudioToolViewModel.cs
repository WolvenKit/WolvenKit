using Catel.MVVM;
using FmodAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Views.AudioTool;

namespace WolvenKit.ViewModels.AudioTool
{
    class AudioToolViewModel : ViewModelBase
    {


        private Channel Channel_;

        public AudioToolViewModel(Channel channel)
        {
            Channel_ = channel;
            CurrentPlayerTime = TimeSpan.FromMilliseconds(channel.GetPosition(TimeUnit.MS));
        }

        public TimeSpan CurrentPlayerTime
        {
            get
            {



                return TimeSpan.FromMilliseconds(Channel_.GetPosition(TimeUnit.MS)); 
            }
            set
            {
                RaisePropertyChanged(nameof(CurrentPlayerTime));

            }

        }



    }
}
