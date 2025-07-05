using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenExpansionPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<ExpansionPopupType> Type
		{
			get => GetPropertyValue<CEnum<ExpansionPopupType>>();
			set => SetPropertyValue<CEnum<ExpansionPopupType>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("forcibly")] 
		public CBool Forcibly
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
