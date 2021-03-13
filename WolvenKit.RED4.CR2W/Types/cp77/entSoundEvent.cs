using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSoundEvent : redEvent
	{
		[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)] [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(2)] [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(3)] [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }

		public entSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
