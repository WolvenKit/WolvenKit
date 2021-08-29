using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableSystemSetBackpackFilter : gameScriptableSystemRequest
	{
		private CInt32 _filterMode;

		[Ordinal(0)] 
		[RED("filterMode")] 
		public CInt32 FilterMode
		{
			get => GetProperty(ref _filterMode);
			set => SetProperty(ref _filterMode, value);
		}
	}
}
