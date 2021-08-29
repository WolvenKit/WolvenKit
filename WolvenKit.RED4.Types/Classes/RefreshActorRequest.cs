using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshActorRequest : HUDManagerRequest
	{
		private CHandle<HUDActorUpdateData> _actorUpdateData;
		private CArray<CWeakHandle<HUDModule>> _requestedModules;

		[Ordinal(1)] 
		[RED("actorUpdateData")] 
		public CHandle<HUDActorUpdateData> ActorUpdateData
		{
			get => GetProperty(ref _actorUpdateData);
			set => SetProperty(ref _actorUpdateData, value);
		}

		[Ordinal(2)] 
		[RED("requestedModules")] 
		public CArray<CWeakHandle<HUDModule>> RequestedModules
		{
			get => GetProperty(ref _requestedModules);
			set => SetProperty(ref _requestedModules, value);
		}
	}
}
