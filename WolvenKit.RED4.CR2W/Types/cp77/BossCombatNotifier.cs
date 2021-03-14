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
			get
			{
				if (_bossEntity == null)
				{
					_bossEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "bossEntity", cr2w, this);
				}
				return _bossEntity;
			}
			set
			{
				if (_bossEntity == value)
				{
					return;
				}
				_bossEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("combatEnded")] 
		public CBool CombatEnded
		{
			get
			{
				if (_combatEnded == null)
				{
					_combatEnded = (CBool) CR2WTypeManager.Create("Bool", "combatEnded", cr2w, this);
				}
				return _combatEnded;
			}
			set
			{
				if (_combatEnded == value)
				{
					return;
				}
				_combatEnded = value;
				PropertySet(this);
			}
		}

		public BossCombatNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
