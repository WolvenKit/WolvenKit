using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnCameraRid : CVariable
	{
		[Ordinal(0)]  [RED("animations")] public CArray<scnCameraAnimationRid> Animations { get; set; }
		[Ordinal(1)]  [RED("tag")] public scnRidTag Tag { get; set; }

		public scnCameraRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
