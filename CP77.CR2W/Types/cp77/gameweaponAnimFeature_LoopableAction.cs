using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("loopDuration")] public CFloat LoopDuration { get; set; }
		[Ordinal(2)]  [RED("numLoops")] public CUInt8 NumLoops { get; set; }

		public gameweaponAnimFeature_LoopableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
