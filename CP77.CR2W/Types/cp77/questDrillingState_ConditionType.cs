using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDrillingState_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<questDrillingState> State { get; set; }

		public questDrillingState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
