using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTelemetryEnemyDown : RedBaseClass
	{
		private gameTelemetryEnemy _enemy;
		private CEnum<gameTelemetryDamageSituation> _situation;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("enemy")] 
		public gameTelemetryEnemy Enemy
		{
			get => GetProperty(ref _enemy);
			set => SetProperty(ref _enemy, value);
		}

		[Ordinal(1)] 
		[RED("situation")] 
		public CEnum<gameTelemetryDamageSituation> Situation
		{
			get => GetProperty(ref _situation);
			set => SetProperty(ref _situation, value);
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetProperty(ref _killType);
			set => SetProperty(ref _killType, value);
		}
	}
}
