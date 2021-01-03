using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsReactionChangeRequestEvent : redEvent
	{
		[Ordinal(0)]  [RED("reactionPresetRecord")] public CHandle<gamedataReactionPreset_Record> ReactionPresetRecord { get; set; }

		public gameeventsReactionChangeRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
