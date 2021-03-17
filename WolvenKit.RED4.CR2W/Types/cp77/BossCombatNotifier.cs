using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossCombatNotifier : redEvent
	{
		private wCHandle<entEntity> _bossEntity;
		private CBool _combatEnded;

		[Ordinal(0)] 
		[RED("bossEntity")] 
		public wCHandle<entEntity> BossEntity
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

		public BossCombatNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
