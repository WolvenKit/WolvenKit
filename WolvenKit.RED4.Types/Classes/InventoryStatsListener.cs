using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatsListener : gameScriptStatsListener
	{
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<InventoryStatsController> _controller;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<InventoryStatsController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}
	}
}
