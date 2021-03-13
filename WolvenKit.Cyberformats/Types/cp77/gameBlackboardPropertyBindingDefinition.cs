using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPropertyBindingDefinition : CVariable
	{
		[Ordinal(0)] [RED("serializableID")] public gameBlackboardSerializableID SerializableID { get; set; }
		[Ordinal(1)] [RED("propertyPath")] public CArray<CName> PropertyPath { get; set; }
		[Ordinal(2)] [RED("propertyType")] public CName PropertyType { get; set; }

		public gameBlackboardPropertyBindingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
