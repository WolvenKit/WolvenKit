using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionParams : CVariable
	{
		[Ordinal(0)]  [RED("blendDuration")] public CFloat BlendDuration { get; set; }
		[Ordinal(1)]  [RED("poseCorrectionGroup")] public animPoseCorrectionGroup PoseCorrectionGroup { get; set; }

		public animPoseCorrectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
