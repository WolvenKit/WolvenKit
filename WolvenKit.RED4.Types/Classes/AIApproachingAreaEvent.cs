using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIApproachingAreaEvent : AIAIEvent
	{
		private CBool _isApproachCancellation;
		private CWeakHandle<gameStaticAreaShapeComponent> _areaComponent;
		private CWeakHandle<entEntity> _responseTarget;

		[Ordinal(2)] 
		[RED("isApproachCancellation")] 
		public CBool IsApproachCancellation
		{
			get => GetProperty(ref _isApproachCancellation);
			set => SetProperty(ref _isApproachCancellation, value);
		}

		[Ordinal(3)] 
		[RED("areaComponent")] 
		public CWeakHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(4)] 
		[RED("responseTarget")] 
		public CWeakHandle<entEntity> ResponseTarget
		{
			get => GetProperty(ref _responseTarget);
			set => SetProperty(ref _responseTarget, value);
		}
	}
}
