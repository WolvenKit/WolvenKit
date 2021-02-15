using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerControlDeviceData : CVariable
	{
		[Ordinal(0)] [RED("currentYawModifier")] public CFloat CurrentYawModifier { get; set; }
		[Ordinal(1)] [RED("currentPitchModifier")] public CFloat CurrentPitchModifier { get; set; }

		public PlayerControlDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
