using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutputData : CVariable
	{
		[Ordinal(0)] [RED("link")] public DeviceLink Link { get; set; }
		[Ordinal(1)] [RED("breachOrigin")] public CEnum<EBreachOrigin> BreachOrigin { get; set; }
		[Ordinal(2)] [RED("delayDuration")] public CFloat DelayDuration { get; set; }

		public SecuritySystemOutputData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
