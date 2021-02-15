using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GateSignalInstance : CVariable
	{
		[Ordinal(0)] [RED("gateSignal")] public CHandle<GateSignal> GateSignal { get; set; }
		[Ordinal(1)] [RED("timeStamp")] public CFloat TimeStamp { get; set; }
		[Ordinal(2)] [RED("consumeTags")] public CArray<CName> ConsumeTags { get; set; }

		public GateSignalInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
