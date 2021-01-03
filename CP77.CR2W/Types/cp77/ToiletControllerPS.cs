using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("flushDuration")] public CFloat FlushDuration { get; set; }
		[Ordinal(1)]  [RED("flushSFX")] public CName FlushSFX { get; set; }
		[Ordinal(2)]  [RED("flushVFXname")] public CName FlushVFXname { get; set; }
		[Ordinal(3)]  [RED("isFlushing")] public CBool IsFlushing { get; set; }

		public ToiletControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
