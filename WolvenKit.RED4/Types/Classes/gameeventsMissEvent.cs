using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsMissEvent : redEvent
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
		[RED("attackPentration")] 
		public CFloat AttackPentration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("hasPiercedTechSurface")] 
		public CBool HasPiercedTechSurface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("attackComputed")] 
		public CHandle<gameAttackComputed> AttackComputed
		{
			get => GetPropertyValue<CHandle<gameAttackComputed>>();
			set => SetPropertyValue<CHandle<gameAttackComputed>>(value);
		}

		public gameeventsMissEvent()
		{
			HitPosition = new Vector4 { W = 1.000000F };
			HitDirection = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
