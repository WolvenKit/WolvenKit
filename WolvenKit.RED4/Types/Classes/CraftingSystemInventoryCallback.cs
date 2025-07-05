using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingSystemInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public CraftingSystemInventoryCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
