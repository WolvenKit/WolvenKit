using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Windows;
using Discord.Audio.Streams;
using NAudio.Extras;
using Wkit.Vorbis;
using NAudio.Wave;

namespace NAudioWpfDemo.AudioPlaybackDemo
{
    // https://github.com/naudio/NAudio/blob/8e162ed1b1dc13491794ace46327e35d866465cc/NAudioWpfDemo/AudioPlaybackDemo/AudioPlayback.cs
    public class AudioPlayback : IDisposable
    {
        private IWavePlayer? playbackDevice;
        private WaveStream? fileStream;

        public event EventHandler<FftEventArgs>? FftCalculated;

        public event EventHandler<MaxSampleEventArgs>? MaximumCalculated;

        public void Load(string fileName)
        {
            Stop();
            CloseFile();
            EnsureDeviceCreated();
            OpenFile(fileName);
        }

        public void LoadOgg(Stream stream)
        {
            Stop();
            CloseFile();
            EnsureDeviceCreated();
            OpenOggStream(stream);
        }

        private void CloseFile()
        {
            fileStream?.Dispose();
            fileStream = null;
        }

        private void OpenOggStream(Stream stream)
        {
            try
            {
                var vorbisStream = new VorbisWaveReader(stream)
                {
                    PerformFFT = true
                };
                fileStream = vorbisStream;

                vorbisStream.NotificationCount = vorbisStream.WaveFormat.SampleRate / 100;
                vorbisStream.FftCalculated += (s, a) => FftCalculated?.Invoke(this, a);
                vorbisStream.MaximumCalculated += (s, a) => MaximumCalculated?.Invoke(this, a);

                ArgumentNullException.ThrowIfNull(playbackDevice);
                playbackDevice.Init(vorbisStream);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Problem opening file");
                CloseFile();
            }
        }

       
        private void OpenFile(string fileName)
        {
            try
            {
                var inputStream = new AudioFileReader(fileName);
                fileStream = inputStream;

                var aggregator = new SampleAggregator(inputStream)
                {
                    NotificationCount = inputStream.WaveFormat.SampleRate / 100,
                    PerformFFT = true
                };
                aggregator.FftCalculated += (s, a) => FftCalculated?.Invoke(this, a);
                aggregator.MaximumCalculated += (s, a) => MaximumCalculated?.Invoke(this, a); 

                playbackDevice.Init(aggregator);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Problem opening file");
                CloseFile();
            }
        }

        private void EnsureDeviceCreated()
        {
            if (playbackDevice == null)
            {
                CreateDevice();
            }
        }

        private void CreateDevice()
        {
            playbackDevice = new WaveOut {DesiredLatency = 200};
        }

        public void Play()
        {
            if (playbackDevice != null && fileStream != null && playbackDevice.PlaybackState == PlaybackState.Stopped)
            {
                Stop(); // doesn't play otherwise
                playbackDevice.Play();
            }
            if (playbackDevice != null && fileStream != null && playbackDevice.PlaybackState == PlaybackState.Paused)
            {
                playbackDevice.Play();
            }
        }

        public void Pause()
        {
            playbackDevice?.Pause();
        }

        public void Stop()
        {
            playbackDevice?.Stop();
            if (fileStream != null)
            {
                fileStream.Position = 0;
            }
        }

        public void Dispose()
        {
            Stop();
            CloseFile();
            playbackDevice?.Dispose();
            playbackDevice = null;
        }
    }
}
