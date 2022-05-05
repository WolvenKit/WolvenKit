using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TurretRipOffEvents : TurretTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<TurretInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<TurretInitData>>();
			set => SetPropertyValue<CWeakHandle<TurretInitData>>(value);
		}

		public TurretRipOffEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
