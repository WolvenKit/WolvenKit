using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_Timed : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("timeToFireTransition")] public CFloat TimeToFireTransition { get; set; }

		public animAnimStateTransitionCondition_Timed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
