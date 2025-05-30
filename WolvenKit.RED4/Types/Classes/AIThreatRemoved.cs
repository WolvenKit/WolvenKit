using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIThreatRemoved : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<entEntity> Owner
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(4)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isEnemy")] 
		public CBool IsEnemy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("distanceBasedInstantDrop")] 
		public CBool DistanceBasedInstantDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIThreatRemoved()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
