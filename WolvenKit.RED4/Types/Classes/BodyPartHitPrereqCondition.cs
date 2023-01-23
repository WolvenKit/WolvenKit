using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BodyPartHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetPropertyValue<CEnum<gamedataAttackSubtype>>();
			set => SetPropertyValue<CEnum<gamedataAttackSubtype>>(value);
		}

		public BodyPartHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
