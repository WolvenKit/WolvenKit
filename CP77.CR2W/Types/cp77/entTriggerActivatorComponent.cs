using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTriggerActivatorComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("channels")] public CEnum<TriggerChannel> Channels { get; set; }
		[Ordinal(1)]  [RED("enableCCD")] public CBool EnableCCD { get; set; }
		[Ordinal(2)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(3)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(4)]  [RED("maxContinousDistance")] public CFloat MaxContinousDistance { get; set; }
		[Ordinal(5)]  [RED("radius")] public CFloat Radius { get; set; }

		public entTriggerActivatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
