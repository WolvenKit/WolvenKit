using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheStatusEffectAnimEvent : redEvent
	{
		[Ordinal(0)] [RED("removeCachedStatusEffect")] public CBool RemoveCachedStatusEffect { get; set; }

		public CacheStatusEffectAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
