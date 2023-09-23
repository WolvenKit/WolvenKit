using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceClueLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("timelineActiveAnimationName")] 
		public CName TimelineActiveAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("timelineDisabledAnimationName")] 
		public CName TimelineDisabledAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("timelineActiveAnimation")] 
		public CHandle<inkanimProxy> TimelineActiveAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("timelineDisabledAnimation")] 
		public CHandle<inkanimProxy> TimelineDisabledAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("state")] 
		public CEnum<ClueState> State
		{
			get => GetPropertyValue<CEnum<ClueState>>();
			set => SetPropertyValue<CEnum<ClueState>>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public BraindanceClueData Data
		{
			get => GetPropertyValue<BraindanceClueData>();
			set => SetPropertyValue<BraindanceClueData>(value);
		}

		[Ordinal(8)] 
		[RED("isInLayer")] 
		public CBool IsInLayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isInTimeWindow")] 
		public CBool IsInTimeWindow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BraindanceClueLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
