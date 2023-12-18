using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDriverCombatMountedMissileLauncherCrosshairGameController : gameuiCrosshairBaseGameController
	{
		[Ordinal(29)] 
		[RED("lockingAnimationWidget")] 
		public inkWidgetReference LockingAnimationWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("psmTrackedTargetChangedCallback")] 
		public CHandle<redCallbackObject> PsmTrackedTargetChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("currentTarget")] 
		public CWeakHandle<entIPlacedComponent> CurrentTarget
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		public gameuiDriverCombatMountedMissileLauncherCrosshairGameController()
		{
			LockingAnimationWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
