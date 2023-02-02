using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsSetVisibility : redEvent
	{
		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CEnum<entVisibilityParamSource> Source
		{
			get => GetPropertyValue<CEnum<entVisibilityParamSource>>();
			set => SetPropertyValue<CEnum<entVisibilityParamSource>>(value);
		}

		public enteventsSetVisibility()
		{
			Visible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
