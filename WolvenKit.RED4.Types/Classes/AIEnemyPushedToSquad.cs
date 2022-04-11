using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIEnemyPushedToSquad : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public AIEnemyPushedToSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
