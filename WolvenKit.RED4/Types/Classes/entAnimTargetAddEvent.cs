using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimTargetAddEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetPropertyValue<CHandle<entIPositionProvider>>();
			set => SetPropertyValue<CHandle<entIPositionProvider>>(value);
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entAnimTargetAddEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
