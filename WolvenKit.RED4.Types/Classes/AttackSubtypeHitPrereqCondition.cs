using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetPropertyValue<CEnum<gamedataAttackSubtype>>();
			set => SetPropertyValue<CEnum<gamedataAttackSubtype>>(value);
		}
	}
}
