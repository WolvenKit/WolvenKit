using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PreventionBountyViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("bountyPrice")] public CInt32 BountyPrice { get; set; }
		[Ordinal(1)]  [RED("bountyTitle")] public CString BountyTitle { get; set; }
		[Ordinal(2)]  [RED("canBeMerged")] public CBool CanBeMerged { get; set; }

		public PreventionBountyViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
