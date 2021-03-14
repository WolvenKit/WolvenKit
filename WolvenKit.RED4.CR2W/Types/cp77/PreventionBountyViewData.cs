using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionBountyViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(6)] [RED("bountyTitle")] public CString BountyTitle { get; set; }
		[Ordinal(7)] [RED("bountyPrice")] public CInt32 BountyPrice { get; set; }

		public PreventionBountyViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
