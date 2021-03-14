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
		private CHandle<inkWidget> _root;
		private CHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;

		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get
			{
				if (_selector == null)
				{
					_selector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("video")] 
		public inkVideoWidgetReference Video
		{
			get
			{
				if (_video == null)
				{
					_video = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "video", cr2w, this);
				}
				return _video;
			}
			set
			{
				if (_video == value)
				{
					return;
				}
				_video = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("translationAnimationCtrl")] 
		public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get
			{
				if (_translationAnimationCtrl == null)
				{
					_translationAnimationCtrl = (CHandle<inkTextReplaceAnimationController>) CR2WTypeManager.Create("handle:inkTextReplaceAnimationController", "translationAnimationCtrl", cr2w, this);
				}
				return _translationAnimationCtrl;
			}
			set
			{
				if (_translationAnimationCtrl == value)
				{
					return;
				}
				_translationAnimationCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get
			{
				if (_localizedText == null)
				{
					_localizedText = (CString) CR2WTypeManager.Create("String", "localizedText", cr2w, this);
				}
				return _localizedText;
			}
			set
			{
				if (_localizedText == value)
				{
					return;
				}
				_localizedText = value;
				PropertySet(this);
			}
		}

		public characterCreationLifePathBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
