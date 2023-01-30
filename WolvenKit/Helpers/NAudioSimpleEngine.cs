using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;
using NAudio.Vorbis;
using NAudio.Wave;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.Editor.AudioTool
{
    /// <summary>
    /// 精简的播放引擎，能够播放MP3和Wav，并且可以获取音符数据
    /// </summary>
    public class NAudioSimpleEngine : INotifyPropertyChanged, ISpectrumPlayer, IDisposable, IWaveformPlayer
    {

        private readonly object _lockChannelSet = new object();
        private readonly DispatcherTimer _updateChannelPositionTimer;
        private readonly BackgroundWorker waveformGenerateWorker = new BackgroundWorker();

        public WaveOut WaveOutDevice;
        private WaveStream _activeStream;
        private WaveChannel32 _inputStream;
        private readonly int _fftDataSize = (int)FFTDataSize.FFT2048;
        private SampleAggregator _sampleAggregator;

        private string _currentFilePath;

        private bool _disposed;
        private static readonly Lazy<NAudioSimpleEngine> _instance = new Lazy<NAudioSimpleEngine>(() => new NAudioSimpleEngine(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static NAudioSimpleEngine Instance => _instance.Value;

        /// <summary>
        /// 是否允许播放
        /// </summary>
        public bool CanPlay => WaveOutDevice != null && _activeStream != null && _inputStream != null;

        /// <summary>
        /// 是否允许暂停
        /// </summary>
        public bool CanPause => WaveOutDevice != null && WaveOutDevice.PlaybackState == PlaybackState.Playing;

        /// <summary>
        /// 是否允许停止
        /// </summary>
        public bool CanStop => WaveOutDevice != null &&
                       (WaveOutDevice.PlaybackState == PlaybackState.Playing ||
                        WaveOutDevice.PlaybackState == PlaybackState.Paused);

        /// <summary>
        /// 当前文件流的长度，即总秒数
        /// </summary>
        public double ChannelLength
        {
            get
            {
                var length = 0d;
                if (_activeStream != null)
                {
                    length = _activeStream.TotalTime.TotalSeconds;
                }

                return length;
            }
        }

        /// <summary>
        /// 当前播放位置
        /// </summary>
        public double ChannelPosition
        {
            get
            {
                if (_activeStream != null)
                {
                    return (_activeStream.Position / (double)_activeStream.Length) * _activeStream.TotalTime.TotalSeconds;
                }

                return 0d;
            }
            set
            {
                if (CanPlay)
                {
                    lock (_lockChannelSet)
                    {
                        var oldValue = (_activeStream.Position / (double)_activeStream.Length) *
                                          _activeStream.TotalTime.TotalSeconds;
                        var position = Math.Max(0, Math.Min(value, ChannelLength));

                        if (oldValue != position)
                        {
                            _activeStream.Position =
                                (long)((position / _activeStream.TotalTime.TotalSeconds) * _activeStream.Length);
                            OnPropertyChanged();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 是否正在播放
        /// </summary>
        public bool IsPlaying => WaveOutDevice != null && WaveOutDevice.PlaybackState == PlaybackState.Playing;

        private TimeSpan repeatStart;
        private TimeSpan repeatStop;
        private bool inRepeatSet;




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
                        OnPropertyChanged("SelectionBegin");
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

                inRepeatSet = true;
                var oldValue = repeatStop;
                repeatStop = value;
                if (oldValue != repeatStop)
                {
                    OnPropertyChanged("SelectionEnd");
                }

                inRepeatSet = false;

            }
        }

        private void GenerateWaveformData()
        {
            if (waveformGenerateWorker.IsBusy)
            {
                waveformGenerateWorker.CancelAsync();
                return;
            }

            if (!waveformGenerateWorker.IsBusy && waveformCompressedPointCount != 0)
            {
                waveformGenerateWorker.RunWorkerAsync(new WaveformGenerationParams(waveformCompressedPointCount));
            }
        }
        private void waveStream_Sample(object sender, SampleEventArgs e) => waveformAggregator.Add(e.Left, e.Right);

        private void waveformGenerateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var waveformParams = e.Argument as WaveformGenerationParams;
            var waveformInputStream = new WaveChannel32(_activeStream);
            waveformInputStream.Sample += waveStream_Sample;

            var frameLength = fftDataSize;
            var frameCount = (int)(waveformInputStream.Length / (double)frameLength);
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
                waveMaxPointIndexes.Add((int)Math.Round(waveformLength * (i / (double)waveformParams.Points), 0));
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

                    DispatcherHelper.RunOnMainThread(() =>
                    {
                        WaveformData = clonedData;

                    });
                }

                if (waveformGenerateWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                readCount++;
            }

            var finalClonedData = (float[])waveformCompressedPoints.Clone();


            DispatcherHelper.RunOnMainThread(() =>
            {
                fullLevelData = waveformData.ToArray();
                WaveformData = finalClonedData;
            });
            waveformInputStream.Close();
            waveformInputStream.Dispose();
            waveformInputStream = null;
        }

        private void waveformGenerateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (!waveformGenerateWorker.IsBusy && waveformCompressedPointCount != 0)
                {
                    waveformGenerateWorker.RunWorkerAsync(new WaveformGenerationParams(waveformCompressedPointCount));
                }
            }
        }

        private class WaveformGenerationParams
        {
            public WaveformGenerationParams(int points)
            {
                Points = points;
            }
            
            public int Points { get; }
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
                    OnPropertyChanged("WaveformData");
                }
            }
        }

        private float[] fullLevelData;
        private float[] waveformData;
        private SampleAggregator waveformAggregator;
        private readonly int fftDataSize = (int)FFTDataSize.FFT2048;


        private const int repeatThreshold = 200;
        private const int waveformCompressedPointCount = 2000;

        private NAudioSimpleEngine()
        {
            _updateChannelPositionTimer = new DispatcherTimer(DispatcherPriority.SystemIdle)
            {
                Interval = TimeSpan.FromMilliseconds(50)
            };
            _updateChannelPositionTimer.Tick += ChangeChannelPosition;

            waveformGenerateWorker.DoWork += waveformGenerateWorker_DoWork;
            waveformGenerateWorker.RunWorkerCompleted += waveformGenerateWorker_RunWorkerCompleted;
            waveformGenerateWorker.WorkerSupportsCancellation = true;
        }

        public bool GetFFTData(float[] fftDataBuffer)
        {
            _sampleAggregator.GetFFTResults(fftDataBuffer);
            return IsPlaying;
        }

        public int GetFFTFrequencyIndex(int frequency)
        {
            double maxFrequency;
            if (_activeStream != null)
            {
                maxFrequency = _activeStream.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }
            return (int)((frequency / maxFrequency) * (_fftDataSize / 2));
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public bool OpenFile(string filePath)
        {
            //如果播放文件一样，没必要继续操作
            if (_currentFilePath == filePath)
            {
                return false;
            }

            //如果播放文件不存在直接退出
            if (!File.Exists(filePath))
            {
                return false;
            }

            StopAndCloseStream();

            try
            {
                WaveOutDevice = new WaveOut()
                {
                    DesiredLatency = 100
                };

                if (GetTypeWithExtension(filePath) == AudioFileType.Mp3)
                {
                    _activeStream = new Mp3FileReader(filePath);
                }
                else if (GetTypeWithExtension(filePath) == AudioFileType.Wav)
                {
                    _activeStream = new WaveFileReader(filePath);
                    GenerateWaveformData();
                }
                else
                {
                    return false;
                }

                _inputStream = new WaveChannel32(_activeStream);

                _sampleAggregator = new SampleAggregator(_fftDataSize);
                _inputStream.Sample += InputStreamOnSampleChanged;
                WaveOutDevice.Init(_inputStream);
                _currentFilePath = filePath;

                RefreshPlayingState();

                return true;
            }
            catch (Exception e)
            {
                _activeStream = null;
                Debug.WriteLine(e);
                throw;
            }
        }

        public bool OpenOggStream(Stream stream)
        {
            StopAndCloseStream();

            try
            {
                WaveOutDevice = new WaveOut()
                {
                    DesiredLatency = 100
                };

                _activeStream = new VorbisWaveReader(stream);
                GenerateWaveformData();

                _inputStream = new WaveChannel32(_activeStream);

                _sampleAggregator = new SampleAggregator(_fftDataSize);
                _inputStream.Sample += InputStreamOnSampleChanged;
                WaveOutDevice.Init(_inputStream);

                RefreshPlayingState();

                return true;
            }
            catch (Exception e)
            {
                _activeStream = null;
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 校验文件路径是否可能播放
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public bool VerifyFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return false;
            }

            var extension = GetTypeWithExtension(filePath);
            return extension != AudioFileType.Other;
        }

        /// <summary>
        /// 停止并关闭文件
        /// </summary>
        public void CloseFile() => StopAndCloseStream();

        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            if (CanStop)
            {
                WaveOutDevice.Stop();
                _activeStream.Position = 0;

                RefreshPlayingState();
            }
        }

        /// <summary>
        /// 暂停
        /// </summary>
        public void Pause()
        {
            if (IsPlaying && CanPause)
            {
                //严重Bug！！！！！！NAudio库的_waveOutDevice.Pause()方法有严重缺陷，用Stop替代！
                WaveOutDevice.Stop();
                RefreshPlayingState();
            }
        }

        /// <summary>
        /// 播放
        /// </summary>
        public void Play()
        {
            if (CanPlay && !IsPlaying)
            {
                WaveOutDevice.Play();
                _updateChannelPositionTimer.Start();

                RefreshPlayingState();
            }
        }

        //为了避免频繁刷新UI，这里加入缓存字段判断是否需要刷新
        private bool _isPlayingLastState;
        private bool _canPause;
        private bool _canPlay;
        private bool _canStop;

        /// <summary>
        /// 刷新播放状态
        /// </summary>
        private void RefreshPlayingState()
        {
            if (_isPlayingLastState != IsPlaying)
            {
                _isPlayingLastState = IsPlaying;
                OnPropertyChanged("IsPlaying");
            }

            if (_canPause != CanPause)
            {
                _canPause = CanPause;
                OnPropertyChanged("CanPause");
            }

            if (_canPlay != CanPlay)
            {
                _canPlay = CanPlay;
                OnPropertyChanged("CanPlay");
            }

            if (_canStop != CanStop)
            {
                _canStop = CanStop;
                OnPropertyChanged("CanStop");
            }

            //if (_channelLength != ChannelLength)
            //{
            //    _channelLength = ChannelLength;
            //    OnPropertyChanged("ChannelLength");
            //}
            //
            //if (_channelPosition != ChannelPosition)
            //{
            //    _channelPosition = ChannelPosition;
            //    OnPropertyChanged("ChannelPosition");
            //}
        }

        private void StopAndCloseStream()
        {
            if (CanStop)
            {
                WaveOutDevice.Stop();
            }
            _currentFilePath = string.Empty;

            if (_inputStream != null)
            {
                _inputStream.Dispose();
                _inputStream = null;
            }

            if (_activeStream != null)
            {
                _activeStream.Dispose();
                _activeStream = null;
            }

            if (WaveOutDevice != null)
            {
                WaveOutDevice.Dispose();
                WaveOutDevice = null;
            }

            RefreshPlayingState();
        }

        private AudioFileType GetTypeWithExtension(string path)
        {
            var result = AudioFileType.Other;

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                var extension = Path.GetExtension(path);

                if (extension.Equals(".mp3", StringComparison.InvariantCultureIgnoreCase))
                {
                    result = AudioFileType.Mp3;
                }
                else if (extension.Equals(".wav", StringComparison.InvariantCultureIgnoreCase))
                {
                    result = AudioFileType.Wav;
                }
            }

            return result;
        }

        private void InputStreamOnSampleChanged(object sender, SampleEventArgs sampleEventArgs) => _sampleAggregator.Add(sampleEventArgs.Left, sampleEventArgs.Right);

        /// <summary>
        /// 改变流位置
        /// </summary>
        private void ChangeChannelPosition(object sender, EventArgs e)
        {
            OnPropertyChanged("ChannelPosition");

            if (!IsPlaying)
            {
                _updateChannelPositionTimer.Stop();
            }

            //播放结束需要暂停
            if (_activeStream != null && _activeStream.CurrentTime >= _activeStream.TotalTime)
            {
                Stop();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    StopAndCloseStream();
                }

                _disposed = true;
            }
        }

        ~NAudioSimpleEngine()
        {
            Dispose(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private enum AudioFileType
        {
            Mp3,

            Wav,

            Other
        }

    }
}
