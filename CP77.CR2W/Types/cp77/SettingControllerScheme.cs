using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingControllerScheme : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("braindanceTab")] public inkWidgetReference BraindanceTab { get; set; }
		[Ordinal(1)]  [RED("inputTab")] public inkWidgetReference InputTab { get; set; }
		[Ordinal(2)]  [RED("tabRoot")] public CHandle<TabRadioGroup> TabRoot { get; set; }
		[Ordinal(3)]  [RED("tabRootRef")] public inkWidgetReference TabRootRef { get; set; }
		[Ordinal(4)]  [RED("vehiclesTab")] public inkWidgetReference VehiclesTab { get; set; }

		public SettingControllerScheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
