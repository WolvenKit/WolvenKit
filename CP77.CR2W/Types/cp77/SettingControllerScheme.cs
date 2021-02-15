using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingControllerScheme : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("tabRootRef")] public inkWidgetReference TabRootRef { get; set; }
		[Ordinal(2)] [RED("inputTab")] public inkWidgetReference InputTab { get; set; }
		[Ordinal(3)] [RED("vehiclesTab")] public inkWidgetReference VehiclesTab { get; set; }
		[Ordinal(4)] [RED("braindanceTab")] public inkWidgetReference BraindanceTab { get; set; }
		[Ordinal(5)] [RED("tabRoot")] public CHandle<TabRadioGroup> TabRoot { get; set; }

		public SettingControllerScheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
