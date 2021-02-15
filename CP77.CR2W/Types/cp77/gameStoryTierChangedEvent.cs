using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStoryTierChangedEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("newTier")] public CEnum<gameStoryTier> NewTier { get; set; }

		public gameStoryTierChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
