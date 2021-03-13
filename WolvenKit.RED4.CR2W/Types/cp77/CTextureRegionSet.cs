using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTextureRegionSet : CResource
	{
		[Ordinal(1)] [RED("regions")] public CArray<rendTextureRegion> Regions { get; set; }

		public CTextureRegionSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
