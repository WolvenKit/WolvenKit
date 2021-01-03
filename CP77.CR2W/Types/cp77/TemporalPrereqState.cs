using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("callback")] public CHandle<TemporalPrereqDelayCallback> Callback { get; set; }
		[Ordinal(1)]  [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(2)]  [RED("delaySystem")] public CHandle<gameDelaySystem> DelaySystem { get; set; }
		[Ordinal(3)]  [RED("lapsedTime")] public CFloat LapsedTime { get; set; }

		public TemporalPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
