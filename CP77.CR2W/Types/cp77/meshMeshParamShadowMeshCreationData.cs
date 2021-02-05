using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamShadowMeshCreationData : meshMeshParameter
	{
		[Ordinal(0)]  [RED("geometries")] public CArray<CHandle<physicsICollider>> Geometries { get; set; }
		[Ordinal(1)]  [RED("bonesPerGeometry")] public CArray<CInt32> BonesPerGeometry { get; set; }

		public meshMeshParamShadowMeshCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
