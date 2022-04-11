using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<InventoryStatsController> Controller
		{
			get => GetPropertyValue<CWeakHandle<InventoryStatsController>>();
			set => SetPropertyValue<CWeakHandle<InventoryStatsController>>(value);
		}
	}
}
