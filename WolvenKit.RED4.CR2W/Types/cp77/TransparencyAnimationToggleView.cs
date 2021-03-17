using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransparencyAnimationToggleView : BaseToggleView
	{
		private CFloat _animationTime;
		private CFloat _hoverTransparency;
		private CFloat _pressTransparency;
		private CFloat _defaultTransparency;
		private CFloat _disabledTransparency;
		private CArray<CHandle<inkanimProxy>> _animationProxies;
		private CArray<inkWidgetReference> _targets;

		[Ordinal(3)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		[Ordinal(4)] 
		[RED("HoverTransparency")] 
		public CFloat HoverTransparency
		{
			get => GetProperty(ref _hoverTransparency);
			set => SetProperty(ref _hoverTransparency, value);
		}

		[Ordinal(5)] 
		[RED("PressTransparency")] 
		public CFloat PressTransparency
		{
			get => GetProperty(ref _pressTransparency);
			set => SetProperty(ref _pressTransparency, value);
		}

		[Ordinal(6)] 
		[RED("DefaultTransparency")] 
		public CFloat DefaultTransparency
		{
			get => GetProperty(ref _defaultTransparency);
			set => SetProperty(ref _defaultTransparency, value);
		}

		[Ordinal(7)] 
		[RED("DisabledTransparency")] 
		public CFloat DisabledTransparency
		{
			get => GetProperty(ref _disabledTransparency);
			set => SetProperty(ref _disabledTransparency, value);
		}

		[Ordinal(8)] 
		[RED("AnimationProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimationProxies
		{
			get => GetProperty(ref _animationProxies);
			set => SetProperty(ref _animationProxies, value);
		}

		[Ordinal(9)] 
		[RED("Targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		public TransparencyAnimationToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
