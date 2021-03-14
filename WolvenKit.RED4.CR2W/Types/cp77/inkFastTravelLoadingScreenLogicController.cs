using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkImageWidgetReference _mainBackgroundImage;
		private inkImageWidgetReference _supportBackgroundImage;
		private CName _introAnimationName;
		private CName _loopAnimationName;
		private CName _tooltipAnimName;
		private CName _breathInAnimName;
		private CName _breathOutAnimName;
		private inkRichTextBoxWidgetReference _tooltipsWidget;
		private inkWidgetReference _progressBarRoot;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
		[RED("mainBackgroundImage")] 
		public inkImageWidgetReference MainBackgroundImage
		{
			get
			{
				if (_mainBackgroundImage == null)
				{
					_mainBackgroundImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "mainBackgroundImage", cr2w, this);
				}
				return _mainBackgroundImage;
			}
			set
			{
				if (_mainBackgroundImage == value)
				{
					return;
				}
				_mainBackgroundImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("supportBackgroundImage")] 
		public inkImageWidgetReference SupportBackgroundImage
		{
			get
			{
				if (_supportBackgroundImage == null)
				{
					_supportBackgroundImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "supportBackgroundImage", cr2w, this);
				}
				return _supportBackgroundImage;
			}
			set
			{
				if (_supportBackgroundImage == value)
				{
					return;
				}
				_supportBackgroundImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get
			{
				if (_introAnimationName == null)
				{
					_introAnimationName = (CName) CR2WTypeManager.Create("CName", "introAnimationName", cr2w, this);
				}
				return _introAnimationName;
			}
			set
			{
				if (_introAnimationName == value)
				{
					return;
				}
				_introAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loopAnimationName")] 
		public CName LoopAnimationName
		{
			get
			{
				if (_loopAnimationName == null)
				{
					_loopAnimationName = (CName) CR2WTypeManager.Create("CName", "loopAnimationName", cr2w, this);
				}
				return _loopAnimationName;
			}
			set
			{
				if (_loopAnimationName == value)
				{
					return;
				}
				_loopAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tooltipAnimName")] 
		public CName TooltipAnimName
		{
			get
			{
				if (_tooltipAnimName == null)
				{
					_tooltipAnimName = (CName) CR2WTypeManager.Create("CName", "tooltipAnimName", cr2w, this);
				}
				return _tooltipAnimName;
			}
			set
			{
				if (_tooltipAnimName == value)
				{
					return;
				}
				_tooltipAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("breathInAnimName")] 
		public CName BreathInAnimName
		{
			get
			{
				if (_breathInAnimName == null)
				{
					_breathInAnimName = (CName) CR2WTypeManager.Create("CName", "breathInAnimName", cr2w, this);
				}
				return _breathInAnimName;
			}
			set
			{
				if (_breathInAnimName == value)
				{
					return;
				}
				_breathInAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("breathOutAnimName")] 
		public CName BreathOutAnimName
		{
			get
			{
				if (_breathOutAnimName == null)
				{
					_breathOutAnimName = (CName) CR2WTypeManager.Create("CName", "breathOutAnimName", cr2w, this);
				}
				return _breathOutAnimName;
			}
			set
			{
				if (_breathOutAnimName == value)
				{
					return;
				}
				_breathOutAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tooltipsWidget")] 
		public inkRichTextBoxWidgetReference TooltipsWidget
		{
			get
			{
				if (_tooltipsWidget == null)
				{
					_tooltipsWidget = (inkRichTextBoxWidgetReference) CR2WTypeManager.Create("inkRichTextBoxWidgetReference", "tooltipsWidget", cr2w, this);
				}
				return _tooltipsWidget;
			}
			set
			{
				if (_tooltipsWidget == value)
				{
					return;
				}
				_tooltipsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get
			{
				if (_progressBarRoot == null)
				{
					_progressBarRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarRoot", cr2w, this);
				}
				return _progressBarRoot;
			}
			set
			{
				if (_progressBarRoot == value)
				{
					return;
				}
				_progressBarRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("progressBarController")] 
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get
			{
				if (_progressBarController == null)
				{
					_progressBarController = (wCHandle<LoadingScreenProgressBarController>) CR2WTypeManager.Create("whandle:LoadingScreenProgressBarController", "progressBarController", cr2w, this);
				}
				return _progressBarController;
			}
			set
			{
				if (_progressBarController == value)
				{
					return;
				}
				_progressBarController = value;
				PropertySet(this);
			}
		}

		public inkFastTravelLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
