using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionGroupEntry : CVariable
	{
		[Ordinal(0)] [RED("neRef")] public NodeRef NeRef { get; set; }
		[Ordinal(1)] [RED("Reversed")] public CBool Reversed { get; set; }

		public worldCollisionGroupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
