using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("nameWidget")] public inkTextWidgetReference NameWidget { get; set; }
		[Ordinal(1)]  [RED("scoreWidget")] public inkTextWidgetReference ScoreWidget { get; set; }

		public gameuiPanzerScoreRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
