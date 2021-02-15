using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationChain : IScriptable
	{
		[Ordinal(0)] [RED("data")] public CArray<AnimationElement> Data { get; set; }
		[Ordinal(1)] [RED("name")] public CName Name { get; set; }

		public AnimationChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
