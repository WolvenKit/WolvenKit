using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FireFXEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sFX")] 
		public CName SFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("vFX")] 
		public CName VFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public FireFXEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
