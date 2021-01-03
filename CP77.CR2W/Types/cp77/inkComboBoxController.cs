using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ComboBoxVisibleChanged")] public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged { get; set; }
		[Ordinal(1)]  [RED("comboBoxObjectRef")] public inkWidgetReference ComboBoxObjectRef { get; set; }

		public inkComboBoxController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
