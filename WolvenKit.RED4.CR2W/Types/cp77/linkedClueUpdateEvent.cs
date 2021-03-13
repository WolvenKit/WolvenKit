using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class linkedClueUpdateEvent : redEvent
	{
		[Ordinal(0)] [RED("linkedCluekData")] public LinkedFocusClueData LinkedCluekData { get; set; }
		[Ordinal(1)] [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(2)] [RED("updatePS")] public CBool UpdatePS { get; set; }

		public linkedClueUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
