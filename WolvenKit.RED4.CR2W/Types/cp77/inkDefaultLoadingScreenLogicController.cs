using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDefaultLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkWidgetReference _progressBarRoot;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public inkDefaultLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
