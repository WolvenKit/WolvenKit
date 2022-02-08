using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("introAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}
	}
}
