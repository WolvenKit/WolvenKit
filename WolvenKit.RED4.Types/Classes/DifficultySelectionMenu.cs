using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DifficultySelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _difficultyTitle;
		private inkImageWidgetReference _difficultyIcon;
		private inkWidgetReference _difficulty0;
		private inkWidgetReference _difficulty1;
		private inkWidgetReference _difficulty2;
		private inkWidgetReference _difficulty3;
		private CHandle<inkanimProxy> _animationProxy;
		private redResourceReferenceScriptToken _c_atlas1;
		private redResourceReferenceScriptToken _c_atlas2;
		private CWeakHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;

		[Ordinal(6)] 
		[RED("difficultyTitle")] 
		public inkTextWidgetReference DifficultyTitle
		{
			get => GetProperty(ref _difficultyTitle);
			set => SetProperty(ref _difficultyTitle, value);
		}

		[Ordinal(7)] 
		[RED("difficultyIcon")] 
		public inkImageWidgetReference DifficultyIcon
		{
			get => GetProperty(ref _difficultyIcon);
			set => SetProperty(ref _difficultyIcon, value);
		}

		[Ordinal(8)] 
		[RED("difficulty0")] 
		public inkWidgetReference Difficulty0
		{
			get => GetProperty(ref _difficulty0);
			set => SetProperty(ref _difficulty0, value);
		}

		[Ordinal(9)] 
		[RED("difficulty1")] 
		public inkWidgetReference Difficulty1
		{
			get => GetProperty(ref _difficulty1);
			set => SetProperty(ref _difficulty1, value);
		}

		[Ordinal(10)] 
		[RED("difficulty2")] 
		public inkWidgetReference Difficulty2
		{
			get => GetProperty(ref _difficulty2);
			set => SetProperty(ref _difficulty2, value);
		}

		[Ordinal(11)] 
		[RED("difficulty3")] 
		public inkWidgetReference Difficulty3
		{
			get => GetProperty(ref _difficulty3);
			set => SetProperty(ref _difficulty3, value);
		}

		[Ordinal(12)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(13)] 
		[RED("c_atlas1")] 
		public redResourceReferenceScriptToken C_atlas1
		{
			get => GetProperty(ref _c_atlas1);
			set => SetProperty(ref _c_atlas1, value);
		}

		[Ordinal(14)] 
		[RED("c_atlas2")] 
		public redResourceReferenceScriptToken C_atlas2
		{
			get => GetProperty(ref _c_atlas2);
			set => SetProperty(ref _c_atlas2, value);
		}

		[Ordinal(15)] 
		[RED("translationAnimationCtrl")] 
		public CWeakHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(16)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetProperty(ref _localizedText);
			set => SetProperty(ref _localizedText, value);
		}
	}
}
