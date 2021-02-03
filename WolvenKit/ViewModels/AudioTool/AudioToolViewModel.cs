using Catel.MVVM;
using FmodAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using WolvenKit.Views.AudioTool;

namespace WolvenKit.ViewModels.AudioTool
{
    class AudioToolViewModel : ViewModelBase
    {

        private Channel Channel_;

        public AudioToolViewModel(Channel channel)
        {
            Channel_ = channel;
            Task.Run(new Action(() =>
            {
                for (;;)
                {
                    CurrentPlayerTime = TimeSpan.FromMilliseconds(Channel_.GetPosition(TimeUnit.MS));
                    Thread.Sleep(50);
                }
            }));

        }

        public TimeSpan CurrentPlayerTime { get; set; }



    }
}
