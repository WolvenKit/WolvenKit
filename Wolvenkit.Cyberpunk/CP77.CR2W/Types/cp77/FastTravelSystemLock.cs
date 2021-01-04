using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystemLock : CVariable
	{
		[Ordinal(0)]  [RED("linkedStatusEffectID")] public TweakDBID LinkedStatusEffectID { get; set; }
		[Ordinal(1)]  [RED("lockReason")] public CName LockReason { get; set; }

		public FastTravelSystemLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
