using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceBarLogicController : inkWidgetLogicController
	{
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CBool _isInLayer;
		private CName _timelineActiveAnimationName;
		private CName _timelineDisabledAnimationName;
		private CHandle<inkanimProxy> _timelineActiveAnimation;
		private CHandle<inkanimProxy> _timelineDisabledAnimation;

		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CEnum<gameuiEBraindanceLayer>) CR2WTypeManager.Create("gameuiEBraindanceLayer", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInLayer")] 
		public CBool IsInLayer
		{
			get
			{
				if (_isInLayer == null)
				{
					_isInLayer = (CBool) CR2WTypeManager.Create("Bool", "isInLayer", cr2w, this);
				}
				return _isInLayer;
			}
			set
			{
				if (_isInLayer == value)
				{
					return;
				}
				_isInLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timelineActiveAnimationName")] 
		public CName TimelineActiveAnimationName
		{
			get
			{
				if (_timelineActiveAnimationName == null)
				{
					_timelineActiveAnimationName = (CName) CR2WTypeManager.Create("CName", "timelineActiveAnimationName", cr2w, this);
				}
				return _timelineActiveAnimationName;
			}
			set
			{
				if (_timelineActiveAnimationName == value)
				{
					return;
				}
				_timelineActiveAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timelineDisabledAnimationName")] 
		public CName TimelineDisabledAnimationName
		{
			get
			{
				if (_timelineDisabledAnimationName == null)
				{
					_timelineDisabledAnimationName = (CName) CR2WTypeManager.Create("CName", "timelineDisabledAnimationName", cr2w, this);
				}
				return _timelineDisabledAnimationName;
			}
			set
			{
				if (_timelineDisabledAnimationName == value)
				{
					return;
				}
				_timelineDisabledAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timelineActiveAnimation")] 
		public CHandle<inkanimProxy> TimelineActiveAnimation
		{
			get
			{
				if (_timelineActiveAnimation == null)
				{
					_timelineActiveAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "timelineActiveAnimation", cr2w, this);
				}
				return _timelineActiveAnimation;
			}
			set
			{
				if (_timelineActiveAnimation == value)
				{
					return;
				}
				_timelineActiveAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timelineDisabledAnimation")] 
		public CHandle<inkanimProxy> TimelineDisabledAnimation
		{
			get
			{
				if (_timelineDisabledAnimation == null)
				{
					_timelineDisabledAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "timelineDisabledAnimation", cr2w, this);
				}
				return _timelineDisabledAnimation;
			}
			set
			{
				if (_timelineDisabledAnimation == value)
				{
					return;
				}
				_timelineDisabledAnimation = value;
				PropertySet(this);
			}
		}

		public BraindanceBarLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
