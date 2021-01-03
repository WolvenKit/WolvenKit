using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalConditionData : CVariable
	{
		[Ordinal(0)]  [RED("callbackId")] public CUInt32 CallbackId { get; set; }
		[Ordinal(1)]  [RED("lastValue")] public CBool LastValue { get; set; }

		public AIStackSignalConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
