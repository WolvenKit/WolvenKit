using System;
using System.Linq;
using NAudio.Dsp;
using NAudio.Extras;
using NAudio.Wave;

namespace NAudio.Vorbis
{
    // https://github.com/naudio/Vorbis/blob/adb0443f6a3e87e29fdd0e592efa57396f014832/NAudio.Vorbis/VorbisWaveReader.cs
    public class VorbisWaveReader : Wave.WaveStream, ISampleProvider
    {
        VorbisSampleProvider _sampleProvider;

        // volume
        public event EventHandler<MaxSampleEventArgs>? MaximumCalculated;
        private float maxValue;
        private float minValue;
        public int NotificationCount { get; set; }
        int count;

        // FFT
        public event EventHandler<FftEventArgs>? FftCalculated;
        public bool PerformFFT { get; set; }
        private readonly Complex[] fftBuffer;
        private readonly FftEventArgs fftArgs;
        private int fftPos;
        private readonly int fftLength;
        private readonly int m;
        private readonly ISampleProvider source;

        private readonly int channels;

        public VorbisWaveReader(string fileName)
            : this(System.IO.File.OpenRead(fileName), true)
        {
        }

        public VorbisWaveReader(System.IO.Stream sourceStream, bool closeOnDispose = false, int fftLength = 1024)
        {
            // To maintain consistent semantics with v1.1, we don't expose the events and auto-advance / stream removal features of VorbisSampleProvider.
            // If one wishes to use those features, they should really use VorbisSampleProvider directly...
            _sampleProvider = new VorbisSampleProvider(sourceStream, closeOnDispose);

            channels = _sampleProvider.WaveFormat.Channels;
            if (!IsPowerOfTwo(fftLength))
            {
                throw new ArgumentException("FFT Length must be a power of two");
            }
            m = (int)Math.Log(fftLength, 2.0);
            this.fftLength = fftLength;
            fftBuffer = new Complex[fftLength];
            fftArgs = new FftEventArgs(fftBuffer);
            this.source = _sampleProvider;
        }

        static bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _sampleProvider.Dispose();
                //_sampleProvider = null;
            }
            
            base.Dispose(disposing);
        }

        public override Wave.WaveFormat WaveFormat => _sampleProvider!.WaveFormat!;

        public override long Length => _sampleProvider.Length * _sampleProvider!.WaveFormat!.BlockAlign;

        public override long Position
        {
            get => _sampleProvider.SamplePosition * _sampleProvider!.WaveFormat!.BlockAlign;
            set
            {
                if (!_sampleProvider.CanSeek) throw new InvalidOperationException("Cannot seek!");
                if (value < 0 || value > Length) throw new ArgumentOutOfRangeException(nameof(value));

                _sampleProvider.Seek(value / _sampleProvider!.WaveFormat!.BlockAlign);
            }
        }

        // This buffer can be static because it can only be used by 1 instance per thread
        [ThreadStatic]
        static float[]? _conversionBuffer = null;

        private void Add(float value)
        {
            if (PerformFFT && FftCalculated != null)
            {
                fftBuffer[fftPos].X = (float)(value * FastFourierTransform.HammingWindow(fftPos, fftLength));
                fftBuffer[fftPos].Y = 0;
                fftPos++;
                if (fftPos >= fftBuffer.Length)
                {
                    fftPos = 0;
                    // 1024 = 2^10
                    FastFourierTransform.FFT(true, m, fftBuffer);
                    FftCalculated(this, fftArgs);
                }
            }

            maxValue = Math.Max(maxValue, value);
            minValue = Math.Min(minValue, value);
            count++;
            if (count >= NotificationCount && NotificationCount > 0)
            {
                MaximumCalculated?.Invoke(this, new MaxSampleEventArgs(minValue, maxValue));
                Reset();
            }
        }

        public void Reset()
        {
            count = 0;
            maxValue = minValue = 0;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            // adjust count so it is in floats instead of bytes
            count /= sizeof(float);

            // make sure we don't have an odd count
            count -= count % _sampleProvider!.WaveFormat!.Channels;

            // get the buffer, creating a new one if none exists or the existing one is too small
            var cb = _conversionBuffer ?? (_conversionBuffer = new float[count]);
            if (cb.Length < count)
            {
                cb = (_conversionBuffer = new float[count]);
            }

            // let Read(float[], int, int) do the actual reading; adjust count back to bytes
            int cnt = Read(cb, 0, count) * sizeof(float);

            // move the data back to the request buffer
            Buffer.BlockCopy(cb, 0, buffer, offset, cnt);

            // done!
            return cnt;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            var samplesRead = _sampleProvider.Read(buffer, offset, count);

            for (int n = 0; n < samplesRead; n += channels)
            {
                Add(buffer[n + offset]);
            }

            return samplesRead;
        }

        [Obsolete("Was never used and will be removed.")]
        public bool IsParameterChange => false;

        [Obsolete("Was never used and will be removed.")]
        public void ClearParameterChange() { }

        public int StreamCount => _sampleProvider.StreamCount;

        public int? NextStreamIndex { get; set; }

        public bool GetNextStreamIndex()
        {
            if (!NextStreamIndex.HasValue)
            {
                NextStreamIndex = _sampleProvider.GetNextStreamIndex();
                return NextStreamIndex.HasValue;
            }
            return false;
        }

        public int CurrentStream
        {
            get => _sampleProvider.GetCurrentStreamIndex();
            set
            {
                _sampleProvider.SwitchStreams(value);

                NextStreamIndex = null;
            }
        }

        /// <summary>
        /// Gets the encoder's upper bitrate of the current selected Vorbis stream
        /// </summary>
        public int UpperBitrate => _sampleProvider.UpperBitrate;

        /// <summary>
        /// Gets the encoder's nominal bitrate of the current selected Vorbis stream
        /// </summary>
        public int NominalBitrate => _sampleProvider.NominalBitrate;

        /// <summary>
        /// Gets the encoder's lower bitrate of the current selected Vorbis stream
        /// </summary>
        public int LowerBitrate => _sampleProvider.LowerBitrate;

        /// <summary>
        /// Gets the encoder's vendor string for the current selected Vorbis stream
        /// </summary>
        public string Vendor => _sampleProvider.Tags.EncoderVendor;

        /// <summary>
        /// Gets the comments in the current selected Vorbis stream
        /// </summary>
        public string[] Comments => _sampleProvider.Tags.All.SelectMany(k => k.Value, (kvp, Item) => $"{kvp.Key}={Item}").ToArray();

        /// <summary>
        /// Gets the number of bits read that are related to framing and transport alone
        /// </summary>
        [Obsolete("No longer supported.", true)]
        public long ContainerOverheadBits => throw new NotSupportedException();

        /// <summary>
        /// Gets stats from each decoder stream available
        /// </summary>
        public NVorbis.Contracts.IStreamStats[] Stats => new[] { _sampleProvider.Stats };
    }
}
