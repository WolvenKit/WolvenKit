using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingSectorDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CResourceAsyncReference<worldStreamingSector> Data
		{
			get => GetPropertyValue<CResourceAsyncReference<worldStreamingSector>>();
			set => SetPropertyValue<CResourceAsyncReference<worldStreamingSector>>(value);
		}

		[Ordinal(1)] 
		[RED("streamingBox")] 
		public Box StreamingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(2)] 
		[RED("questPrefabNodeRef")] 
		public NodeRef QuestPrefabNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("numNodeRanges")] 
		public CUInt32 NumNodeRanges
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("variants")] 
		public CArray<worldStreamingSectorVariant> Variants
		{
			get => GetPropertyValue<CArray<worldStreamingSectorVariant>>();
			set => SetPropertyValue<CArray<worldStreamingSectorVariant>>(value);
		}

		[Ordinal(5)] 
		[RED("blockIndex")] 
		public worldStreamingBlockIndex BlockIndex
		{
			get => GetPropertyValue<worldStreamingBlockIndex>();
			set => SetPropertyValue<worldStreamingBlockIndex>(value);
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CUInt8 Level
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("category")] 
		public CEnum<worldStreamingSectorCategory> Category
		{
			get => GetPropertyValue<CEnum<worldStreamingSectorCategory>>();
			set => SetPropertyValue<CEnum<worldStreamingSectorCategory>>(value);
		}

		public worldStreamingSectorDescriptor()
		{
			StreamingBox = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };
			Variants = new();
			BlockIndex = new worldStreamingBlockIndex();
			Category = Enums.worldStreamingSectorCategory.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
