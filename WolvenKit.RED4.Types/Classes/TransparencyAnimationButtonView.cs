using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TransparencyAnimationButtonView : BaseButtonView
	{
		private CFloat _animationTime;
		private CFloat _hoverTransparency;
		private CFloat _pressTransparency;
		private CFloat _defaultTransparency;
		private CFloat _disabledTransparency;
		private CArray<CHandle<inkanimProxy>> _animationProxies;
		private CArray<inkWidgetReference> _targets;

		[Ordinal(2)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		[Ordinal(3)] 
		[RED("HoverTransparency")] 
		public CFloat HoverTransparency
		{
			get => GetProperty(ref _hoverTransparency);
			set => SetProperty(ref _hoverTransparency, value);
		}

		[Ordinal(4)] 
		[RED("PressTransparency")] 
		public CFloat PressTransparency
		{
			get => GetProperty(ref _pressTransparency);
			set => SetProperty(ref _pressTransparency, value);
		}

		[Ordinal(5)] 
		[RED("DefaultTransparency")] 
		public CFloat DefaultTransparency
		{
			get => GetProperty(ref _defaultTransparency);
			set => SetProperty(ref _defaultTransparency, value);
		}

		[Ordinal(6)] 
		[RED("DisabledTransparency")] 
		public CFloat DisabledTransparency
		{
			get => GetProperty(ref _disabledTransparency);
			set => SetProperty(ref _disabledTransparency, value);
		}

		[Ordinal(7)] 
		[RED("AnimationProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimationProxies
		{
			get => GetProperty(ref _animationProxies);
			set => SetProperty(ref _animationProxies, value);
		}

		[Ordinal(8)] 
		[RED("Targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		public TransparencyAnimationButtonView()
		{
			_animationTime = 0.100000F;
			_hoverTransparency = 0.200000F;
			_pressTransparency = 0.400000F;
		}
	}
}
