using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AimDownSightController : BasicAnimationController
	{
		[Ordinal(0)]  [RED("isAiming")] public CBool IsAiming { get; set; }

		public AimDownSightController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
