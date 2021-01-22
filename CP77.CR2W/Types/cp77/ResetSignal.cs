using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ResetSignal : redEvent
	{
		[Ordinal(0)]  [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(1)]  [RED("signalTable")] public CHandle<gameBoolSignalTable> SignalTable { get; set; }

		public ResetSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
