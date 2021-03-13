using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentVectorValue : AIArgumentDefinition
	{
		[Ordinal(3)] [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(4)] [RED("defaultValue")] public Vector3 DefaultValue { get; set; }

		public AIArgumentVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
