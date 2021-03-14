using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryEnemyDown : CVariable
	{
		private gameTelemetryEnemy _enemy;
		private CEnum<gameTelemetryDamageSituation> _situation;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("enemy")] 
		public gameTelemetryEnemy Enemy
		{
			get
			{
				if (_enemy == null)
				{
					_enemy = (gameTelemetryEnemy) CR2WTypeManager.Create("gameTelemetryEnemy", "enemy", cr2w, this);
				}
				return _enemy;
			}
			set
			{
				if (_enemy == value)
				{
					return;
				}
				_enemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("situation")] 
		public CEnum<gameTelemetryDamageSituation> Situation
		{
			get
			{
				if (_situation == null)
				{
					_situation = (CEnum<gameTelemetryDamageSituation>) CR2WTypeManager.Create("gameTelemetryDamageSituation", "situation", cr2w, this);
				}
				return _situation;
			}
			set
			{
				if (_situation == value)
				{
					return;
				}
				_situation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get
			{
				if (_killType == null)
				{
					_killType = (CEnum<gameKillType>) CR2WTypeManager.Create("gameKillType", "killType", cr2w, this);
				}
				return _killType;
			}
			set
			{
				if (_killType == value)
				{
					return;
				}
				_killType = value;
				PropertySet(this);
			}
		}

		public gameTelemetryEnemyDown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
