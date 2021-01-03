using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionInterpolator_Blend : animIAnimStateTransitionInterpolator
	{
		[Ordinal(0)]  [RED("interpolationType")] public CEnum<animAnimStateInterpolationType> InterpolationType { get; set; }

		public animAnimStateTransitionInterpolator_Blend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
