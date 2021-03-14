using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryEnemy : CVariable
	{
		private TweakDBID _characterRecord;
		private CString _enemyAffiliation;
		private wCHandle<gameObject> _enemy;
		private entEntityID _enemyEntityID;
		private CEnum<gamedataArchetypeType> _archetype;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("characterRecord")] 
		public TweakDBID CharacterRecord
		{
			get
			{
				if (_characterRecord == null)
				{
					_characterRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "characterRecord", cr2w, this);
				}
				return _characterRecord;
			}
			set
			{
				if (_characterRecord == value)
				{
					return;
				}
				_characterRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enemyAffiliation")] 
		public CString EnemyAffiliation
		{
			get
			{
				if (_enemyAffiliation == null)
				{
					_enemyAffiliation = (CString) CR2WTypeManager.Create("String", "enemyAffiliation", cr2w, this);
				}
				return _enemyAffiliation;
			}
			set
			{
				if (_enemyAffiliation == value)
				{
					return;
				}
				_enemyAffiliation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enemy")] 
		public wCHandle<gameObject> Enemy
		{
			get
			{
				if (_enemy == null)
				{
					_enemy = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "enemy", cr2w, this);
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

		[Ordinal(3)] 
		[RED("enemyEntityID")] 
		public entEntityID EnemyEntityID
		{
			get
			{
				if (_enemyEntityID == null)
				{
					_enemyEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "enemyEntityID", cr2w, this);
				}
				return _enemyEntityID;
			}
			set
			{
				if (_enemyEntityID == value)
				{
					return;
				}
				_enemyEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get
			{
				if (_archetype == null)
				{
					_archetype = (CEnum<gamedataArchetypeType>) CR2WTypeManager.Create("gamedataArchetypeType", "archetype", cr2w, this);
				}
				return _archetype;
			}
			set
			{
				if (_archetype == value)
				{
					return;
				}
				_archetype = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public gameTelemetryEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
