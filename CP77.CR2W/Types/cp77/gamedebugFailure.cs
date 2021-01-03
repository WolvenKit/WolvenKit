using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailure : ISerializable
	{
		[Ordinal(0)]  [RED("cause")] public CHandle<gamedebugFailure> Cause { get; set; }
		[Ordinal(1)]  [RED("id")] public gamedebugFailureId Id { get; set; }
		[Ordinal(2)]  [RED("message")] public CString Message { get; set; }
		[Ordinal(3)]  [RED("path")] public gameDebugPath Path { get; set; }
		[Ordinal(4)]  [RED("previous")] public CHandle<gamedebugFailure> Previous { get; set; }
		[Ordinal(5)]  [RED("time")] public CFloat Time { get; set; }

		public gamedebugFailure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
