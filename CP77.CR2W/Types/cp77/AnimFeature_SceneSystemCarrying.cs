using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		[Ordinal(0)]  [RED("carrying")] public CBool Carrying { get; set; }

		public AnimFeature_SceneSystemCarrying(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
