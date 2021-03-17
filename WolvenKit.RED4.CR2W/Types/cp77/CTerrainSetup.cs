using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTerrainSetup : CResource
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

		public CTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
