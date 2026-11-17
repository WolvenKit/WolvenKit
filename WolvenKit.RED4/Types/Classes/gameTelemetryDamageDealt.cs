using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryDamageDealt : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("situation")] 
		public CEnum<gameTelemetryDamageSituation> Situation
		{
			get => GetPropertyValue<CEnum<gameTelemetryDamageSituation>>();
			set => SetPropertyValue<CEnum<gameTelemetryDamageSituation>>(value);
		}

		[Ordinal(1)] 
		[RED("damage")] 
		public gameTelemetryDamage Damage
		{
			get => GetPropertyValue<gameTelemetryDamage>();
			set => SetPropertyValue<gameTelemetryDamage>(value);
		}

		[Ordinal(2)] 
		[RED("enemy")] 
		public gameTelemetryEnemy Enemy
		{
			get => GetPropertyValue<gameTelemetryEnemy>();
			set => SetPropertyValue<gameTelemetryEnemy>(value);
		}

		public gameTelemetryDamageDealt()
		{
			Damage = new gameTelemetryDamage();
			Enemy = new gameTelemetryEnemy();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
