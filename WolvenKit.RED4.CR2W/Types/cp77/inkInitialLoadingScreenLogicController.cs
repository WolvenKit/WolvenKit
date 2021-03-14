using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInitialLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkWidgetReference _skipButtonPanel;
		private inkCompoundWidgetReference _loadingPartsContainer;
		private CName _afterSkipAnimation;
		private CName _loadingFinishedAudioStopEvent;
		private inkWidgetReference _progressBarRoot;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
		[RED("skipButtonPanel")] 
		public inkWidgetReference SkipButtonPanel
		{
			get
			{
				if (_skipButtonPanel == null)
				{
					_skipButtonPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "skipButtonPanel", cr2w, this);
				}
				return _skipButtonPanel;
			}
			set
			{
				if (_skipButtonPanel == value)
				{
					return;
				}
				_skipButtonPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loadingPartsContainer")] 
		public inkCompoundWidgetReference LoadingPartsContainer
		{
			get
			{
				if (_loadingPartsContainer == null)
				{
					_loadingPartsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "loadingPartsContainer", cr2w, this);
				}
				return _loadingPartsContainer;
			}
			set
			{
				if (_loadingPartsContainer == value)
				{
					return;
				}
				_loadingPartsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get
			{
				if (_afterSkipAnimation == null)
				{
					_afterSkipAnimation = (CName) CR2WTypeManager.Create("CName", "afterSkipAnimation", cr2w, this);
				}
				return _afterSkipAnimation;
			}
			set
			{
				if (_afterSkipAnimation == value)
				{
					return;
				}
				_afterSkipAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loadingFinishedAudioStopEvent")] 
		public CName LoadingFinishedAudioStopEvent
		{
			get
			{
				if (_loadingFinishedAudioStopEvent == null)
				{
					_loadingFinishedAudioStopEvent = (CName) CR2WTypeManager.Create("CName", "loadingFinishedAudioStopEvent", cr2w, this);
				}
				return _loadingFinishedAudioStopEvent;
			}
			set
			{
				if (_loadingFinishedAudioStopEvent == value)
				{
					return;
				}
				_loadingFinishedAudioStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		public inkInitialLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
