using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DrillScanEvent : redEvent
	{
		[Ordinal(0)]  [RED("IsScanning")] public CBool IsScanning { get; set; }

		public DrillScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
