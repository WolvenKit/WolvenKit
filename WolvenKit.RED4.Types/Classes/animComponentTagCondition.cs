using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animComponentTagCondition : animIStaticCondition
	{
		[Ordinal(0)] 
		[RED("animTag")] 
		public CName AnimTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
