using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootPickupDelayEvent : redEvent
	{
		private CBool _enableLootInteraction;

		[Ordinal(0)] 
		[RED("enableLootInteraction")] 
		public CBool EnableLootInteraction
		{
			get => GetProperty(ref _enableLootInteraction);
			set => SetProperty(ref _enableLootInteraction, value);
		}
	}
}
