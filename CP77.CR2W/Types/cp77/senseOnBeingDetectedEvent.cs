using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseOnBeingDetectedEvent : redEvent
	{
		[Ordinal(0)]  [RED("source")] public wCHandle<senseSensorObject> Source { get; set; }
		[Ordinal(1)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)]  [RED("shapeId")] public TweakDBID ShapeId { get; set; }

		public senseOnBeingDetectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
