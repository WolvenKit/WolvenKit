using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class customGameNotificationDataSet : inkGameNotificationData
	{
		[Ordinal(6)] [RED("customText")] public CName CustomText { get; set; }
		[Ordinal(7)] [RED("testBool")] public CBool TestBool { get; set; }

		public customGameNotificationDataSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
