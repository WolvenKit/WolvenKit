using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterGroupAttitude_CondtionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }
		[Ordinal(1)]  [RED("group1Name")] public CName Group1Name { get; set; }
		[Ordinal(2)]  [RED("group2Name")] public CName Group2Name { get; set; }

		public questCharacterGroupAttitude_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
