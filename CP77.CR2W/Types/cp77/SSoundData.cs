using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SSoundData : CVariable
	{
		[Ordinal(0)]  [RED("onHoverOutKey")] public CName OnHoverOutKey { get; set; }
		[Ordinal(1)]  [RED("onHoverOverKey")] public CName OnHoverOverKey { get; set; }
		[Ordinal(2)]  [RED("onPressKey")] public CName OnPressKey { get; set; }
		[Ordinal(3)]  [RED("onReleaseKey")] public CName OnReleaseKey { get; set; }
		[Ordinal(4)]  [RED("widgetAudioName")] public CName WidgetAudioName { get; set; }

		public SSoundData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
