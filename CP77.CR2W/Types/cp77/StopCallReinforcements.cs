using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StopCallReinforcements : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }
		[Ordinal(1)]  [RED("pauseResumePhoneCallEvent")] public CHandle<PauseResumePhoneCallEvent> PauseResumePhoneCallEvent { get; set; }
		[Ordinal(2)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public StopCallReinforcements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
