using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetCompressedInputStates : RedBaseClass
	{
		private CBool _usesCompression;
		private CArray<CUInt8> _compressedInputStates;
		private CUInt32 _firstFrameId;
		private netTime _replicationTime;

		[Ordinal(0)] 
		[RED("usesCompression")] 
		public CBool UsesCompression
		{
			get => GetProperty(ref _usesCompression);
			set => SetProperty(ref _usesCompression, value);
		}

		[Ordinal(1)] 
		[RED("compressedInputStates")] 
		public CArray<CUInt8> CompressedInputStates
		{
			get => GetProperty(ref _compressedInputStates);
			set => SetProperty(ref _compressedInputStates, value);
		}

		[Ordinal(2)] 
		[RED("firstFrameId")] 
		public CUInt32 FirstFrameId
		{
			get => GetProperty(ref _firstFrameId);
			set => SetProperty(ref _firstFrameId, value);
		}

		[Ordinal(3)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetProperty(ref _replicationTime);
			set => SetProperty(ref _replicationTime, value);
		}
	}
}
