using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ConsumeGateSignal : GateSignal
	{
		[Ordinal(0)]  [RED("consumeCallName")] public CName ConsumeCallName { get; set; }
		[Ordinal(1)]  [RED("signalToConsume")] public CHandle<GateSignal> SignalToConsume { get; set; }

		public ConsumeGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
