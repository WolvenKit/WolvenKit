using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReload : animAnimFeature
	{
		[Ordinal(0)] [RED("emptyReload")] public CBool EmptyReload { get; set; }
		[Ordinal(1)] [RED("amountToReload")] public CInt32 AmountToReload { get; set; }
		[Ordinal(2)] [RED("continueLoop")] public CBool ContinueLoop { get; set; }
		[Ordinal(3)] [RED("loopDuration")] public CFloat LoopDuration { get; set; }
		[Ordinal(4)] [RED("emptyDuration")] public CFloat EmptyDuration { get; set; }

		public AnimFeature_WeaponReload(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
