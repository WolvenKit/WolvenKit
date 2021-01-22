using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FocusMode : animAnimFeature
	{
		[Ordinal(0)]  [RED("isFocusModeActive")] public CBool IsFocusModeActive { get; set; }

		public AnimFeature_FocusMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
