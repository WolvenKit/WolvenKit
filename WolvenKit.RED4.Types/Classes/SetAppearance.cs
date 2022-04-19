using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAppearance : AIActionHelperTask
	{
		[Ordinal(5)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
