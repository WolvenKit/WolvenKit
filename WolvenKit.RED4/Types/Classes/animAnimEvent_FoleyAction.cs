using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_FoleyAction : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_FoleyAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
