using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundMeshes : CVariable
	{
		[Ordinal(0)]  [RED("FillMeshes")] public CArray<entdismembermentFillMeshInfo> FillMeshes { get; set; }
		[Ordinal(1)]  [RED("Meshes")] public CArray<entdismembermentMeshInfo> Meshes { get; set; }
		[Ordinal(2)]  [RED("ResourceSet")] public CEnum<entdismembermentResourceSetE> ResourceSet { get; set; }

		public entdismembermentWoundMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
