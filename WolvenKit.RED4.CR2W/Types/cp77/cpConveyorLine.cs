using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorLine : CVariable
	{
		[Ordinal(0)] [RED("spline")] public NodeRef Spline { get; set; }
		[Ordinal(1)] [RED("template")] public CName Template { get; set; }
		[Ordinal(2)] [RED("reverseDirection")] public CBool ReverseDirection { get; set; }
		[Ordinal(3)] [RED("physicsValidRanges")] public CArray<Vector2> PhysicsValidRanges { get; set; }

		public cpConveyorLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
