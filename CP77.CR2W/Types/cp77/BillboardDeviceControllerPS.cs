using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("glitchSFX")] public CName GlitchSFX { get; set; }
		[Ordinal(1)]  [RED("lightsSettings")] public CArray<EditableGameLightSettings> LightsSettings { get; set; }
		[Ordinal(2)]  [RED("useDeviceAppearence")] public CBool UseDeviceAppearence { get; set; }
		[Ordinal(3)]  [RED("useLights")] public CBool UseLights { get; set; }

		public BillboardDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
