using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairWeaponStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<BaseTechCrosshairController> Controller
		{
			get => GetPropertyValue<CWeakHandle<BaseTechCrosshairController>>();
			set => SetPropertyValue<CWeakHandle<BaseTechCrosshairController>>(value);
		}
	}
}
