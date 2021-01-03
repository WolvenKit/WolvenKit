using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationSRRef : CVariable
	{
		[Ordinal(0)]  [RED("animationSN")] public scnRidSerialNumber AnimationSN { get; set; }
		[Ordinal(1)]  [RED("resourceId")] public scnRidResourceId ResourceId { get; set; }

		public scnRidAnimationSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
