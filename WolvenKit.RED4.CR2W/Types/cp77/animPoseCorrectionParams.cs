using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionParams : CVariable
	{
		[Ordinal(0)] [RED("poseCorrectionGroup")] public animPoseCorrectionGroup PoseCorrectionGroup { get; set; }
		[Ordinal(1)] [RED("blendDuration")] public CFloat BlendDuration { get; set; }

		public animPoseCorrectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
