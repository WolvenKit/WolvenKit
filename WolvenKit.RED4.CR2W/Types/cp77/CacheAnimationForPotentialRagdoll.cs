using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		[Ordinal(0)] [RED("currentBehavior")] public CName CurrentBehavior { get; set; }

		public CacheAnimationForPotentialRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
