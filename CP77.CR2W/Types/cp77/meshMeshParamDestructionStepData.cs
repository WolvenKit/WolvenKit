using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionStepData : meshMeshParameter
	{
		[Ordinal(0)]  [RED("isInstantRemovable")] public CString IsInstantRemovable { get; set; }
		[Ordinal(1)]  [RED("offsets")] public CArray<physicsDestructionHierarchyOffset> Offsets { get; set; }

		public meshMeshParamDestructionStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
