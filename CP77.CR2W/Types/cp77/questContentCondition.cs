using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questContentCondition : questTypedCondition
	{
		[Ordinal(0)]  [RED("type")] public CHandle<questIContentConditionType> Type { get; set; }

		public questContentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
