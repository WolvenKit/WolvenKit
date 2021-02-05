using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)]  [RED("flushDuration")] public CFloat FlushDuration { get; set; }
		[Ordinal(104)]  [RED("flushSFX")] public CName FlushSFX { get; set; }
		[Ordinal(105)]  [RED("flushVFXname")] public CName FlushVFXname { get; set; }
		[Ordinal(106)]  [RED("isFlushing")] public CBool IsFlushing { get; set; }

		public ToiletControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
