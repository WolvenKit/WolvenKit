using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimGraphDebugState : ISerializable
	{
		[Ordinal(0)] [RED("nodes")] public CArray<animAnimNodeDebugState> Nodes { get; set; }

		public animAnimGraphDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
