using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class netInputOrientation : CVariable
	{
		[Ordinal(0)]  [RED("pitch")] public CFloat Pitch { get; set; }
		[Ordinal(1)]  [RED("yaw")] public CFloat Yaw { get; set; }

		public netInputOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
