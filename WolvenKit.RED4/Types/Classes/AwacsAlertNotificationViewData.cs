using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AwacsAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AwacsAlertNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
