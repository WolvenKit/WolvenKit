using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TurretInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("turret")] 
		public CWeakHandle<gameObject> Turret
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TurretInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
