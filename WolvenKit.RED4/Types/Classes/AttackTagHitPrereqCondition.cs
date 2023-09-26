using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttackTagHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("attackTag")] 
		public CName AttackTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AttackTagHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
