using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("TimeToDepart")] public gamebbScriptID_Int32 TimeToDepart { get; set; }

		public NcartTimetableBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
