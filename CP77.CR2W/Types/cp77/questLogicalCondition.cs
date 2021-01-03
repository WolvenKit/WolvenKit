using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLogicalCondition : questCondition
	{
		[Ordinal(0)]  [RED("conditions")] public CArray<CHandle<questIBaseCondition>> Conditions { get; set; }
		[Ordinal(1)]  [RED("operation")] public CEnum<questLogicalOperation> Operation { get; set; }

		public questLogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
