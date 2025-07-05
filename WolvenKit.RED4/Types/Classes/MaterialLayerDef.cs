using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MaterialLayerDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("colorPalette")] 
		public CArray<CColor> ColorPalette
		{
			get => GetPropertyValue<CArray<CColor>>();
			set => SetPropertyValue<CArray<CColor>>(value);
		}

		[Ordinal(3)] 
		[RED("material")] 
		public CResourceReference<CMaterialInstance> Material
		{
			get => GetPropertyValue<CResourceReference<CMaterialInstance>>();
			set => SetPropertyValue<CResourceReference<CMaterialInstance>>(value);
		}

		public MaterialLayerDef()
		{
			ColorPalette = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
