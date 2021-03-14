using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("nameWidget")] public inkTextWidgetReference NameWidget { get; set; }
		[Ordinal(2)] [RED("scoreWidget")] public inkTextWidgetReference ScoreWidget { get; set; }

		public gameuiPanzerScoreRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
