using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerSpotted : redEvent
	{
		[Ordinal(0)]  [RED("agentAreas")] public CArray<CHandle<SecurityAreaControllerPS>> AgentAreas { get; set; }
		[Ordinal(1)]  [RED("comesFromNPC")] public CBool ComesFromNPC { get; set; }
		[Ordinal(2)]  [RED("doesSee")] public CBool DoesSee { get; set; }
		[Ordinal(3)]  [RED("ownerID")] public gamePersistentID OwnerID { get; set; }

		public PlayerSpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
