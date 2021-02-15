using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_Mask : animIPoseBlendMethod
	{
		[Ordinal(0)] [RED("maskName")] public CName MaskName { get; set; }

		public animPoseBlendMethod_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
