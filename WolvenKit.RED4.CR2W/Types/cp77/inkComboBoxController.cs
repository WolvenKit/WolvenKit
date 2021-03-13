using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("comboBoxObjectRef")] public inkWidgetReference ComboBoxObjectRef { get; set; }
		[Ordinal(2)] [RED("ComboBoxVisibleChanged")] public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged { get; set; }

		public inkComboBoxController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
