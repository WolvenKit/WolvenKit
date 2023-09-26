using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questBriefingSequencePlayer_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questBriefingSequencePlayerFunction> Function
		{
			get => GetPropertyValue<CEnum<questBriefingSequencePlayerFunction>>();
			set => SetPropertyValue<CEnum<questBriefingSequencePlayerFunction>>(value);
		}

		[Ordinal(1)] 
		[RED("briefingResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> BriefingResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get => GetPropertyValue<CHandle<inkUserData>>();
			set => SetPropertyValue<CHandle<inkUserData>>(value);
		}

		[Ordinal(3)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("startMarkerName")] 
		public CName StartMarkerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("endMarkerName")] 
		public CName EndMarkerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<inkanimLoopType>>();
			set => SetPropertyValue<CEnum<inkanimLoopType>>(value);
		}

		[Ordinal(8)] 
		[RED("briefingPlayerType")] 
		public CEnum<questBriefingPlayerType> BriefingPlayerType
		{
			get => GetPropertyValue<CEnum<questBriefingPlayerType>>();
			set => SetPropertyValue<CEnum<questBriefingPlayerType>>(value);
		}

		[Ordinal(9)] 
		[RED("briefingType")] 
		public CEnum<questBriefingType> BriefingType
		{
			get => GetPropertyValue<CEnum<questBriefingType>>();
			set => SetPropertyValue<CEnum<questBriefingType>>(value);
		}

		[Ordinal(10)] 
		[RED("enableScanner")] 
		public CBool EnableScanner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questBriefingSequencePlayer_NodeType()
		{
			BriefingPlayerType = Enums.questBriefingPlayerType.Hud;
			BriefingType = Enums.questBriefingType.Hud;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
