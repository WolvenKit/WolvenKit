using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationTrackItem : ISerializable
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("impl")] public CHandle<gameTransformAnimationTrackItemImpl> Impl { get; set; }
		[Ordinal(2)]  [RED("startTime")] public CFloat StartTime { get; set; }

		public gameTransformAnimationTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
