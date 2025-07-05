using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeUIAnimEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChangeUIAnimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
