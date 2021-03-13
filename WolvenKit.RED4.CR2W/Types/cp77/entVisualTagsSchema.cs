using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVisualTagsSchema : ISerializable
	{
		[Ordinal(0)] [RED("visualTags")] public redTagList VisualTags { get; set; }
		[Ordinal(1)] [RED("schema")] public CName Schema { get; set; }

		public entVisualTagsSchema(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
