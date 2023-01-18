using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entContextualLookAtAddEvent : entLookAtAddEvent
	{
		[Ordinal(4)] 
		[RED("contextName")] 
		public CName ContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entContextualLookAtAddEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
