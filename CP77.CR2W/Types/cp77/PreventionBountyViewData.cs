using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionBountyViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("action")] public CHandle<GenericNotificationBaseAction> Action { get; set; }
		[Ordinal(1)]  [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(2)]  [RED("bountyTitle")] public CString BountyTitle { get; set; }
		[Ordinal(3)]  [RED("bountyPrice")] public CInt32 BountyPrice { get; set; }

		public PreventionBountyViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
