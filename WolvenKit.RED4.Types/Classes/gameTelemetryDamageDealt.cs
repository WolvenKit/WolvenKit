using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTelemetryDamageDealt : RedBaseClass
	{
		private CEnum<gameTelemetryDamageSituation> _situation;
		private gameTelemetryDamage _damage;
		private gameTelemetryEnemy _enemy;

		[Ordinal(0)] 
		[RED("situation")] 
		public CEnum<gameTelemetryDamageSituation> Situation
		{
			get => GetProperty(ref _situation);
			set => SetProperty(ref _situation, value);
		}

		[Ordinal(1)] 
		[RED("damage")] 
		public gameTelemetryDamage Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		[Ordinal(2)] 
		[RED("enemy")] 
		public gameTelemetryEnemy Enemy
		{
			get => GetProperty(ref _enemy);
			set => SetProperty(ref _enemy, value);
		}
	}
}
