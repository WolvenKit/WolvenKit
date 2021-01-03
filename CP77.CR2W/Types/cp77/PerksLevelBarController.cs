using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerksLevelBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("backgroundImage")] public inkWidgetReference BackgroundImage { get; set; }
		[Ordinal(1)]  [RED("foregroundImage")] public inkWidgetReference ForegroundImage { get; set; }

		public PerksLevelBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
