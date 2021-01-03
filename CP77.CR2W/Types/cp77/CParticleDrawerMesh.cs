using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMesh : IParticleDrawer
	{
		[Ordinal(0)]  [RED("meshes")] public CArray<rRef<CMesh>> Meshes { get; set; }
		[Ordinal(1)]  [RED("orientationMode")] public CEnum<EMeshParticleOrientationMode> OrientationMode { get; set; }

		public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
