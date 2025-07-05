using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetPropertyValue<CEnum<gamedataAttackSubtype>>();
			set => SetPropertyValue<CEnum<gamedataAttackSubtype>>(value);
		}

		public AttackSubtypeHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
