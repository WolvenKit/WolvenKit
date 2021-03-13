using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsMovingPrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("isMoving")] public CBool IsMoving { get; set; }
		[Ordinal(6)] [RED("object")] public CString Object { get; set; }

		public HitIsMovingPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
