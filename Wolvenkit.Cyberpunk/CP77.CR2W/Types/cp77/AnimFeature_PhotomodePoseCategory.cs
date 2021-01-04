using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodePoseCategory : animAnimFeature
	{
		[Ordinal(0)]  [RED("poseCategoryIndex")] public CInt32 PoseCategoryIndex { get; set; }

		public AnimFeature_PhotomodePoseCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
