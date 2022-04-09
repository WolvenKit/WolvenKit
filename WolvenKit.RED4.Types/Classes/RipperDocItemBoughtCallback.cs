using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperDocItemBoughtCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("eventTarget")] 
		public CWeakHandle<RipperDocGameController> EventTarget
		{
			get => GetPropertyValue<CWeakHandle<RipperDocGameController>>();
			set => SetPropertyValue<CWeakHandle<RipperDocGameController>>(value);
		}

		public RipperDocItemBoughtCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
