using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)]  [RED("glitchSFX")] public CName GlitchSFX { get; set; }
		[Ordinal(104)]  [RED("useLights")] public CBool UseLights { get; set; }
		[Ordinal(105)]  [RED("lightsSettings")] public CArray<EditableGameLightSettings> LightsSettings { get; set; }
		[Ordinal(106)]  [RED("useDeviceAppearence")] public CBool UseDeviceAppearence { get; set; }

		public BillboardDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
