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
			get => GetProperty(ref _characterRecord);
			set => SetProperty(ref _characterRecord, value);
		}

		[Ordinal(1)] 
		[RED("enemyAffiliation")] 
		public CString EnemyAffiliation
		{
			get => GetProperty(ref _enemyAffiliation);
			set => SetProperty(ref _enemyAffiliation, value);
		}

		[Ordinal(2)] 
		[RED("enemy")] 
		public wCHandle<gameObject> Enemy
		{
			get => GetProperty(ref _enemy);
			set => SetProperty(ref _enemy, value);
		}

		[Ordinal(3)] 
		[RED("enemyEntityID")] 
		public entEntityID EnemyEntityID
		{
			get => GetProperty(ref _enemyEntityID);
			set => SetProperty(ref _enemyEntityID, value);
		}

		[Ordinal(4)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get => GetProperty(ref _archetype);
			set => SetProperty(ref _archetype, value);
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public gameTelemetryEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
