using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayAnimEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("animData")] 
		public scneventsPlayAnimEventExData AnimData
		{
			get => GetPropertyValue<scneventsPlayAnimEventExData>();
			set => SetPropertyValue<scneventsPlayAnimEventExData>(value);
		}

		[Ordinal(7)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(8)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("muteAnimEvents")] 
		public CBitField<animMuteAnimEvents> MuteAnimEvents
		{
			get => GetPropertyValue<CBitField<animMuteAnimEvents>>();
			set => SetPropertyValue<CBitField<animMuteAnimEvents>>(value);
		}

		[Ordinal(11)] 
		[RED("neckWeight")] 
		public CFloat NeckWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("upperFaceBlendAdditive")] 
		public CBool UpperFaceBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("lowerFaceBlendAdditive")] 
		public CBool LowerFaceBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("eyesBlendAdditive")] 
		public CBool EyesBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnPlayAnimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
