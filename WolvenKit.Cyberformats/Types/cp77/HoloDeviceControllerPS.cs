using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HoloDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isPlaying")] public CBool IsPlaying { get; set; }

		public HoloDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
