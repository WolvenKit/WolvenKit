using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStoryTierChangedEvent : AIAIEvent
	{
		[Ordinal(0)]  [RED("newTier")] public CEnum<gameStoryTier> NewTier { get; set; }

		public gameStoryTierChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
