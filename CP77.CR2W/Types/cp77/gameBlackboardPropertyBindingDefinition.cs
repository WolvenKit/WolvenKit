using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPropertyBindingDefinition : CVariable
	{
		[Ordinal(0)]  [RED("propertyPath")] public CArray<CName> PropertyPath { get; set; }
		[Ordinal(1)]  [RED("propertyType")] public CName PropertyType { get; set; }
		[Ordinal(2)]  [RED("serializableID")] public gameBlackboardSerializableID SerializableID { get; set; }

		public gameBlackboardPropertyBindingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
