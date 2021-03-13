using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
