using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		[Ordinal(8)] 
		[RED("showThankYou")] 
		public CBool ShowThankYou
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExpansionPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
