using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackpackFilterButtonSpawnedCallbackData : IScriptable
	{
		private CEnum<ItemFilterCategory> _category;
		private CInt32 _savedFilter;

		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<ItemFilterCategory> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(1)] 
		[RED("savedFilter")] 
		public CInt32 SavedFilter
		{
			get => GetProperty(ref _savedFilter);
			set => SetProperty(ref _savedFilter, value);
		}
	}
}
