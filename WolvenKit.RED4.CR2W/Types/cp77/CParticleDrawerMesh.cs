using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMesh : IParticleDrawer
	{
		[Ordinal(1)] [RED("meshes")] public CArray<rRef<CMesh>> Meshes { get; set; }
		[Ordinal(2)] [RED("orientationMode")] public CEnum<EMeshParticleOrientationMode> OrientationMode { get; set; }

		public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
