using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRotateToParams : questAICommandParams
	{
		[Ordinal(0)] [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
		[Ordinal(1)] [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(2)] [RED("speed")] public CFloat Speed { get; set; }

		public questRotateToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
