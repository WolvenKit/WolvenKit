using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WantedBarGameController : gameuiHUDGameController
	{
		private CArray<inkWidgetReference> _starsWidget;
		private CHandle<gameIBlackboard> _wantedBlackboard;
		private CHandle<UI_WantedBarDef> _wantedBlackboardDef;
		private CUInt32 _wantedCallbackID;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _attentionAnimProxy;
		private CHandle<inkanimProxy> _bountyAnimProxy;
		private inkanimPlaybackOptions _animOptionsLoop;
		private CInt32 _wantedLevel;
		private CHandle<inkWidget> _rootWidget;
		private CFloat _wANTED_TIER_1;
		private CFloat _wANTED_MIN;

		[Ordinal(9)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get => GetProperty(ref _starsWidget);
			set => SetProperty(ref _starsWidget, value);
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public CHandle<gameIBlackboard> WantedBlackboard
		{
			get => GetProperty(ref _wantedBlackboard);
			set => SetProperty(ref _wantedBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get => GetProperty(ref _wantedBlackboardDef);
			set => SetProperty(ref _wantedBlackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("wantedCallbackID")] 
		public CUInt32 WantedCallbackID
		{
			get => GetProperty(ref _wantedCallbackID);
			set => SetProperty(ref _wantedCallbackID, value);
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(14)] 
		[RED("attentionAnimProxy")] 
		public CHandle<inkanimProxy> AttentionAnimProxy
		{
			get => GetProperty(ref _attentionAnimProxy);
			set => SetProperty(ref _attentionAnimProxy, value);
		}

		[Ordinal(15)] 
		[RED("bountyAnimProxy")] 
		public CHandle<inkanimProxy> BountyAnimProxy
		{
			get => GetProperty(ref _bountyAnimProxy);
			set => SetProperty(ref _bountyAnimProxy, value);
		}

		[Ordinal(16)] 
		[RED("animOptionsLoop")] 
		public inkanimPlaybackOptions AnimOptionsLoop
		{
			get => GetProperty(ref _animOptionsLoop);
			set => SetProperty(ref _animOptionsLoop, value);
		}

		[Ordinal(17)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get => GetProperty(ref _wantedLevel);
			set => SetProperty(ref _wantedLevel, value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public CHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(19)] 
		[RED("WANTED_TIER_1")] 
		public CFloat WANTED_TIER_1
		{
			get => GetProperty(ref _wANTED_TIER_1);
			set => SetProperty(ref _wANTED_TIER_1, value);
		}

		[Ordinal(20)] 
		[RED("WANTED_MIN")] 
		public CFloat WANTED_MIN
		{
			get => GetProperty(ref _wANTED_MIN);
			set => SetProperty(ref _wANTED_MIN, value);
		}

		public WantedBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
