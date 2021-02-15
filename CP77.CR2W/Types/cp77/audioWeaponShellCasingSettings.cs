using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponShellCasingSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("mode")] public CEnum<audioWeaponShellCasingMode> Mode { get; set; }
		[Ordinal(2)] [RED("direction")] public CEnum<audioWeaponShellCasingDirection> Direction { get; set; }
		[Ordinal(3)] [RED("firstCollisionEventName")] public CName FirstCollisionEventName { get; set; }
		[Ordinal(4)] [RED("secondCollisionEventName")] public CName SecondCollisionEventName { get; set; }
		[Ordinal(5)] [RED("initialDelay")] public CFloat InitialDelay { get; set; }

		public audioWeaponShellCasingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
