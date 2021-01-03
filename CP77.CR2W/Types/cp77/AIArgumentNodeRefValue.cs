using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIArgumentNodeRefValue : AIArgumentDefinition
	{
		[Ordinal(0)]  [RED("defaultValue")] public NodeRef DefaultValue { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }

		public AIArgumentNodeRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
