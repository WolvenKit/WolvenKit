using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CraftingNotificationQueue()
		{
			Duration = 2.000000F;
		}
	}
}
