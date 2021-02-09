using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SSoundData : CVariable
	{
		[Ordinal(0)]  [RED("widgetAudioName")] public CName WidgetAudioName { get; set; }
		[Ordinal(1)]  [RED("onPressKey")] public CName OnPressKey { get; set; }
		[Ordinal(2)]  [RED("onReleaseKey")] public CName OnReleaseKey { get; set; }
		[Ordinal(3)]  [RED("onHoverOverKey")] public CName OnHoverOverKey { get; set; }
		[Ordinal(4)]  [RED("onHoverOutKey")] public CName OnHoverOutKey { get; set; }

		public SSoundData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
