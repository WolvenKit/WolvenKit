using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPlayAnimEvent : scnSceneEvent
	{
		private scneventsPlayAnimEventExData _animData;
		private scnPerformerId _performer;
		private CName _actorComponent;
		private CBool _convertToAdditive;
		private CEnum<animMuteAnimEvents> _muteAnimEvents;
		private CFloat _neckWeight;
		private CBool _upperFaceBlendAdditive;
		private CBool _lowerFaceBlendAdditive;
		private CBool _eyesBlendAdditive;

		[Ordinal(6)] 
		[RED("animData")] 
		public scneventsPlayAnimEventExData AnimData
		{
			get => GetProperty(ref _animData);
			set => SetProperty(ref _animData, value);
		}

		[Ordinal(7)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(8)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get => GetProperty(ref _actorComponent);
			set => SetProperty(ref _actorComponent, value);
		}

		[Ordinal(9)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get => GetProperty(ref _convertToAdditive);
			set => SetProperty(ref _convertToAdditive, value);
		}

		[Ordinal(10)] 
		[RED("muteAnimEvents")] 
		public CEnum<animMuteAnimEvents> MuteAnimEvents
		{
			get => GetProperty(ref _muteAnimEvents);
			set => SetProperty(ref _muteAnimEvents, value);
		}

		[Ordinal(11)] 
		[RED("neckWeight")] 
		public CFloat NeckWeight
		{
			get => GetProperty(ref _neckWeight);
			set => SetProperty(ref _neckWeight, value);
		}

		[Ordinal(12)] 
		[RED("upperFaceBlendAdditive")] 
		public CBool UpperFaceBlendAdditive
		{
			get => GetProperty(ref _upperFaceBlendAdditive);
			set => SetProperty(ref _upperFaceBlendAdditive, value);
		}

		[Ordinal(13)] 
		[RED("lowerFaceBlendAdditive")] 
		public CBool LowerFaceBlendAdditive
		{
			get => GetProperty(ref _lowerFaceBlendAdditive);
			set => SetProperty(ref _lowerFaceBlendAdditive, value);
		}

		[Ordinal(14)] 
		[RED("eyesBlendAdditive")] 
		public CBool EyesBlendAdditive
		{
			get => GetProperty(ref _eyesBlendAdditive);
			set => SetProperty(ref _eyesBlendAdditive, value);
		}
	}
}
