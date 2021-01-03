using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIThreatExpectationInvalid : AIAIEvent
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(1)]  [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(2)]  [RED("threatId")] public CUInt32 ThreatId { get; set; }

		public AIThreatExpectationInvalid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
