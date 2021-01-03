using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectSlotEntry : CVariable
	{
		[Ordinal(0)]  [RED("relativePosition")] public Vector3 RelativePosition { get; set; }
		[Ordinal(1)]  [RED("relativeRotation")] public Quaternion RelativeRotation { get; set; }
		[Ordinal(2)]  [RED("slotName")] public CName SlotName { get; set; }

		public effectSlotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
