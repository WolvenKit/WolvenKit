using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceAppearancePart : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<entEntityTemplate> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		public appearanceAppearancePart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
