using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSet : CResource
	{
		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<CHandle<animAnimSetEntry>> Animations
		{
			get => GetPropertyValue<CArray<CHandle<animAnimSetEntry>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimSetEntry>>>(value);
		}

		[Ordinal(2)] 
		[RED("animationDataChunks")] 
		public CArray<animAnimDataChunk> AnimationDataChunks
		{
			get => GetPropertyValue<CArray<animAnimDataChunk>>();
			set => SetPropertyValue<CArray<animAnimDataChunk>>(value);
		}

		[Ordinal(3)] 
		[RED("fallbackDataAddresses")] 
		public CArray<CUInt16> FallbackDataAddresses
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackDataAddressIndexes")] 
		public CArray<CUInt8> FallbackDataAddressIndexes
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(5)] 
		[RED("fallbackAnimFrameDescs")] 
		public CArray<animAnimFallbackFrameDesc> FallbackAnimFrameDescs
		{
			get => GetPropertyValue<CArray<animAnimFallbackFrameDesc>>();
			set => SetPropertyValue<CArray<animAnimFallbackFrameDesc>>(value);
		}

		[Ordinal(6)] 
		[RED("fallbackAnimDescIndexes")] 
		public CArray<CUInt8> FallbackAnimDescIndexes
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(7)] 
		[RED("fallbackAnimDataBuffer")] 
		public DataBuffer FallbackAnimDataBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(8)] 
		[RED("fallbackNumPositionData")] 
		public CUInt16 FallbackNumPositionData
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(9)] 
		[RED("fallbackNumRotationData")] 
		public CUInt16 FallbackNumRotationData
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(10)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(11)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(12)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimSet()
		{
			Animations = new();
			AnimationDataChunks = new();
			FallbackDataAddresses = new();
			FallbackDataAddressIndexes = new();
			FallbackAnimFrameDescs = new();
			FallbackAnimDescIndexes = new();
			Tags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
