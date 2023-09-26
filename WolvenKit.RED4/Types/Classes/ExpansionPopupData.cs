using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<ExpansionPopupType> Type
		{
			get => GetPropertyValue<CEnum<ExpansionPopupType>>();
			set => SetPropertyValue<CEnum<ExpansionPopupType>>(value);
		}

		[Ordinal(8)] 
		[RED("state")] 
		public CEnum<ExpansionStatus> State
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		public ExpansionPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
