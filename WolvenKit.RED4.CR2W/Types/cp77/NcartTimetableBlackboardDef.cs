using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("TimeToDepart")] public gamebbScriptID_Int32 TimeToDepart { get; set; }

		public NcartTimetableBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
