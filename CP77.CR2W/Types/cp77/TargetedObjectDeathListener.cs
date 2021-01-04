using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("lsitenTarget")] public wCHandle<gameObject> LsitenTarget { get; set; }
		[Ordinal(1)]  [RED("lsitener")] public wCHandle<SensorDevice> Lsitener { get; set; }

		public TargetedObjectDeathListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
