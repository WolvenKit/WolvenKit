// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Threading;
using NAudio.Wave;
using WPFSoundVisualizationLib;

namespace WolvenKit.MVVM.Views.Components.Tools.AudioTool
{
    internal class NAudioEngine : INotifyPropertyChanged, ISpectrumPlayer, IWaveformPlayer, IDisposable
    {
        #region Fields

        private static NAudioEngine instance;
        private readonly DispatcherTimer positionTimer = new DispatcherTimer(DispatcherPriority.ApplicationIdle);
        private readonly BackgroundWorker waveformGenerateWorker = new BackgroundWorker();
        private readonly int fftDataSize = (int)FFTDataSize.FFT2048;
        private bool disposed;
        private bool canPlay;
        private bool canPause;
        private bool canStop;
        private bool isPlaying;
        private bool inChannelTimerUpdate;
        private double channelLength;
        private double channelPosition;
        private bool inChannelSet;
        private WaveOut waveOutDevice;
        private WaveStream activeStream;
        private NAudio.Wave.WaveChannel32 inputStream;
        private SampleAggregator sampleAggregator;
        private SampleAggregator waveformAggregator;
        private string pendingWaveformPath;
        private float[] fullLevelData;
        private float[] waveformData;
        private TagLib.File fileTag;
        private TimeSpan repeatStart;
        private TimeSpan repeatStop;
        private bool inRepeatSet;

        #endregion Fields

        #region Constants

        private const int waveformCompressedPointCount = 2000;
        private const int repeatThreshold = 200;

        #endregion Constants

        #region Singleton Pattern

        public static NAudioEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NAudioEngine();
                }

