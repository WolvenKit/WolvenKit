using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSAnimationBufferBitwiseCompressedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("compression")] 
		public CInt8 Compression
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(2)] 
		[RED("numFrames")] 
		public CUInt16 NumFrames
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("dataAddr")] 
		public CUInt32 DataAddr
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("dataAddrFallback")] 
		public CUInt32 DataAddrFallback
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animSAnimationBufferBitwiseCompressedData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
