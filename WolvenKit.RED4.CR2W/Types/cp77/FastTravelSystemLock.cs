using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystemLock : CVariable
	{
		[Ordinal(0)] [RED("lockReason")] public CName LockReason { get; set; }
		[Ordinal(1)] [RED("linkedStatusEffectID")] public TweakDBID LinkedStatusEffectID { get; set; }

		public FastTravelSystemLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
