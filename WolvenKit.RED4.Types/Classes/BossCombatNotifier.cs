using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BossCombatNotifier : redEvent
	{
		[Ordinal(0)] 
		[RED("bossEntity")] 
		public CWeakHandle<entEntity> BossEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("combatEnded")] 
		public CBool CombatEnded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BossCombatNotifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
