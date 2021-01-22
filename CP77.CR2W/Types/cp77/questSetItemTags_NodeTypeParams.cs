using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetItemTags_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("addTags")] public CBool AddTags { get; set; }
		[Ordinal(1)]  [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(2)]  [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
		[Ordinal(3)]  [RED("tags")] public CEnum<gameEItemDynamicTags> Tags { get; set; }

		public questSetItemTags_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
