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

		public gameTelemetryDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
