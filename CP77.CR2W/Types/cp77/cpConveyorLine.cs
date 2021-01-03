using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpConveyorLine : CVariable
	{
		[Ordinal(0)]  [RED("physicsValidRanges")] public CArray<Vector2> PhysicsValidRanges { get; set; }
		[Ordinal(1)]  [RED("reverseDirection")] public CBool ReverseDirection { get; set; }
		[Ordinal(2)]  [RED("spline")] public NodeRef Spline { get; set; }
		[Ordinal(3)]  [RED("template")] public CName Template { get; set; }

		public cpConveyorLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
