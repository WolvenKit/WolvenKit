using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("sectorIndex")] 
		public CUInt32 SectorIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldStreamingSectorDescriptor()
		{
			StreamingBox = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };
			Variants = new();
			SectorIndex = 4294967295;
		}
	}
}
