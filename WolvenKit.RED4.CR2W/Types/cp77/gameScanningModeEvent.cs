using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningModeEvent : redEvent
	{
		[Ordinal(0)] [RED("mode")] public CEnum<gameScanningMode> Mode { get; set; }

		public gameScanningModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
