using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(124)] 
		[RED("itemTweakDBString")] 
		public CName ItemTweakDBString
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public C4ControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
