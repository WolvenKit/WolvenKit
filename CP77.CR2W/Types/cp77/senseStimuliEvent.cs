using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseStimuliEvent : senseBaseStimuliEvent
	{
		[Ordinal(0)]  [RED("sourceObject")] public wCHandle<gameObject> SourceObject { get; set; }
		[Ordinal(1)]  [RED("sourcePosition")] public Vector4 SourcePosition { get; set; }
		[Ordinal(2)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)]  [RED("detection")] public CFloat Detection { get; set; }
		[Ordinal(4)]  [RED("data")] public CHandle<senseStimuliData> Data { get; set; }

		public senseStimuliEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
