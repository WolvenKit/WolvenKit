using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTagged_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("inverted")] public CBool Inverted { get; set; }

		public questTagged_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
