using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent : ISerializable
	{
		[Ordinal(0)]  [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)]  [RED("startFrame")] public CUInt32 StartFrame { get; set; }

		public animAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
