using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("speedIndicator")] public inkImageWidgetReference SpeedIndicator { get; set; }
		[Ordinal(1)]  [RED("mirroredSpeedIndicator")] public inkImageWidgetReference MirroredSpeedIndicator { get; set; }

		public SpeedIndicatorIconsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
