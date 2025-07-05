using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animVisualTagCondition : animIStaticCondition
	{
		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animVisualTagCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
