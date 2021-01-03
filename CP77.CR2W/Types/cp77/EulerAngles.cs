using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EulerAngles : CVariable
	{
		[Ordinal(0)]  [RED("Pitch")] public CFloat Pitch { get; set; }
		[Ordinal(1)]  [RED("Roll")] public CFloat Roll { get; set; }
		[Ordinal(2)]  [RED("Yaw")] public CFloat Yaw { get; set; }

		public EulerAngles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
