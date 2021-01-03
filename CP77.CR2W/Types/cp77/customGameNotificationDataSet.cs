using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class customGameNotificationDataSet : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("customText")] public CName CustomText { get; set; }
		[Ordinal(1)]  [RED("testBool")] public CBool TestBool { get; set; }

		public customGameNotificationDataSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
