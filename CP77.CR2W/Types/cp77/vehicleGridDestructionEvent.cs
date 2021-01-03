using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleGridDestructionEvent : redEvent
	{
		[Ordinal(0)]  [RED("desiredChange")] public [16]Float DesiredChange { get; set; }
		[Ordinal(1)]  [RED("rawChange")] public [16]Float RawChange { get; set; }
		[Ordinal(2)]  [RED("state")] public [16]Float State { get; set; }

		public vehicleGridDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
