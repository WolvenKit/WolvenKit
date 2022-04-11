using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animVisualTagCondition : animIStaticCondition
	{
		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
