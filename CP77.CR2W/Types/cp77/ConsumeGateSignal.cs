using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConsumeGateSignal : GateSignal
	{
		[Ordinal(0)]  [RED("data")] public CHandle<AISignalSenderTask> Data { get; set; }
		[Ordinal(1)]  [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(2)]  [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(3)]  [RED("consumeCallName")] public CName ConsumeCallName { get; set; }
		[Ordinal(4)]  [RED("signalToConsume")] public CHandle<GateSignal> SignalToConsume { get; set; }

		public ConsumeGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
