using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questUIElement_ConditionType : questIUIConditionType
	{
		[Ordinal(0)]  [RED("condition")] public CEnum<gamedataUICondition> Condition { get; set; }
		[Ordinal(1)]  [RED("element")] public TweakDBID Element { get; set; }
		[Ordinal(2)]  [RED("value")] public CBool Value { get; set; }

		public questUIElement_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
