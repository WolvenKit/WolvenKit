using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackFilterButtonSpawnedCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<ItemFilterCategory> Category
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(1)] 
		[RED("savedFilter")] 
		public CInt32 SavedFilter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BackpackFilterButtonSpawnedCallbackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
