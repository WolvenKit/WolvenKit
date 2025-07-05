using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIEntityLost : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("spotter")] 
		public CWeakHandle<entEntity> Spotter
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("spotted")] 
		public CWeakHandle<entEntity> Spotted
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

		public AIEntityLost()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
