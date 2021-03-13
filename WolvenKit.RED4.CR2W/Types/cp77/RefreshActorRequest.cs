using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshActorRequest : HUDManagerRequest
	{
		[Ordinal(1)] [RED("actorUpdateData")] public CHandle<HUDActorUpdateData> ActorUpdateData { get; set; }
		[Ordinal(2)] [RED("requestedModules")] public CArray<wCHandle<HUDModule>> RequestedModules { get; set; }

		public RefreshActorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
