using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DEBUG_RebalanceItemEvent : redEvent
	{
		[Ordinal(0)]  [RED("reqLevel")] public CFloat ReqLevel { get; set; }

		public DEBUG_RebalanceItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
