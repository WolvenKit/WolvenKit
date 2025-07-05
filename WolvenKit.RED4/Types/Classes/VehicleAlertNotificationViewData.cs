using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleAlertNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
