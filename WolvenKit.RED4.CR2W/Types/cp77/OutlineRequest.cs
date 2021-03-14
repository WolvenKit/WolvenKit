using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequest : IScriptable
	{
		[Ordinal(0)] [RED("requester")] public CName Requester { get; set; }
		[Ordinal(1)] [RED("shouldAdd")] public CBool ShouldAdd { get; set; }
		[Ordinal(2)] [RED("outlineDuration")] public CFloat OutlineDuration { get; set; }
		[Ordinal(3)] [RED("outlineData")] public OutlineData OutlineData { get; set; }

		public OutlineRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
