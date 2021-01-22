using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterCallReinforcements_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterCallReinforcements_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
