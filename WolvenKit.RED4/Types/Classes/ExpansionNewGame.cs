using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionNewGame : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("newGameDescription")] 
		public inkTextWidgetReference NewGameDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("textureTop")] 
		public inkImageWidgetReference TextureTop
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("textureBottom")] 
		public inkImageWidgetReference TextureBottom
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("creditsBaseTexture")] 
		public inkImageWidgetReference CreditsBaseTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("creditsExpansionTexture")] 
		public inkImageWidgetReference CreditsExpansionTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("creditsBase")] 
		public inkWidgetReference CreditsBase
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("creditsExpansion")] 
		public inkWidgetReference CreditsExpansion
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("creditsHoverFrameLeft")] 
		public inkWidgetReference CreditsHoverFrameLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("creditsHoverFrameRight")] 
		public inkWidgetReference CreditsHoverFrameRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("outroAnimation")] 
		public CName OutroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("hoverAnimation")] 
		public CName HoverAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("translationAnimationCtrl")] 
		public CWeakHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>(value);
		}

		[Ordinal(20)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(21)] 
		[RED("lastShownPart")] 
		public CName LastShownPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("baseGameButton")] 
		public inkWidgetReference BaseGameButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("standaloneButton")] 
		public inkWidgetReference StandaloneButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("isInputLocked")] 
		public CBool IsInputLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExpansionNewGame()
		{
			NewGameDescription = new inkTextWidgetReference();
			TextureTop = new inkImageWidgetReference();
			TextureBottom = new inkImageWidgetReference();
			CreditsBaseTexture = new inkImageWidgetReference();
			CreditsExpansionTexture = new inkImageWidgetReference();
			CreditsBase = new inkWidgetReference();
			CreditsExpansion = new inkWidgetReference();
			CreditsHoverFrameLeft = new inkWidgetReference();
			CreditsHoverFrameRight = new inkWidgetReference();
			BaseGameButton = new inkWidgetReference();
			StandaloneButton = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
