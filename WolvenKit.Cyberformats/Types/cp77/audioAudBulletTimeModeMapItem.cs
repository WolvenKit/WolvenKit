using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("enterEvent")] public CName EnterEvent { get; set; }
		[Ordinal(2)] [RED("exitEvent")] public CName ExitEvent { get; set; }
		[Ordinal(3)] [RED("timeModeRTPC")] public CName TimeModeRTPC { get; set; }

		public audioAudBulletTimeModeMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
