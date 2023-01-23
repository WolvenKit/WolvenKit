using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemSetBackpackSorting : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("sortMode")] 
		public CInt32 SortMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UIScriptableSystemSetBackpackSorting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
