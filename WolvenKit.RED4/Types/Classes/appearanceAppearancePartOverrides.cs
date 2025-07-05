using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceAppearancePartOverrides : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partResource")] 
		public CResourceAsyncReference<entEntityTemplate> PartResource
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(1)] 
		[RED("componentsOverrides")] 
		public CArray<appearancePartComponentOverrides> ComponentsOverrides
		{
			get => GetPropertyValue<CArray<appearancePartComponentOverrides>>();
			set => SetPropertyValue<CArray<appearancePartComponentOverrides>>(value);
		}

		public appearanceAppearancePartOverrides()
		{
			ComponentsOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
