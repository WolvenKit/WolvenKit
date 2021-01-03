using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationVisualTaggedOverride : ISerializable
	{
		[Ordinal(0)]  [RED("represenationOverride")] public gameHitShapeContainer RepresenationOverride { get; set; }
		[Ordinal(1)]  [RED("visualTags")] public redTagList VisualTags { get; set; }

		public gameHitRepresentationVisualTaggedOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
