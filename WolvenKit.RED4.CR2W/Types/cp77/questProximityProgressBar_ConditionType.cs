using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] [RED("action")] public CEnum<questProximityProgressBarAction> Action { get; set; }

		public questProximityProgressBar_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
