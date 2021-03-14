using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorArrowsLogicController : DeviceInkLogicControllerBase
	{
		private inkWidgetReference _arrow1Widget;
		private inkWidgetReference _arrow2Widget;
		private inkWidgetReference _arrow3Widget;
		private CHandle<inkanimDefinition> _animFade1;
		private CHandle<inkanimDefinition> _animFade2;
		private CHandle<inkanimDefinition> _animFade3;
		private CHandle<inkanimDefinition> _animSlow1;
		private CHandle<inkanimDefinition> _animSlow2;
		private inkanimPlaybackOptions _animOptions1;
		private inkanimPlaybackOptions _animOptions2;
		private inkanimPlaybackOptions _animOptions3;

		[Ordinal(5)] 
		[RED("arrow1Widget")] 
		public inkWidgetReference Arrow1Widget
		{
			get
			{
				if (_arrow1Widget == null)
				{
					_arrow1Widget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrow1Widget", cr2w, this);
				}
				return _arrow1Widget;
			}
			set
			{
				if (_arrow1Widget == value)
				{
					return;
				}
				_arrow1Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("arrow2Widget")] 
		public inkWidgetReference Arrow2Widget
		{
			get
			{
				if (_arrow2Widget == null)
				{
					_arrow2Widget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrow2Widget", cr2w, this);
				}
				return _arrow2Widget;
			}
			set
			{
				if (_arrow2Widget == value)
				{
					return;
				}
				_arrow2Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("arrow3Widget")] 
		public inkWidgetReference Arrow3Widget
		{
			get
			{
				if (_arrow3Widget == null)
				{
					_arrow3Widget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrow3Widget", cr2w, this);
				}
				return _arrow3Widget;
			}
			set
			{
				if (_arrow3Widget == value)
				{
					return;
				}
				_arrow3Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animFade1")] 
		public CHandle<inkanimDefinition> AnimFade1
		{
			get
			{
				if (_animFade1 == null)
				{
					_animFade1 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animFade1", cr2w, this);
				}
				return _animFade1;
			}
			set
			{
				if (_animFade1 == value)
				{
					return;
				}
				_animFade1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animFade2")] 
		public CHandle<inkanimDefinition> AnimFade2
		{
			get
			{
				if (_animFade2 == null)
				{
					_animFade2 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animFade2", cr2w, this);
				}
				return _animFade2;
			}
			set
			{
				if (_animFade2 == value)
				{
					return;
				}
				_animFade2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("animFade3")] 
		public CHandle<inkanimDefinition> AnimFade3
		{
			get
			{
				if (_animFade3 == null)
				{
					_animFade3 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animFade3", cr2w, this);
				}
				return _animFade3;
			}
			set
			{
				if (_animFade3 == value)
				{
					return;
				}
				_animFade3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animSlow1")] 
		public CHandle<inkanimDefinition> AnimSlow1
		{
			get
			{
				if (_animSlow1 == null)
				{
					_animSlow1 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animSlow1", cr2w, this);
				}
				return _animSlow1;
			}
			set
			{
				if (_animSlow1 == value)
				{
					return;
				}
				_animSlow1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animSlow2")] 
		public CHandle<inkanimDefinition> AnimSlow2
		{
			get
			{
				if (_animSlow2 == null)
				{
					_animSlow2 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animSlow2", cr2w, this);
				}
				return _animSlow2;
			}
			set
			{
				if (_animSlow2 == value)
				{
					return;
				}
				_animSlow2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animOptions1")] 
		public inkanimPlaybackOptions AnimOptions1
		{
			get
			{
				if (_animOptions1 == null)
				{
					_animOptions1 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions1", cr2w, this);
				}
				return _animOptions1;
			}
			set
			{
				if (_animOptions1 == value)
				{
					return;
				}
				_animOptions1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animOptions2")] 
		public inkanimPlaybackOptions AnimOptions2
		{
			get
			{
				if (_animOptions2 == null)
				{
					_animOptions2 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions2", cr2w, this);
				}
				return _animOptions2;
			}
			set
			{
				if (_animOptions2 == value)
				{
					return;
				}
				_animOptions2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animOptions3")] 
		public inkanimPlaybackOptions AnimOptions3
		{
			get
			{
				if (_animOptions3 == null)
				{
					_animOptions3 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions3", cr2w, this);
				}
				return _animOptions3;
			}
			set
			{
				if (_animOptions3 == value)
				{
					return;
				}
				_animOptions3 = value;
				PropertySet(this);
			}
		}

		public ElevatorArrowsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
