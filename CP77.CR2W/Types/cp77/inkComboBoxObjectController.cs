using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxObjectController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("colliderRef")] public inkShapeWidgetReference ColliderRef { get; set; }
		[Ordinal(1)]  [RED("contentWidgetRef")] public inkWidgetReference ContentWidgetRef { get; set; }
		[Ordinal(2)]  [RED("offset")] public inkMargin Offset { get; set; }
		[Ordinal(3)]  [RED("placeholderOffsetWidgetRef")] public inkWidgetReference PlaceholderOffsetWidgetRef { get; set; }

		public inkComboBoxObjectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
