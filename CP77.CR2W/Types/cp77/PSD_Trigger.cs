using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PSD_Trigger : gameObject
	{
		[Ordinal(31)]  [RED("ref")] public NodeRef Ref { get; set; }
		[Ordinal(32)]  [RED("className")] public CName ClassName { get; set; }

		public PSD_Trigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
