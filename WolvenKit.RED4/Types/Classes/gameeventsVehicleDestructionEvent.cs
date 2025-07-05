using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsVehicleDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetPropertyValue<CHandle<gamedamageAttackData>>();
			set => SetPropertyValue<CHandle<gamedamageAttackData>>(value);
		}

		[Ordinal(1)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("hitComponent")] 
		public CWeakHandle<entIPlacedComponent> HitComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		public gameeventsVehicleDestructionEvent()
		{
			HitPosition = new Vector4 { W = 1.000000F };
			HitDirection = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
