using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableSystemSetBackpackSorting : gameScriptableSystemRequest
	{
		private CInt32 _sortMode;

		[Ordinal(0)] 
		[RED("sortMode")] 
		public CInt32 SortMode
		{
			get => GetProperty(ref _sortMode);
			set => SetProperty(ref _sortMode, value);
		}
	}
}
