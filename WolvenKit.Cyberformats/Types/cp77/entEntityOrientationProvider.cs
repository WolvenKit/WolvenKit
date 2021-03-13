using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEntityOrientationProvider : entIOrientationProvider
	{
		[Ordinal(0)] [RED("slotComponent")] public wCHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(1)] [RED("slotId")] public CInt32 SlotId { get; set; }
		[Ordinal(2)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(3)] [RED("orientationEntitySpace")] public Quaternion OrientationEntitySpace { get; set; }

		public entEntityOrientationProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
