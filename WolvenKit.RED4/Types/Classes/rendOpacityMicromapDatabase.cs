using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendOpacityMicromapDatabase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ommChunks")] 
		public CArray<rendOpacityMicromapChunk> OmmChunks
		{
			get => GetPropertyValue<CArray<rendOpacityMicromapChunk>>();
			set => SetPropertyValue<CArray<rendOpacityMicromapChunk>>(value);
		}

		[Ordinal(1)] 
		[RED("dataBuffer")] 
		public CArray<CUInt8> DataBuffer
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public rendOpacityMicromapDatabase()
		{
			OmmChunks = new();
			DataBuffer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
