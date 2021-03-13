using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("delaySystem")] public CHandle<gameDelaySystem> DelaySystem { get; set; }
		[Ordinal(1)] [RED("callback")] public CHandle<TemporalPrereqDelayCallback> Callback { get; set; }
		[Ordinal(2)] [RED("lapsedTime")] public CFloat LapsedTime { get; set; }
		[Ordinal(3)] [RED("delayID")] public gameDelayID DelayID { get; set; }

		public TemporalPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
