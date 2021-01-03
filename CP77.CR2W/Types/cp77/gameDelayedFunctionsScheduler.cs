using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDelayedFunctionsScheduler : ISerializable
	{
		[Ordinal(0)]  [RED("currentTime")] public EngineTime CurrentTime { get; set; }
		[Ordinal(1)]  [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(2)]  [RED("nextCallId")] public CUInt32 NextCallId { get; set; }

		public gameDelayedFunctionsScheduler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
