using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCollisionGroupEntry : CVariable
	{
		[Ordinal(0)]  [RED("Reversed")] public CBool Reversed { get; set; }
		[Ordinal(1)]  [RED("neRef")] public NodeRef NeRef { get; set; }

		public worldCollisionGroupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
