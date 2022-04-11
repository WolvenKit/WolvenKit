using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UIInGameNotificationQueue()
		{
			Duration = 5.000000F;
		}
	}
}
