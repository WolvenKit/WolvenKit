using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFlybySettings : CVariable
	{
		[Ordinal(0)] [RED("movementSpeed")] public CFloat MovementSpeed { get; set; }
		[Ordinal(1)] [RED("flybyEvent")] public CName FlybyEvent { get; set; }

		public audioFlybySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
