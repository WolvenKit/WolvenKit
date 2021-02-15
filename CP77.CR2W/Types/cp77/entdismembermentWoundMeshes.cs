using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundMeshes : CVariable
	{
		[Ordinal(0)] [RED("ResourceSet")] public CEnum<entdismembermentResourceSetE> ResourceSet { get; set; }
		[Ordinal(1)] [RED("Meshes")] public CArray<entdismembermentMeshInfo> Meshes { get; set; }
		[Ordinal(2)] [RED("FillMeshes")] public CArray<entdismembermentFillMeshInfo> FillMeshes { get; set; }

		public entdismembermentWoundMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
