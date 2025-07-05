using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshActorRequest : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("actorUpdateData")] 
		public CHandle<HUDActorUpdateData> ActorUpdateData
		{
			get => GetPropertyValue<CHandle<HUDActorUpdateData>>();
			set => SetPropertyValue<CHandle<HUDActorUpdateData>>(value);
		}

		[Ordinal(2)] 
		[RED("requestedModules")] 
		public CArray<CWeakHandle<HUDModule>> RequestedModules
		{
			get => GetPropertyValue<CArray<CWeakHandle<HUDModule>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HUDModule>>>(value);
		}

		public RefreshActorRequest()
		{
			RequestedModules = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
