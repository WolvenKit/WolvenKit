using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SourceTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
