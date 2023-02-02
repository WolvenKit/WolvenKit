using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCacheKey : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("key")] 
		public physicsGeometryKey Key
		{
			get => GetPropertyValue<physicsGeometryKey>();
			set => SetPropertyValue<physicsGeometryKey>(value);
		}

		[Ordinal(1)] 
		[RED("entryIndex")] 
		public CUInt32 EntryIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public physicsCacheKey()
		{
			Key = new() { Pe = 6, Ta = new(12) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
