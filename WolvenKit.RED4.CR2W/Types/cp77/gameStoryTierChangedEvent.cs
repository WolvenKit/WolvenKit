using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStoryTierChangedEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("newTier")] public CEnum<gameStoryTier> NewTier { get; set; }

		public gameStoryTierChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
