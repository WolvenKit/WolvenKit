using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTogglePrefabVariant_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("prefabNodeRef")] public NodeRef PrefabNodeRef { get; set; }
		[Ordinal(1)]  [RED("variantStates")] public CArray<questVariantState> VariantStates { get; set; }

		public questTogglePrefabVariant_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
