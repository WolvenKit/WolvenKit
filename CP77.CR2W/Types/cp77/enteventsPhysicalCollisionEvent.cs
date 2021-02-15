using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalCollisionEvent : redEvent
	{
		[Ordinal(0)] [RED("myComponent")] public wCHandle<IScriptable> MyComponent { get; set; }
		[Ordinal(1)] [RED("otherEntity")] public wCHandle<IScriptable> OtherEntity { get; set; }
		[Ordinal(2)] [RED("otherComponent")] public wCHandle<IScriptable> OtherComponent { get; set; }
		[Ordinal(3)] [RED("worldPosition")] public Vector4 WorldPosition { get; set; }
		[Ordinal(4)] [RED("worldNormal")] public Vector4 WorldNormal { get; set; }
		[Ordinal(5)] [RED("deltaVelocity")] public Vector4 DeltaVelocity { get; set; }
		[Ordinal(6)] [RED("impulse")] public CFloat Impulse { get; set; }

		public enteventsPhysicalCollisionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
