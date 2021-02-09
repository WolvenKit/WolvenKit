using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CCTVCamera : gameObject
	{
		[Ordinal(31)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(32)]  [RED("camera")] public CHandle<gameCameraComponent> Camera { get; set; }
		[Ordinal(33)]  [RED("isControlled")] public CBool IsControlled { get; set; }
		[Ordinal(34)]  [RED("cachedPuppetID")] public entEntityID CachedPuppetID { get; set; }

		public CCTVCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
