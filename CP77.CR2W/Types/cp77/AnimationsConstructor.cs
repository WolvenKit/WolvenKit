using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationsConstructor : IScriptable
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("isAdditive")] public CBool IsAdditive { get; set; }
		[Ordinal(2)]  [RED("mode")] public CEnum<inkanimInterpolationMode> Mode { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<inkanimInterpolationType> Type { get; set; }

		public AnimationsConstructor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
