using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceClueLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _bg;
		private CName _timelineActiveAnimationName;
		private CName _timelineDisabledAnimationName;
		private CHandle<inkanimProxy> _timelineActiveAnimation;
		private CHandle<inkanimProxy> _timelineDisabledAnimation;
		private CEnum<ClueState> _state;
		private BraindanceClueData _data;
		private CBool _isInLayer;
		private CBool _isInTimeWindow;

		[Ordinal(1)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get
			{
				if (_bg == null)
				{
					_bg = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bg", cr2w, this);
				}
				return _bg;
			}
			set
			{
				if (_bg == value)
				{
					return;
				}
				_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("state")] 
		public CEnum<ClueState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ClueState>) CR2WTypeManager.Create("ClueState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("data")] 
		public BraindanceClueData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (BraindanceClueData) CR2WTypeManager.Create("BraindanceClueData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("isInTimeWindow")] 
		public CBool IsInTimeWindow
		{
			get
			{
				if (_isInTimeWindow == null)
				{
					_isInTimeWindow = (CBool) CR2WTypeManager.Create("Bool", "isInTimeWindow", cr2w, this);
				}
				return _isInTimeWindow;
			}
			set
			{
				if (_isInTimeWindow == value)
				{
					return;
				}
				_isInTimeWindow = value;
				PropertySet(this);
			}
		}

		public BraindanceClueLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
