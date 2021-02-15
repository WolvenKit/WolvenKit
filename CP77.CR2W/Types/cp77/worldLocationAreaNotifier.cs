using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("districtID")] public TweakDBID DistrictID { get; set; }
		[Ordinal(4)] [RED("sendNewLocationNotification")] public CBool SendNewLocationNotification { get; set; }

		public worldLocationAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
