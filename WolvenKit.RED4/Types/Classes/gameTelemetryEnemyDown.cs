using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryEnemyDown : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enemy")] 
		public gameTelemetryEnemy Enemy
		{
			get => GetPropertyValue<gameTelemetryEnemy>();
			set => SetPropertyValue<gameTelemetryEnemy>(value);
		}

		[Ordinal(1)] 
		[RED("situation")] 
		public CEnum<gameTelemetryDamageSituation> Situation
		{
			get => GetPropertyValue<CEnum<gameTelemetryDamageSituation>>();
			set => SetPropertyValue<CEnum<gameTelemetryDamageSituation>>(value);
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetPropertyValue<CEnum<gameKillType>>();
			set => SetPropertyValue<CEnum<gameKillType>>(value);
		}

		public gameTelemetryEnemyDown()
		{
			Enemy = new() { EnemyEntityID = new(), Archetype = Enums.gamedataArchetypeType.Invalid, Level = -1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
