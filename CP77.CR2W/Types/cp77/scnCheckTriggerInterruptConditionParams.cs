using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnCheckTriggerInterruptConditionParams : CVariable
	{
		[Ordinal(0)]  [RED("inside")] public CBool Inside { get; set; }
		[Ordinal(1)]  [RED("triggerArea")] public NodeRef TriggerArea { get; set; }

		public scnCheckTriggerInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
