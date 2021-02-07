using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationTrackItem : ISerializable
	{
		[Ordinal(0)]  [RED("impl")] public CHandle<gameTransformAnimationTrackItemImpl> Impl { get; set; }
		[Ordinal(1)]  [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }

		public gameTransformAnimationTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
