using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InstigatorTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("instigatorType")] 
		public CName InstigatorType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
