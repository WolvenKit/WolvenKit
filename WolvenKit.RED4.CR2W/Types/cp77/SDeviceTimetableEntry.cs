using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceTimetableEntry : CVariable
	{
		[Ordinal(0)] [RED("time")] public SSimpleGameTime Time { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<EDeviceStatus> State { get; set; }
		[Ordinal(2)] [RED("entryID")] public CUInt32 EntryID { get; set; }

		public SDeviceTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