                return instance;
            }
        }

        #endregion Singleton Pattern

        #region Constructor

        private NAudioEngine()
        {
            positionTimer.Interval = TimeSpan.FromMilliseconds(50);
            positionTimer.Tick += positionTimer_Tick;

            waveformGenerateWorker.DoWork += waveformGenerateWorker_DoWork;
            waveformGenerateWorker.RunWorkerCompleted += waveformGenerateWorker_RunWorkerCompleted;
            waveformGenerateWorker.WorkerSupportsCancellation = true;
        }

        #endregion Constructor

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    StopAndCloseStream();
                }

                disposed = true;
            }
        }

        #endregion IDisposable

        #region ISpectrumPlayer

        public bool GetFFTData(float[] fftDataBuffer)
        {
            sampleAggregator.GetFFTResults(fftDataBuffer);
            return isPlaying;
        }

        public int GetFFTFrequencyIndex(int frequency)
        {
            double maxFrequency;
            if (ActiveStream != null)
            {
                maxFrequency = ActiveStream.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }

            return (int)(frequency / maxFrequency * (fftDataSize / 2));
        }

        #endregion ISpectrumPlayer

        #region IWaveformPlayer

        public TimeSpan SelectionBegin
        {
            get => repeatStart;
            set
            {
                if (!inRepeatSet)
                {
                    inRepeatSet = true;
                    var oldValue = repeatStart;
                    repeatStart = value;
                    if (oldValue != repeatStart)
                    {
                        NotifyPropertyChanged("SelectionBegin");
                    }

                    inRepeatSet = false;
                }
            }
        }

        public TimeSpan SelectionEnd
        {
            get => repeatStop;
            set
            {
                if (!inChannelSet)
                {
                    inRepeatSet = true;
                    var oldValue = repeatStop;
                    repeatStop = value;
                    if (oldValue != repeatStop)
                    {
                        NotifyPropertyChanged("SelectionEnd");
                    }

                    inRepeatSet = false;
                }
            }
        }

        public float[] WaveformData
        {
            get => waveformData;
            protected set
            {
                var oldValue = waveformData;
                waveformData = value;
                if (oldValue != waveformData)
                {
                    NotifyPropertyChanged("WaveformData");
                }
            }
        }

        public double ChannelLength
        {
            get => channelLength;
            protected set
            {
                var oldValue = channelLength;
                channelLength = value;
                if (oldValue != channelLength)
                {
                    NotifyPropertyChanged("ChannelLength");
                }
            }
        }

        public double ChannelPosition
        {
            get => channelPosition;
            set
            {
                if (!inChannelSet)
                {
                    inChannelSet = true; // Avoid recursion
                    var oldValue = channelPosition;
                    var position = Math.Max(0, Math.Min(value, ChannelLength));
                    if (!inChannelTimerUpdate && ActiveStream != null)
                    {
                        ActiveStream.Position = (long)(position / ActiveStream.TotalTime.TotalSeconds * ActiveStream.Length);
                    }

                    channelPosition = position;
                    if (oldValue != channelPosition)
                    {
                        NotifyPropertyChanged("ChannelPosition");
                    }

                    inChannelSet = false;
                }
            }
        }

        #endregion IWaveformPlayer

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion INotifyPropertyChanged

        #region Waveform Generation

        private class WaveformGenerationParams
        {
            public WaveformGenerationParams(int points, string path)
            {
                Points = points;
                Path = path;
            }

            public int Points { get; protected set; }
            public string Path { get; protected set; }
        }

        private void GenerateWaveformData(string path)
        {
            if (waveformGenerateWorker.IsBusy)
            {
                pendingWaveformPath = path;
                waveformGenerateWorker.CancelAsync();
                return;
            }

            if (!waveformGenerateWorker.IsBusy && waveformCompressedPointCount != 0)
            {
                waveformGenerateWorker.RunWorkerAsync(new WaveformGenerationParams(waveformCompressedPointCount, path));
            }
        }

        private void waveformGenerateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (!waveformGenerateWorker.IsBusy && waveformCompressedPointCount != 0)
                {
                    waveformGenerateWorker.RunWorkerAsync(new WaveformGenerationParams(waveformCompressedPointCount, pendingWaveformPath));
                }
            }
        }

        private void waveformGenerateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var waveformParams = e.Argument as WaveformGenerationParams;
            var waveformMp3Stream = new Mp3FileReader(waveformParams.Path);
            var waveformInputStream = new WaveChannel32(waveformMp3Stream);
            waveformInputStream.Sample += waveStream_Sample;

            var frameLength = fftDataSize;
            var frameCount = (int)((double)waveformInputStream.Length / (double)frameLength);
            var waveformLength = frameCount * 2;
            var readBuffer = new byte[frameLength];
            waveformAggregator = new SampleAggregator(frameLength);

            var maxLeftPointLevel = float.MinValue;
            var maxRightPointLevel = float.MinValue;
            var currentPointIndex = 0;
            var waveformCompressedPoints = new float[waveformParams.Points];
            var waveformData = new List<float>();
            var waveMaxPointIndexes = new List<int>();

            for (var i = 1; i <= waveformParams.Points; i++)
            {
                waveMaxPointIndexes.Add((int)Math.Round(waveformLength * ((double)i / (double)waveformParams.Points), 0));
            }
            var readCount = 0;
            while (currentPointIndex * 2 < waveformParams.Points)
            {
                waveformInputStream.Read(readBuffer, 0, readBuffer.Length);

                waveformData.Add(waveformAggregator.LeftMaxVolume);
                waveformData.Add(waveformAggregator.RightMaxVolume);

                if (waveformAggregator.LeftMaxVolume > maxLeftPointLevel)
                {
                    maxLeftPointLevel = waveformAggregator.LeftMaxVolume;
                }

                if (waveformAggregator.RightMaxVolume > maxRightPointLevel)
                {
                    maxRightPointLevel = waveformAggregator.RightMaxVolume;
                }

                if (readCount > waveMaxPointIndexes[currentPointIndex])
                {
                    waveformCompressedPoints[currentPointIndex * 2] = maxLeftPointLevel;
                    waveformCompressedPoints[(currentPointIndex * 2) + 1] = maxRightPointLevel;
                    maxLeftPointLevel = float.MinValue;
                    maxRightPointLevel = float.MinValue;
                    currentPointIndex++;
                }
                if (readCount % 3000 == 0)
                {
                    var clonedData = (float[])waveformCompressedPoints.Clone();
                    App.Current.Dispatcher.Invoke(new Action(() => WaveformData = clonedData));
                }

                if (waveformGenerateWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                readCount++;
            }

            var finalClonedData = (float[])waveformCompressedPoints.Clone();
            App.Current.Dispatcher.Invoke(new Action(() =>
            {
                fullLevelData = waveformData.ToArray();
                WaveformData = finalClonedData;
            }));
            waveformInputStream.Close();
            waveformInputStream.Dispose();
            waveformInputStream = null;
            waveformMp3Stream.Close();
            waveformMp3Stream.Dispose();
            waveformMp3Stream = null;
        }

        #endregion Waveform Generation

        #region Private Utility Methods

        private void StopAndCloseStream()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (activeStream != null)
            {
                inputStream.Close();
                inputStream = null;
                ActiveStream.Close();
                ActiveStream = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        #endregion Private Utility Methods

        #region Public Methods

        public void Stop()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            IsPlaying = false;
            CanStop = false;
            CanPlay = true;
            CanPause = false;
        }

        public void Pause()
        {
            if (IsPlaying && CanPause)
            {
                waveOutDevice.Pause();
                IsPlaying = false;
                CanPlay = true;
                CanPause = false;
            }
        }

        public void Play()
        {
            if (CanPlay)
            {
                waveOutDevice.Play();
                IsPlaying = true;
                CanPause = true;
                CanPlay = false;
                CanStop = true;
            }
        }

        public void OpenFile(string path)
        {
            Stop();

            if (ActiveStream != null)
            {
                SelectionBegin = TimeSpan.Zero;
                SelectionEnd = TimeSpan.Zero;
                ChannelPosition = 0;
            }

            StopAndCloseStream();

            if (System.IO.File.Exists(path))
            {
                try
                {
                    waveOutDevice = new WaveOut()
                    {
                        DesiredLatency = 100
                    };
                    ActiveStream = new Mp3FileReader(path);
                    inputStream = new WaveChannel32(ActiveStream);
                    sampleAggregator = new SampleAggregator(fftDataSize);
                    inputStream.Sample += inputStream_Sample;
                    waveOutDevice.Init(inputStream);
                    ChannelLength = inputStream.TotalTime.TotalSeconds;
                    FileTag = TagLib.File.Create(path);
                    GenerateWaveformData(path);
                    CanPlay = true;
                }
                catch
                {
                    ActiveStream = null;
                    CanPlay = false;
                }
            }
        }

        #endregion Public Methods

        #region Public Properties

        public TagLib.File FileTag
        {
            get => fileTag;
            set
            {
                var oldValue = fileTag;
                fileTag = value;
                if (oldValue != fileTag)
                {
                    NotifyPropertyChanged("FileTag");
                }
            }
        }

        public WaveStream ActiveStream
        {
            get => activeStream;
            protected set
            {
                var oldValue = activeStream;
                activeStream = value;
                if (oldValue != activeStream)
                {
                    NotifyPropertyChanged("ActiveStream");
                }
            }
        }

        public bool CanPlay
        {
            get => canPlay;
            protected set
            {
                var oldValue = canPlay;
                canPlay = value;
                if (oldValue != canPlay)
                {
                    NotifyPropertyChanged("CanPlay");
                }
            }
        }

        public bool CanPause
        {
            get => canPause;
            protected set
            {
                var oldValue = canPause;
                canPause = value;
                if (oldValue != canPause)
                {
                    NotifyPropertyChanged("CanPause");
                }
            }
        }

        public bool CanStop
        {
            get => canStop;
            protected set
            {
                var oldValue = canStop;
                canStop = value;
                if (oldValue != canStop)
                {
                    NotifyPropertyChanged("CanStop");
                }
            }
        }

        public bool IsPlaying
        {
            get => isPlaying;
            protected set
            {
                var oldValue = isPlaying;
                isPlaying = value;
                if (oldValue != isPlaying)
                {
                    NotifyPropertyChanged("IsPlaying");
                }

                positionTimer.IsEnabled = value;
            }
        }

        #endregion Public Properties

        #region Event Handlers

        private void inputStream_Sample(object sender, SampleEventArgs e)
        {
            sampleAggregator.Add(e.Left, e.Right);
            var repeatStartPosition = (long)(SelectionBegin.TotalSeconds / ActiveStream.TotalTime.TotalSeconds * ActiveStream.Length);
            var repeatStopPosition = (long)(SelectionEnd.TotalSeconds / ActiveStream.TotalTime.TotalSeconds * ActiveStream.Length);
            if (((SelectionEnd - SelectionBegin) >= TimeSpan.FromMilliseconds(repeatThreshold)) && ActiveStream.Position >= repeatStopPosition)
            {
                sampleAggregator.Clear();
                ActiveStream.Position = repeatStartPosition;
            }
        }

        private void waveStream_Sample(object sender, SampleEventArgs e) => waveformAggregator.Add(e.Left, e.Right);

        private void positionTimer_Tick(object sender, EventArgs e)
        {
            inChannelTimerUpdate = true;
            ChannelPosition = (double)ActiveStream.Position / (double)ActiveStream.Length * ActiveStream.TotalTime.TotalSeconds;
            inChannelTimerUpdate = false;
        }

        #endregion Event Handlers
    }
}
