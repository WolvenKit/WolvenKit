using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterGroupAttitude_CondtionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("group1Name")] public CName Group1Name { get; set; }
		[Ordinal(1)] [RED("group2Name")] public CName Group2Name { get; set; }
		[Ordinal(2)] [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public questCharacterGroupAttitude_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
