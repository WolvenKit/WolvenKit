using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryDamageDealt : CVariable
	{
		private CEnum<gameTelemetryDamageSituation> _situation;
		private gameTelemetryDamage _damage;
		private gameTelemetryEnemy _enemy;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("damage")] 
		public gameTelemetryDamage Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (gameTelemetryDamage) CR2WTypeManager.Create("gameTelemetryDamage", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public gameTelemetryDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
