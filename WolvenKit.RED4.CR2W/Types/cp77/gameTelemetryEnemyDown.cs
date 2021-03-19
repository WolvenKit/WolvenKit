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

		public gameTelemetryEnemyDown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
