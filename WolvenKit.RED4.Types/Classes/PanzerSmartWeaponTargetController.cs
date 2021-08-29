using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PanzerSmartWeaponTargetController : inkWidgetLogicController
	{
		private inkTextWidgetReference _distanceText;
		private CHandle<inkanimProxy> _lockingAnimationProxy;

		[Ordinal(1)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get => GetProperty(ref _distanceText);
			set => SetProperty(ref _distanceText, value);
		}

		[Ordinal(2)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetProperty(ref _lockingAnimationProxy);
			set => SetProperty(ref _lockingAnimationProxy, value);
		}
	}
}
