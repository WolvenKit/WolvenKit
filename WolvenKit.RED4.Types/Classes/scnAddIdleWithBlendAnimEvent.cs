using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAddIdleWithBlendAnimEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private CName _actorComponent;
		private CFloat _targetWeight;

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
		[RED("targetWeight")] 
		public CFloat TargetWeight
		{
			get => GetProperty(ref _targetWeight);
			set => SetProperty(ref _targetWeight, value);
		}
	}
}
