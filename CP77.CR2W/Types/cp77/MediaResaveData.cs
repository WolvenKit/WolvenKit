using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MediaResaveData : CVariable
	{
		[Ordinal(0)] [RED("mediaDeviceData")] public MediaDeviceData MediaDeviceData { get; set; }

		public MediaResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
