using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTextureRegionSet : CResource
	{
		private CArray<rendTextureRegion> _regions;

		[Ordinal(1)] 
		[RED("regions")] 
		public CArray<rendTextureRegion> Regions
		{
			get => GetProperty(ref _regions);
			set => SetProperty(ref _regions, value);
		}

		public CTextureRegionSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
