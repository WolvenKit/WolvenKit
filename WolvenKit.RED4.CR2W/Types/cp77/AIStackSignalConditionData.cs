using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalConditionData : CVariable
	{
		[Ordinal(0)] [RED("callbackId")] public CUInt32 CallbackId { get; set; }
		[Ordinal(1)] [RED("lastValue")] public CBool LastValue { get; set; }

		public AIStackSignalConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
