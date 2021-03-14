using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipAnimationController : inkWidgetLogicController
	{
		private CName _showAnimationName;
		private CName _hideAnimationName;
		private CHandle<inkanimProxy> _tooltipAnimHide;
		private CHandle<inkanimProxy> _tooltipDelayedShow;
		private CFloat _axisDataThreshold;
		private CBool _isHidden;

		[Ordinal(1)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get
			{
				if (_showAnimationName == null)
				{
					_showAnimationName = (CName) CR2WTypeManager.Create("CName", "showAnimationName", cr2w, this);
				}
				return _showAnimationName;
			}
			set
			{
				if (_showAnimationName == value)
				{
					return;
				}
				_showAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get
			{
				if (_hideAnimationName == null)
				{
					_hideAnimationName = (CName) CR2WTypeManager.Create("CName", "hideAnimationName", cr2w, this);
				}
				return _hideAnimationName;
			}
			set
			{
				if (_hideAnimationName == value)
				{
					return;
				}
				_hideAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tooltipAnimHide")] 
		public CHandle<inkanimProxy> TooltipAnimHide
		{
			get
			{
				if (_tooltipAnimHide == null)
				{
					_tooltipAnimHide = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "tooltipAnimHide", cr2w, this);
				}
				return _tooltipAnimHide;
			}
			set
			{
				if (_tooltipAnimHide == value)
				{
					return;
				}
				_tooltipAnimHide = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tooltipDelayedShow")] 
		public CHandle<inkanimProxy> TooltipDelayedShow
		{
			get
			{
				if (_tooltipDelayedShow == null)
				{
					_tooltipDelayedShow = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "tooltipDelayedShow", cr2w, this);
				}
				return _tooltipDelayedShow;
			}
			set
			{
				if (_tooltipDelayedShow == value)
				{
					return;
				}
				_tooltipDelayedShow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get
			{
				if (_axisDataThreshold == null)
				{
					_axisDataThreshold = (CFloat) CR2WTypeManager.Create("Float", "axisDataThreshold", cr2w, this);
				}
				return _axisDataThreshold;
			}
			set
			{
				if (_axisDataThreshold == value)
				{
					return;
				}
				_axisDataThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get
			{
				if (_isHidden == null)
				{
					_isHidden = (CBool) CR2WTypeManager.Create("Bool", "isHidden", cr2w, this);
				}
				return _isHidden;
			}
			set
			{
				if (_isHidden == value)
				{
					return;
				}
				_isHidden = value;
				PropertySet(this);
			}
		}

		public TooltipAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
