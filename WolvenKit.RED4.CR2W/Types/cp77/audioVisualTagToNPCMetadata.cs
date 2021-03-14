using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagToNPCMetadata : CVariable
	{
		[Ordinal(0)] [RED("visualTags")] public CArray<CName> VisualTags { get; set; }
		[Ordinal(1)] [RED("foleyNPCMetadata")] public CName FoleyNPCMetadata { get; set; }

		public audioVisualTagToNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
