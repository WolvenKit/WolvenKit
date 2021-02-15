using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateToObjectState : gameActionRotateBaseState
	{
		[Ordinal(11)] [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }
		[Ordinal(12)] [RED("completeWhenRotated")] public CBool CompleteWhenRotated { get; set; }

		public gameActionRotateToObjectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
