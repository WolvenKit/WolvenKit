using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("dps")] 
		public CWeakHandle<DropPointSystem> Dps
		{
			get => GetPropertyValue<CWeakHandle<DropPointSystem>>();
			set => SetPropertyValue<CWeakHandle<DropPointSystem>>(value);
		}

		public DropPointCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
