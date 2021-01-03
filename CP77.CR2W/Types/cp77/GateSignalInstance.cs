using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GateSignalInstance : CVariable
	{
		[Ordinal(0)]  [RED("consumeTags")] public CArray<CName> ConsumeTags { get; set; }
		[Ordinal(1)]  [RED("gateSignal")] public CHandle<GateSignal> GateSignal { get; set; }
		[Ordinal(2)]  [RED("timeStamp")] public CFloat TimeStamp { get; set; }

		public GateSignalInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
