using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamDocItemBoughtCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("eventTarget")] 
		public CWeakHandle<GlamDocGameController> EventTarget
		{
			get => GetPropertyValue<CWeakHandle<GlamDocGameController>>();
			set => SetPropertyValue<CWeakHandle<GlamDocGameController>>(value);
		}

		public GlamDocItemBoughtCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
