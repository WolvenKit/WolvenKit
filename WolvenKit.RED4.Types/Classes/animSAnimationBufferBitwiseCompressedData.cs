using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSAnimationBufferBitwiseCompressedData : RedBaseClass
	{
		private CFloat _dt;
		private CInt8 _compression;
		private CUInt16 _numFrames;
		private CUInt32 _dataAddr;
		private CUInt32 _dataAddrFallback;

		[Ordinal(0)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get => GetProperty(ref _dt);
			set => SetProperty(ref _dt, value);
		}

		[Ordinal(1)] 
		[RED("compression")] 
		public CInt8 Compression
		{
			get => GetProperty(ref _compression);
			set => SetProperty(ref _compression, value);
		}

		[Ordinal(2)] 
		[RED("numFrames")] 
		public CUInt16 NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(3)] 
		[RED("dataAddr")] 
		public CUInt32 DataAddr
		{
			get => GetProperty(ref _dataAddr);
			set => SetProperty(ref _dataAddr, value);
		}

		[Ordinal(4)] 
		[RED("dataAddrFallback")] 
		public CUInt32 DataAddrFallback
		{
			get => GetProperty(ref _dataAddrFallback);
			set => SetProperty(ref _dataAddrFallback, value);
		}
	}
}
