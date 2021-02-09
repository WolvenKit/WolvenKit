using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RagdollState : animAnimFeature
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("hipsPolePitch")] public CFloat HipsPolePitch { get; set; }
		[Ordinal(2)]  [RED("speed")] public CFloat Speed { get; set; }

		public AnimFeature_RagdollState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
