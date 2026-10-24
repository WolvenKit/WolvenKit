using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocConfirmationPopupCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GlamdocConfirmationPopupCloseData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
