using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetQuickHackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CName QuickHackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetQuickHackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
