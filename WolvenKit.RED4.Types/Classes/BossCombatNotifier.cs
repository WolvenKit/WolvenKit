using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BossCombatNotifier : redEvent
	{
		private CWeakHandle<entEntity> _bossEntity;
		private CBool _combatEnded;

		[Ordinal(0)] 
		[RED("bossEntity")] 
		public CWeakHandle<entEntity> BossEntity
		{
			get => GetProperty(ref _bossEntity);
			set => SetProperty(ref _bossEntity, value);
		}

		[Ordinal(1)] 
		[RED("combatEnded")] 
		public CBool CombatEnded
		{
			get => GetProperty(ref _combatEnded);
			set => SetProperty(ref _combatEnded, value);
		}
	}
}
