using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodeFacial : animAnimFeature
	{
		[Ordinal(0)] [RED("facialPoseIndex")] public CInt32 FacialPoseIndex { get; set; }

		public AnimFeature_PhotomodeFacial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
