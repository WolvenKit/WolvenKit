using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TerminalSystemCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("connectedDevices")] public CInt32 ConnectedDevices { get; set; }

		public TerminalSystemCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
