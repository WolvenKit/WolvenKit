using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsVisualTagsDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public toolsVisualTagsDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
