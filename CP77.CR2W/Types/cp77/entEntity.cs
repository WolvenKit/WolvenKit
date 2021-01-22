using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEntity : IScriptable
	{
		[Ordinal(0)]  [RED("customCameraTarget")] public CEnum<ECustomCameraTarget> CustomCameraTarget { get; set; }
		[Ordinal(1)]  [RED("renderSceneLayerMask")] public RenderSceneLayerMask RenderSceneLayerMask { get; set; }

		public entEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
