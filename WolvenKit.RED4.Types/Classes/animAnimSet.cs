using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSet : CResource
	{
		private CArray<CHandle<animAnimSetEntry>> _animations;
		private CArray<animAnimDataChunk> _animationDataChunks;
		private CArray<CUInt16> _fallbackDataAddresses;
		private CArray<CUInt8> _fallbackDataAddressIndexes;
		private CArray<animAnimFallbackFrameDesc> _fallbackAnimFrameDescs;
		private CArray<CUInt8> _fallbackAnimDescIndexes;
		private DataBuffer _fallbackAnimDataBuffer;
		private CUInt16 _fallbackNumPositionData;
		private CUInt16 _fallbackNumRotationData;
		private CResourceReference<animRig> _rig;
		private redTagList _tags;
		private CResourceReference<CResource> _correspondingArchetype;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<CHandle<animAnimSetEntry>> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(2)] 
		[RED("animationDataChunks")] 
		public CArray<animAnimDataChunk> AnimationDataChunks
		{
			get => GetProperty(ref _animationDataChunks);
			set => SetProperty(ref _animationDataChunks, value);
		}

		[Ordinal(3)] 
		[RED("fallbackDataAddresses")] 
		public CArray<CUInt16> FallbackDataAddresses
		{
			get => GetProperty(ref _fallbackDataAddresses);
			set => SetProperty(ref _fallbackDataAddresses, value);
		}

		[Ordinal(4)] 
		[RED("fallbackDataAddressIndexes")] 
		public CArray<CUInt8> FallbackDataAddressIndexes
		{
			get => GetProperty(ref _fallbackDataAddressIndexes);
			set => SetProperty(ref _fallbackDataAddressIndexes, value);
		}

		[Ordinal(5)] 
		[RED("fallbackAnimFrameDescs")] 
		public CArray<animAnimFallbackFrameDesc> FallbackAnimFrameDescs
		{
			get => GetProperty(ref _fallbackAnimFrameDescs);
			set => SetProperty(ref _fallbackAnimFrameDescs, value);
		}

		[Ordinal(6)] 
		[RED("fallbackAnimDescIndexes")] 
		public CArray<CUInt8> FallbackAnimDescIndexes
		{
			get => GetProperty(ref _fallbackAnimDescIndexes);
			set => SetProperty(ref _fallbackAnimDescIndexes, value);
		}

		[Ordinal(7)] 
		[RED("fallbackAnimDataBuffer")] 
		public DataBuffer FallbackAnimDataBuffer
		{
			get => GetProperty(ref _fallbackAnimDataBuffer);
			set => SetProperty(ref _fallbackAnimDataBuffer, value);
		}

		[Ordinal(8)] 
		[RED("fallbackNumPositionData")] 
		public CUInt16 FallbackNumPositionData
		{
			get => GetProperty(ref _fallbackNumPositionData);
			set => SetProperty(ref _fallbackNumPositionData, value);
		}

		[Ordinal(9)] 
		[RED("fallbackNumRotationData")] 
		public CUInt16 FallbackNumRotationData
		{
			get => GetProperty(ref _fallbackNumRotationData);
			set => SetProperty(ref _fallbackNumRotationData, value);
		}

		[Ordinal(10)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(11)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(12)] 
		[RED("correspondingArchetype")] 
		public CResourceReference<CResource> CorrespondingArchetype
		{
			get => GetProperty(ref _correspondingArchetype);
			set => SetProperty(ref _correspondingArchetype, value);
		}

		[Ordinal(13)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}
	}
}
