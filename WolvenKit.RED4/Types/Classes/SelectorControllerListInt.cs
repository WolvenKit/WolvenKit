using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SelectorControllerListInt : SettingsSelectorControllerList
	{
		[Ordinal(20)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SelectorControllerListInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
