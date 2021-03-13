using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIsquadsOrder : CVariable
	{
		[Ordinal(0)] [RED("squadAction")] public CName SquadAction { get; set; }
		[Ordinal(1)] [RED("state")] public CUInt32 State { get; set; }
		[Ordinal(2)] [RED("id")] public CUInt32 Id { get; set; }

		public AIsquadsOrder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
