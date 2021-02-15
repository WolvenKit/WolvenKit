using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(119)] [RED("itemTweakDBString")] public CName ItemTweakDBString { get; set; }

		public C4ControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
