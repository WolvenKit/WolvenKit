using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceAppearancePartOverrides : RedBaseClass
	{
		private CResourceAsyncReference<entEntityTemplate> _partResource;
		private CArray<appearancePartComponentOverrides> _componentsOverrides;

		[Ordinal(0)] 
		[RED("partResource")] 
		public CResourceAsyncReference<entEntityTemplate> PartResource
		{
			get => GetProperty(ref _partResource);
			set => SetProperty(ref _partResource, value);
		}

		[Ordinal(1)] 
		[RED("componentsOverrides")] 
		public CArray<appearancePartComponentOverrides> ComponentsOverrides
		{
			get => GetProperty(ref _componentsOverrides);
			set => SetProperty(ref _componentsOverrides, value);
		}
	}
}
