using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitAttackSubtypePrereq : GenericHitPrereq
	{
		[Ordinal(8)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetPropertyValue<CEnum<gamedataAttackSubtype>>();
			set => SetPropertyValue<CEnum<gamedataAttackSubtype>>(value);
		}

		public HitAttackSubtypePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
