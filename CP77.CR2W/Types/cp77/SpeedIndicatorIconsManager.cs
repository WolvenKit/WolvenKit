using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("mirroredSpeedIndicator")] public inkImageWidgetReference MirroredSpeedIndicator { get; set; }
		[Ordinal(1)]  [RED("speedIndicator")] public inkImageWidgetReference SpeedIndicator { get; set; }

		public SpeedIndicatorIconsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
