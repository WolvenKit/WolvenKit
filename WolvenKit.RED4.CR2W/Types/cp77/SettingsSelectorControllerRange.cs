using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerRange : inkSettingsSelectorController
	{
		[Ordinal(15)] [RED("ValueText")] public inkTextWidgetReference ValueText { get; set; }
		[Ordinal(16)] [RED("LeftArrow")] public inkWidgetReference LeftArrow { get; set; }
		[Ordinal(17)] [RED("RightArrow")] public inkWidgetReference RightArrow { get; set; }
		[Ordinal(18)] [RED("ProgressBar")] public inkWidgetReference ProgressBar { get; set; }

		public SettingsSelectorControllerRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
