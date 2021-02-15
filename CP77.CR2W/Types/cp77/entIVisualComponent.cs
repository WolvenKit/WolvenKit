using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entIVisualComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(6)] [RED("renderSceneLayerMask")] public CEnum<RenderSceneLayerMask> RenderSceneLayerMask { get; set; }
		[Ordinal(7)] [RED("forceLODLevel")] public CInt8 ForceLODLevel { get; set; }

		public entIVisualComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
