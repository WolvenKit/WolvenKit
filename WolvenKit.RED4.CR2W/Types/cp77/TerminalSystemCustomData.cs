using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalSystemCustomData : WidgetCustomData
	{
		[Ordinal(0)] [RED("connectedDevices")] public CInt32 ConnectedDevices { get; set; }

		public TerminalSystemCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
