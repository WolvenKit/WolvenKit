using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AreaTypeTransition : CVariable
	{
		[Ordinal(0)] [RED("transitionTo")] public CEnum<ESecurityAreaType> TransitionTo { get; set; }
		[Ordinal(1)] [RED("transitionHour")] public CInt32 TransitionHour { get; set; }
		[Ordinal(2)] [RED("transitionMode")] public CEnum<ETransitionMode> TransitionMode { get; set; }
		[Ordinal(3)] [RED("listenerID")] public CUInt32 ListenerID { get; set; }

		public AreaTypeTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
