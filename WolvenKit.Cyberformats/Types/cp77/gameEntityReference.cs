using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEntityReference : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gameEntityReferenceType> Type { get; set; }
		[Ordinal(1)] [RED("reference")] public NodeRef Reference { get; set; }
		[Ordinal(2)] [RED("names")] public CArray<CName> Names { get; set; }
		[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(4)] [RED("sceneActorContextName")] public CName SceneActorContextName { get; set; }
		[Ordinal(5)] [RED("dynamicEntityUniqueName")] public CName DynamicEntityUniqueName { get; set; }

		public gameEntityReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
