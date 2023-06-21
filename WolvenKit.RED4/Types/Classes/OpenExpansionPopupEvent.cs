using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenExpansionPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("forcibly")] 
		public CBool Forcibly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("showThankYou")] 
		public CBool ShowThankYou
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OpenExpansionPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
