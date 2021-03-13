using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCOrientedBoxDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)] [RED("forward")] public Vector4 Forward { get; set; }
		[Ordinal(2)] [RED("right")] public Vector4 Right { get; set; }
		[Ordinal(3)] [RED("up")] public Vector4 Up { get; set; }

		public gameinteractionsCOrientedBoxDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
