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
		public CUInt32 BlockIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
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
			StreamingBox = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };
			Variants = new();
			BlockIndex = 4294967295;
			Category = Enums.worldStreamingSectorCategory.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
