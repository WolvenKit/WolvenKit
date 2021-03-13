using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableSetup : CVariable
	{
		[Ordinal(0)] [RED("departFrequency")] public CInt32 DepartFrequency { get; set; }
		[Ordinal(1)] [RED("uiUpdateFrequency")] public CInt32 UiUpdateFrequency { get; set; }

		public NcartTimetableSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
