using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponSourceHasTagPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("tagToCheck")] 
		public CName TagToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public WeaponSourceHasTagPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
