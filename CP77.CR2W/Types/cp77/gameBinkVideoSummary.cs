using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoSummary : CVariable
	{
		[Ordinal(0)]  [RED("currentFrame")] public CUInt32 CurrentFrame { get; set; }
		[Ordinal(1)]  [RED("currentTimeMs")] public CUInt32 CurrentTimeMs { get; set; }
		[Ordinal(2)]  [RED("frameRate")] public CUInt32 FrameRate { get; set; }
		[Ordinal(3)]  [RED("totalFrames")] public CUInt32 TotalFrames { get; set; }
		[Ordinal(4)]  [RED("totalTimeMs")] public CUInt32 TotalTimeMs { get; set; }

		public gameBinkVideoSummary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
