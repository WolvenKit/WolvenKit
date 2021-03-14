using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalImpulseEvent : redEvent
	{
		[Ordinal(0)] [RED("bodyIndex")] public CUInt32 BodyIndex { get; set; }
		[Ordinal(1)] [RED("worldImpulse")] public Vector3 WorldImpulse { get; set; }
		[Ordinal(2)] [RED("worldPosition")] public Vector3 WorldPosition { get; set; }
		[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(4)] [RED("shapeIndex")] public CUInt32 ShapeIndex { get; set; }

		public enteventsPhysicalImpulseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
