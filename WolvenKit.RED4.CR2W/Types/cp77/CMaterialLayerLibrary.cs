using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialLayerLibrary : CResource
	{
		private CFloat _uvTiling;
		private CFloat _mbTiling;
		private CFloat _microblendContrast;
		private CUInt32 _paletteColorIndex;
		private CArray<MaterialLayerDef> _layers;
		private CArray<MicroblendDef> _microblends;

		[Ordinal(1)] 
		[RED("uvTiling")] 
		public CFloat UvTiling
		{
			get => GetProperty(ref _uvTiling);
			set => SetProperty(ref _uvTiling, value);
		}

		[Ordinal(2)] 
		[RED("mbTiling")] 
		public CFloat MbTiling
		{
			get => GetProperty(ref _mbTiling);
			set => SetProperty(ref _mbTiling, value);
		}

		[Ordinal(3)] 
		[RED("microblendContrast")] 
		public CFloat MicroblendContrast
		{
			get => GetProperty(ref _microblendContrast);
			set => SetProperty(ref _microblendContrast, value);
		}

		[Ordinal(4)] 
		[RED("paletteColorIndex")] 
		public CUInt32 PaletteColorIndex
		{
			get => GetProperty(ref _paletteColorIndex);
			set => SetProperty(ref _paletteColorIndex, value);
		}

		[Ordinal(5)] 
		[RED("layers")] 
		public CArray<MaterialLayerDef> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		[Ordinal(6)] 
		[RED("microblends")] 
		public CArray<MicroblendDef> Microblends
		{
			get => GetProperty(ref _microblends);
			set => SetProperty(ref _microblends, value);
		}

		public CMaterialLayerLibrary(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
