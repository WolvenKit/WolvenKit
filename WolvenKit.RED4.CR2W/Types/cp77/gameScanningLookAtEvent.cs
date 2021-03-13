using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningLookAtEvent : redEvent
	{
		[Ordinal(0)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)] [RED("state")] public CBool State { get; set; }

		public gameScanningLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
