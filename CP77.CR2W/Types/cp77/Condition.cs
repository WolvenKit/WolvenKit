using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Condition : CVariable
	{
		[Ordinal(0)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(1)]  [RED("passed")] public CBool Passed { get; set; }

		public Condition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
