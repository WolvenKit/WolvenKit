using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("targetType")] 
		public CName TargetType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TargetTypeHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
