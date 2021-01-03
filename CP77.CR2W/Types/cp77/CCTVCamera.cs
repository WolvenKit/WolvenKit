using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CCTVCamera : gameObject
	{
		[Ordinal(0)]  [RED("cachedPuppetID")] public entEntityID CachedPuppetID { get; set; }
		[Ordinal(1)]  [RED("camera")] public CHandle<gameCameraComponent> Camera { get; set; }
		[Ordinal(2)]  [RED("isControlled")] public CBool IsControlled { get; set; }
		[Ordinal(3)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }

		public CCTVCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
