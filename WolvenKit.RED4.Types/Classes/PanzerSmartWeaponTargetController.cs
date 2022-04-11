using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PanzerSmartWeaponTargetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PanzerSmartWeaponTargetController()
		{
			DistanceText = new();
		}
	}
}
