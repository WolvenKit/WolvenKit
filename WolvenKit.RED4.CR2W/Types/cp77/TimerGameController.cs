using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<gameIBlackboard> _timerBB;
		private CHandle<UIGameDataDef> _timerDef;
		private CUInt32 _activeBBID;
		private CUInt32 _progressBBID;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(10)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(11)] 
		[RED("timerBB")] 
		public CHandle<gameIBlackboard> TimerBB
		{
			get => GetProperty(ref _timerBB);
			set => SetProperty(ref _timerBB, value);
		}

		[Ordinal(12)] 
		[RED("timerDef")] 
		public CHandle<UIGameDataDef> TimerDef
		{
			get => GetProperty(ref _timerDef);
			set => SetProperty(ref _timerDef, value);
		}

		[Ordinal(13)] 
		[RED("activeBBID")] 
		public CUInt32 ActiveBBID
		{
			get => GetProperty(ref _activeBBID);
			set => SetProperty(ref _activeBBID, value);
		}

		[Ordinal(14)] 
		[RED("progressBBID")] 
		public CUInt32 ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		public TimerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
