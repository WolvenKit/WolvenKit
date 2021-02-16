using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConsumeGateSignal : GateSignal
	{
		[Ordinal(4)] [RED("consumeCallName")] public CName ConsumeCallName { get; set; }
		[Ordinal(5)] [RED("signalToConsume")] public CHandle<GateSignal> SignalToConsume { get; set; }

		public ConsumeGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
