using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAddIdleAnimEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private CName _actorComponent;
		private CFloat _weight;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get => GetProperty(ref _actorComponent);
			set => SetProperty(ref _actorComponent, value);
		}

		[Ordinal(8)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public scnAddIdleAnimEvent()
		{
			_actorComponent = "body";
			_weight = 1.000000F;
		}
	}
}
