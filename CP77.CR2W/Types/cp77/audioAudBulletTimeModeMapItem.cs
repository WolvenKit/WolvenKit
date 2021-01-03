using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("enterEvent")] public CName EnterEvent { get; set; }
		[Ordinal(1)]  [RED("exitEvent")] public CName ExitEvent { get; set; }
		[Ordinal(2)]  [RED("timeModeRTPC")] public CName TimeModeRTPC { get; set; }

		public audioAudBulletTimeModeMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
