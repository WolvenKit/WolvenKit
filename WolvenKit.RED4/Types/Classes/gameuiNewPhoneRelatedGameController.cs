using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiNewPhoneRelatedGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("isNewPhoneEnabled")] 
		public CBool IsNewPhoneEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiNewPhoneRelatedGameController()
		{
			IsNewPhoneEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
