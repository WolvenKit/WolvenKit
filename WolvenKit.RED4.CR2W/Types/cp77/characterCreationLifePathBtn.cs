using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationLifePathBtn : inkButtonController
	{
		private inkWidgetReference _selector;
		private inkTextWidgetReference _desc;
		private inkImageWidgetReference _image;
		private inkTextWidgetReference _label;
		private inkVideoWidgetReference _video;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;

		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(11)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(12)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(13)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(14)] 
		[RED("video")] 
		public inkVideoWidgetReference Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(16)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(17)] 
		[RED("translationAnimationCtrl")] 
		public wCHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(18)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetProperty(ref _localizedText);
			set => SetProperty(ref _localizedText, value);
		}

		public characterCreationLifePathBtn(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
