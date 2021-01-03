using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HackPlayerEvent : redEvent
	{
		[Ordinal(0)]  [RED("netrunnerID")] public entEntityID NetrunnerID { get; set; }
		[Ordinal(1)]  [RED("objectRecord")] public wCHandle<gamedataObjectAction_Record> ObjectRecord { get; set; }
		[Ordinal(2)]  [RED("showDirectionalIndicator")] public CBool ShowDirectionalIndicator { get; set; }
		[Ordinal(3)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public HackPlayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
