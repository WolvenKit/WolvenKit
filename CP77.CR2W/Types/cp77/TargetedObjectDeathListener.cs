using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("lsitenTarget")] public wCHandle<gameObject> LsitenTarget { get; set; }
		[Ordinal(1)]  [RED("lsitener")] public wCHandle<SensorDevice> Lsitener { get; set; }

		public TargetedObjectDeathListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
