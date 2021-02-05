using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RefreshActorRequest : HUDManagerRequest
	{
		[Ordinal(0)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)]  [RED("actorUpdateData")] public CHandle<HUDActorUpdateData> ActorUpdateData { get; set; }
		[Ordinal(2)]  [RED("requestedModules")] public CArray<wCHandle<HUDModule>> RequestedModules { get; set; }

		public RefreshActorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
