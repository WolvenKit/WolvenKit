using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("district")] public TweakDBID District { get; set; }
		[Ordinal(1)]  [RED("entered")] public CBool Entered { get; set; }
		[Ordinal(2)]  [RED("sendNewLocationNotification")] public CBool SendNewLocationNotification { get; set; }

		public gamemappinsDistrictEnteredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
