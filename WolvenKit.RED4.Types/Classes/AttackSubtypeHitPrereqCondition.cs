using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataAttackSubtype> _attackSubtype;

		[Ordinal(1)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetProperty(ref _attackSubtype);
			set => SetProperty(ref _attackSubtype, value);
		}
	}
}
