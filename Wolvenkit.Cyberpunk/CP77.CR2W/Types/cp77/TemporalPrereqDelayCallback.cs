using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)]  [RED("state")] public wCHandle<TemporalPrereqState> State { get; set; }

		public TemporalPrereqDelayCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
