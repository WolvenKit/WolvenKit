using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableQuaternion : animAnimVariable
	{
		[Ordinal(0)]  [RED("default")] public Quaternion Default { get; set; }
		[Ordinal(1)]  [RED("pitch")] public CFloat Pitch { get; set; }
		[Ordinal(2)]  [RED("roll")] public CFloat Roll { get; set; }
		[Ordinal(3)]  [RED("yaw")] public CFloat Yaw { get; set; }

		public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
