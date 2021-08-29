using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttackTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataAttackType> _attackType;

		[Ordinal(1)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}
	}
}
