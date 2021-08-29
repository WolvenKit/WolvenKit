using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialLayerDef : RedBaseClass
	{
		private CName _name;
		private CUInt32 _size;
		private CArray<CColor> _colorPalette;
		private CResourceReference<CMaterialInstance> _material;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(2)] 
		[RED("colorPalette")] 
		public CArray<CColor> ColorPalette
		{
			get => GetProperty(ref _colorPalette);
			set => SetProperty(ref _colorPalette, value);
		}

		[Ordinal(3)] 
		[RED("material")] 
		public CResourceReference<CMaterialInstance> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}
	}
}
