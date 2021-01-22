using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IWorldWidgetComponent : WidgetBaseComponent
	{
		[Ordinal(0)]  [RED("glitchValue")] public CFloat GlitchValue { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("meshTargetBinding")] public CHandle<worlduiMeshTargetBinding> MeshTargetBinding { get; set; }
		[Ordinal(3)]  [RED("screenAreaMultiplier")] public CFloat ScreenAreaMultiplier { get; set; }
		[Ordinal(4)]  [RED("tintColor")] public CColor TintColor { get; set; }

		public IWorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
