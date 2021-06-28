using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryMenu : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _backstoryTitle;
		private inkImageWidgetReference _backstoryIcon;
		private inkTextWidgetReference _backstory;
		private inkTextWidgetReference _attributeBodyValue;
		private inkTextWidgetReference _attributeIntelligenceValue;
		private inkTextWidgetReference _attributeReflexesValue;
		private inkTextWidgetReference _attributeTechnicalAbilityValue;
		private inkTextWidgetReference _attributeCoolValue;
		private inkWidgetReference _previousPageBtn;
		private inkWidgetReference _glitchBtn;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _loadingAnimationProxy;
		private CBool _loadingFinished;
		private CInt32 _glitchClicks;

		[Ordinal(6)] 
		[RED("backstoryTitle")] 
		public inkTextWidgetReference BackstoryTitle
		{
			get => GetProperty(ref _backstoryTitle);
			set => SetProperty(ref _backstoryTitle, value);
		}

		[Ordinal(7)] 
		[RED("backstoryIcon")] 
		public inkImageWidgetReference BackstoryIcon
		{
			get => GetProperty(ref _backstoryIcon);
			set => SetProperty(ref _backstoryIcon, value);
		}

		[Ordinal(8)] 
		[RED("backstory")] 
		public inkTextWidgetReference Backstory
		{
			get => GetProperty(ref _backstory);
			set => SetProperty(ref _backstory, value);
		}

		[Ordinal(9)] 
		[RED("attributeBodyValue")] 
		public inkTextWidgetReference AttributeBodyValue
		{
			get => GetProperty(ref _attributeBodyValue);
			set => SetProperty(ref _attributeBodyValue, value);
		}

		[Ordinal(10)] 
		[RED("attributeIntelligenceValue")] 
		public inkTextWidgetReference AttributeIntelligenceValue
		{
			get => GetProperty(ref _attributeIntelligenceValue);
			set => SetProperty(ref _attributeIntelligenceValue, value);
		}

		[Ordinal(11)] 
		[RED("attributeReflexesValue")] 
		public inkTextWidgetReference AttributeReflexesValue
		{
			get => GetProperty(ref _attributeReflexesValue);
			set => SetProperty(ref _attributeReflexesValue, value);
		}

		[Ordinal(12)] 
		[RED("attributeTechnicalAbilityValue")] 
		public inkTextWidgetReference AttributeTechnicalAbilityValue
		{
			get => GetProperty(ref _attributeTechnicalAbilityValue);
			set => SetProperty(ref _attributeTechnicalAbilityValue, value);
		}

		[Ordinal(13)] 
		[RED("attributeCoolValue")] 
		public inkTextWidgetReference AttributeCoolValue
		{
			get => GetProperty(ref _attributeCoolValue);
			set => SetProperty(ref _attributeCoolValue, value);
		}

		[Ordinal(14)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetProperty(ref _previousPageBtn);
			set => SetProperty(ref _previousPageBtn, value);
		}

		[Ordinal(15)] 
		[RED("glitchBtn")] 
		public inkWidgetReference GlitchBtn
		{
			get => GetProperty(ref _glitchBtn);
			set => SetProperty(ref _glitchBtn, value);
		}

		[Ordinal(16)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(17)] 
		[RED("loadingAnimationProxy")] 
		public CHandle<inkanimProxy> LoadingAnimationProxy
		{
			get => GetProperty(ref _loadingAnimationProxy);
			set => SetProperty(ref _loadingAnimationProxy, value);
		}

		[Ordinal(18)] 
		[RED("loadingFinished")] 
		public CBool LoadingFinished
		{
			get => GetProperty(ref _loadingFinished);
			set => SetProperty(ref _loadingFinished, value);
		}

		[Ordinal(19)] 
		[RED("glitchClicks")] 
		public CInt32 GlitchClicks
		{
			get => GetProperty(ref _glitchClicks);
			set => SetProperty(ref _glitchClicks, value);
		}

		public characterCreationSummaryMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
