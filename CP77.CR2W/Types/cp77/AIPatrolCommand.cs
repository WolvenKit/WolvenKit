using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPatrolCommand : AIMoveCommand
	{
		[Ordinal(0)]  [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
		[Ordinal(1)]  [RED("alertedPathParams")] public CHandle<AIPatrolPathParameters> AlertedPathParams { get; set; }
		[Ordinal(2)]  [RED("alertedRadius")] public CFloat AlertedRadius { get; set; }
		[Ordinal(3)]  [RED("alertedSpots")] public CArray<NodeRef> AlertedSpots { get; set; }

		public AIPatrolCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
