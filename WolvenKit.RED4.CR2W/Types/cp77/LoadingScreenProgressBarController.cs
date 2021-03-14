using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadingScreenProgressBarController : inkWidgetLogicController
	{
		private inkWidgetReference _progressBarRoot;
		private inkWidgetReference _progressBarFill;
		private inkWidgetReference _progressSpinerRoot;
		private CHandle<inkanimProxy> _rotationAnimationProxy;
		private CHandle<inkanimDefinition> _rotationAnimation;
		private CHandle<inkanimRotationInterpolator> _rotationInterpolator;

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
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get
			{
				if (_progressBarFill == null)
				{
					_progressBarFill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarFill", cr2w, this);
				}
				return _progressBarFill;
			}
			set
			{
				if (_progressBarFill == value)
				{
					return;
				}
				_progressBarFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("progressSpinerRoot")] 
		public inkWidgetReference ProgressSpinerRoot
		{
			get
			{
				if (_progressSpinerRoot == null)
				{
					_progressSpinerRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressSpinerRoot", cr2w, this);
				}
				return _progressSpinerRoot;
			}
			set
			{
				if (_progressSpinerRoot == value)
				{
					return;
				}
				_progressSpinerRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rotationAnimationProxy")] 
		public CHandle<inkanimProxy> RotationAnimationProxy
		{
			get
			{
				if (_rotationAnimationProxy == null)
				{
					_rotationAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "rotationAnimationProxy", cr2w, this);
				}
				return _rotationAnimationProxy;
			}
			set
			{
				if (_rotationAnimationProxy == value)
				{
					return;
				}
				_rotationAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotationAnimation")] 
		public CHandle<inkanimDefinition> RotationAnimation
		{
			get
			{
				if (_rotationAnimation == null)
				{
					_rotationAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "rotationAnimation", cr2w, this);
				}
				return _rotationAnimation;
			}
			set
			{
				if (_rotationAnimation == value)
				{
					return;
				}
				_rotationAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rotationInterpolator")] 
		public CHandle<inkanimRotationInterpolator> RotationInterpolator
		{
			get
			{
				if (_rotationInterpolator == null)
				{
					_rotationInterpolator = (CHandle<inkanimRotationInterpolator>) CR2WTypeManager.Create("handle:inkanimRotationInterpolator", "rotationInterpolator", cr2w, this);
				}
				return _rotationInterpolator;
			}
			set
			{
				if (_rotationInterpolator == value)
				{
					return;
				}
				_rotationInterpolator = value;
				PropertySet(this);
			}
		}

		public LoadingScreenProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
