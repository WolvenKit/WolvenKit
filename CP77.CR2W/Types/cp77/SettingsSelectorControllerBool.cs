using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerBool : inkSettingsSelectorController
	{
		[Ordinal(15)] [RED("onState")] public inkWidgetReference OnState { get; set; }
		[Ordinal(16)] [RED("offState")] public inkWidgetReference OffState { get; set; }
		[Ordinal(17)] [RED("onStateBody")] public inkWidgetReference OnStateBody { get; set; }
		[Ordinal(18)] [RED("offStateBody")] public inkWidgetReference OffStateBody { get; set; }

		public SettingsSelectorControllerBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
