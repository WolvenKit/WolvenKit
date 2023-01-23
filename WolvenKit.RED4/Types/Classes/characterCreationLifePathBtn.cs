using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationLifePathBtn : inkButtonController
	{
		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("video")] 
		public inkVideoWidgetReference Video
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("translationAnimationCtrl")] 
		public CWeakHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>(value);
		}

		[Ordinal(18)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public characterCreationLifePathBtn()
		{
			Selector = new();
			Desc = new();
			Image = new();
			Label = new();
			Video = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
