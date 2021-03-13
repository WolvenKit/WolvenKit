using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableQuaternion : animAnimVariable
	{
		[Ordinal(2)] [RED("roll")] public CFloat Roll { get; set; }
		[Ordinal(3)] [RED("pitch")] public CFloat Pitch { get; set; }
		[Ordinal(4)] [RED("yaw")] public CFloat Yaw { get; set; }
		[Ordinal(5)] [RED("default")] public Quaternion Default { get; set; }

		public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
