using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StopCallReinforcements : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("pauseResumePhoneCallEvent")] public CHandle<PauseResumePhoneCallEvent> PauseResumePhoneCallEvent { get; set; }
		[Ordinal(1)]  [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }
		[Ordinal(2)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public StopCallReinforcements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
