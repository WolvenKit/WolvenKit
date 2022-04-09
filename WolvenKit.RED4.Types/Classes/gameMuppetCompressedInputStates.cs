using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetCompressedInputStates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("usesCompression")] 
		public CBool UsesCompression
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("compressedInputStates")] 
		public CArray<CUInt8> CompressedInputStates
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(2)] 
		[RED("firstFrameId")] 
		public CUInt32 FirstFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameMuppetCompressedInputStates()
		{
			CompressedInputStates = new();
			FirstFrameId = 4294967295;
			ReplicationTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
