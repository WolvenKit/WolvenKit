using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressionNotification : GenericNotificationController
	{
		private CHandle<gameuiProgressionViewData> _progression_data;
		private inkWidgetReference _expBar;
		private inkTextWidgetReference _expText;
		private inkWidgetReference _barFG;
		private inkWidgetReference _barBG;
		private inkWidgetReference _root;
		private inkTextWidgetReference _currentLevel;
		private inkTextWidgetReference _nextLevel;
		private CFloat _expBarWidthSize;
		private CFloat _expBarHeightSize;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _barAnimationProxy;

		[Ordinal(12)] 
		[RED("progression_data")] 
		public CHandle<gameuiProgressionViewData> Progression_data
		{
			get => GetProperty(ref _progression_data);
			set => SetProperty(ref _progression_data, value);
		}

		[Ordinal(13)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get => GetProperty(ref _expBar);
			set => SetProperty(ref _expBar, value);
		}

		[Ordinal(14)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get => GetProperty(ref _expText);
			set => SetProperty(ref _expText, value);
		}

		[Ordinal(15)] 
		[RED("barFG")] 
		public inkWidgetReference BarFG
		{
			get => GetProperty(ref _barFG);
			set => SetProperty(ref _barFG, value);
		}

		[Ordinal(16)] 
		[RED("barBG")] 
		public inkWidgetReference BarBG
		{
			get => GetProperty(ref _barBG);
			set => SetProperty(ref _barBG, value);
		}

		[Ordinal(17)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(18)] 
		[RED("currentLevel")] 
		public inkTextWidgetReference CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(19)] 
		[RED("nextLevel")] 
		public inkTextWidgetReference NextLevel
		{
			get => GetProperty(ref _nextLevel);
			set => SetProperty(ref _nextLevel, value);
		}

		[Ordinal(20)] 
		[RED("expBarWidthSize")] 
		public CFloat ExpBarWidthSize
		{
			get => GetProperty(ref _expBarWidthSize);
			set => SetProperty(ref _expBarWidthSize, value);
		}

		[Ordinal(21)] 
		[RED("expBarHeightSize")] 
		public CFloat ExpBarHeightSize
		{
			get => GetProperty(ref _expBarHeightSize);
			set => SetProperty(ref _expBarHeightSize, value);
		}

		[Ordinal(22)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(23)] 
		[RED("barAnimationProxy")] 
		public CHandle<inkanimProxy> BarAnimationProxy
		{
			get => GetProperty(ref _barAnimationProxy);
			set => SetProperty(ref _barAnimationProxy, value);
		}

		public ProgressionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
