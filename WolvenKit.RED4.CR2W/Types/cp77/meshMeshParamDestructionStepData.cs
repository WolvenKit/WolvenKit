using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionStepData : meshMeshParameter
	{
		[Ordinal(0)] [RED("offsets")] public CArray<physicsDestructionHierarchyOffset> Offsets { get; set; }
		[Ordinal(1)] [RED("isInstantRemovable")] public CString IsInstantRemovable { get; set; }

		public meshMeshParamDestructionStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
