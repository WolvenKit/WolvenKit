using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshActorRequest : HUDManagerRequest
	{
		private CHandle<HUDActorUpdateData> _actorUpdateData;
		private CArray<wCHandle<HUDModule>> _requestedModules;

		[Ordinal(1)] 
		[RED("actorUpdateData")] 
		public CHandle<HUDActorUpdateData> ActorUpdateData
		{
			get => GetProperty(ref _actorUpdateData);
			set => SetProperty(ref _actorUpdateData, value);
		}

		[Ordinal(2)] 
		[RED("requestedModules")] 
		public CArray<wCHandle<HUDModule>> RequestedModules
		{
			get => GetProperty(ref _requestedModules);
			set => SetProperty(ref _requestedModules, value);
		}

		public RefreshActorRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
