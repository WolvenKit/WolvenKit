using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CTerrainSetup : CResource
	{
		private CArray<CFloat> _tiling;
		private CArray<CName> _physicalMaterial;

		[Ordinal(1)] 
		[RED("tiling")] 
		public CArray<CFloat> Tiling
		{
			get => GetProperty(ref _tiling);
			set => SetProperty(ref _tiling, value);
		}

		[Ordinal(2)] 
		[RED("physicalMaterial")] 
		public CArray<CName> PhysicalMaterial
		{
			get => GetProperty(ref _physicalMaterial);
			set => SetProperty(ref _physicalMaterial, value);
		}
	}
}
