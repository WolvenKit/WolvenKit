using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveAd : InteractiveDevice
	{
		[Ordinal(0)]  [RED("aduiComponent")] public CHandle<WorldWidgetComponent> AduiComponent { get; set; }
		[Ordinal(1)]  [RED("showAd")] public CBool ShowAd { get; set; }
		[Ordinal(2)]  [RED("showVendor")] public CBool ShowVendor { get; set; }
		[Ordinal(3)]  [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(4)]  [RED("triggerExitComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent { get; set; }

		public InteractiveAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
