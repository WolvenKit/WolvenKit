using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RipperDocItemBoughtCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<RipperDocGameController> _eventTarget;

		[Ordinal(1)] 
		[RED("eventTarget")] 
		public CWeakHandle<RipperDocGameController> EventTarget
		{
			get => GetProperty(ref _eventTarget);
			set => SetProperty(ref _eventTarget, value);
		}
	}
}
