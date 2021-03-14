using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("ncartTimetableSetup")] public NcartTimetableSetup NcartTimetableSetup { get; set; }
		[Ordinal(104)] [RED("currentTimeToDepart")] public CInt32 CurrentTimeToDepart { get; set; }

		public NcartTimetableControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
