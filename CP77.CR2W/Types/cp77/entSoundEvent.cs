using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entSoundEvent : redEvent
	{
		[Ordinal(0)]  [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)]  [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(3)]  [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }

		public entSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
