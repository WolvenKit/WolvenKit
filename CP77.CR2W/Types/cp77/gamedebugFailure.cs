using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailure : ISerializable
	{
		[Ordinal(0)]  [RED("id")] public gamedebugFailureId Id { get; set; }
		[Ordinal(1)]  [RED("time")] public CFloat Time { get; set; }
		[Ordinal(2)]  [RED("message")] public CString Message { get; set; }
		[Ordinal(3)]  [RED("path")] public gameDebugPath Path { get; set; }
		[Ordinal(4)]  [RED("previous")] public CHandle<gamedebugFailure> Previous { get; set; }
		[Ordinal(5)]  [RED("cause")] public CHandle<gamedebugFailure> Cause { get; set; }

		public gamedebugFailure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
