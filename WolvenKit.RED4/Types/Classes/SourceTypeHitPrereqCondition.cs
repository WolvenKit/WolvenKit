using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SourceTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SourceTypeHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
