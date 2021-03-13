using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CCTVCamera : gameObject
	{
		[Ordinal(40)] [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(41)] [RED("camera")] public CHandle<gameCameraComponent> Camera { get; set; }
		[Ordinal(42)] [RED("isControlled")] public CBool IsControlled { get; set; }
		[Ordinal(43)] [RED("cachedPuppetID")] public entEntityID CachedPuppetID { get; set; }

		public CCTVCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
