using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerRange : inkSettingsSelectorController
	{
		[Ordinal(0)]  [RED("LeftArrow")] public inkWidgetReference LeftArrow { get; set; }
		[Ordinal(1)]  [RED("ProgressBar")] public inkWidgetReference ProgressBar { get; set; }
		[Ordinal(2)]  [RED("RightArrow")] public inkWidgetReference RightArrow { get; set; }
		[Ordinal(3)]  [RED("ValueText")] public inkTextWidgetReference ValueText { get; set; }

		public SettingsSelectorControllerRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
