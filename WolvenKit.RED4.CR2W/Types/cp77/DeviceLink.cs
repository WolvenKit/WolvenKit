using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLink : CVariable
	{
		[Ordinal(0)] [RED("PSID")] public gamePersistentID PSID { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }

		public DeviceLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
