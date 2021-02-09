using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DoorDevice : animAnimFeature
	{
		[Ordinal(0)]  [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(1)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(2)]  [RED("isSealed")] public CBool IsSealed { get; set; }

		public AnimFeature_DoorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
