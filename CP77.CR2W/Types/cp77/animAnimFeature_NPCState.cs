using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_NPCState : animAnimFeature
	{
		[Ordinal(0)]  [RED("state")] public CInt32 State { get; set; }

		public animAnimFeature_NPCState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
