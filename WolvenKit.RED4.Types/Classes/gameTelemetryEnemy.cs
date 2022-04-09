using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryEnemy : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("characterRecord")] 
		public TweakDBID CharacterRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("enemyAffiliation")] 
		public CString EnemyAffiliation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("enemy")] 
		public CWeakHandle<gameObject> Enemy
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("enemyEntityID")] 
		public entEntityID EnemyEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get => GetPropertyValue<CEnum<gamedataArchetypeType>>();
			set => SetPropertyValue<CEnum<gamedataArchetypeType>>(value);
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameTelemetryEnemy()
		{
			EnemyEntityID = new();
			Archetype = Enums.gamedataArchetypeType.Invalid;
			Level = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
