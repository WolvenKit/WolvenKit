using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCompanionCacheDataEvent : redEvent
	{
		[Ordinal(0)] [RED("isPlayerCompanionCached")] public CBool IsPlayerCompanionCached { get; set; }
		[Ordinal(1)] [RED("isPlayerCompanionCachedTimeStamp")] public CFloat IsPlayerCompanionCachedTimeStamp { get; set; }

		public PlayerCompanionCacheDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
