using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeatureDoor : animAnimFeature
	{
		[Ordinal(0)]  [RED("doorSide")] public CInt32 DoorSide { get; set; }
		[Ordinal(1)]  [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(2)]  [RED("openingType")] public CInt32 OpeningType { get; set; }
		[Ordinal(3)]  [RED("progress")] public CFloat Progress { get; set; }

		public AnimFeatureDoor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
