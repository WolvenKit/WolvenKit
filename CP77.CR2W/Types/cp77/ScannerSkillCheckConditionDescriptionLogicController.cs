using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDescriptionLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("FailedStateName")] public CName FailedStateName { get; set; }
		[Ordinal(1)]  [RED("NameRef")] public inkTextWidgetReference NameRef { get; set; }
		[Ordinal(2)]  [RED("PassedStateName")] public CName PassedStateName { get; set; }

		public ScannerSkillCheckConditionDescriptionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
