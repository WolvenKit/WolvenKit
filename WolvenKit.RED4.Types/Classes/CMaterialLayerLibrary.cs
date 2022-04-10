using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialLayerLibrary : CResource
	{
		[Ordinal(1)] 
		[RED("uvTiling")] 
		public CFloat UvTiling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("mbTiling")] 
		public CFloat MbTiling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("microblendContrast")] 
		public CFloat MicroblendContrast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("paletteColorIndex")] 
		public CUInt32 PaletteColorIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("layers")] 
		public CArray<MaterialLayerDef> Layers
		{
			get => GetPropertyValue<CArray<MaterialLayerDef>>();
			set => SetPropertyValue<CArray<MaterialLayerDef>>(value);
		}

		[Ordinal(6)] 
		[RED("microblends")] 
		public CArray<MicroblendDef> Microblends
		{
			get => GetPropertyValue<CArray<MicroblendDef>>();
			set => SetPropertyValue<CArray<MicroblendDef>>(value);
		}

		public CMaterialLayerLibrary()
		{
			UvTiling = 1.000000F;
			MbTiling = 4.000000F;
			MicroblendContrast = 1.000000F;
			Layers = new();
			Microblends = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
