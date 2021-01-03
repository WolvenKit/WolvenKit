using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegion : ISerializable
	{
		[Ordinal(0)]  [RED("isStretch")] public CBool IsStretch { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("regionParts")] public CArray<rendTextureRegionPart> RegionParts { get; set; }

		public rendTextureRegion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
