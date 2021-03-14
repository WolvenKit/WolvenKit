using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<gameIBlackboard> _timerBB;
		private CHandle<UIGameDataDef> _timerDef;
		private CUInt32 _activeBBID;
		private CUInt32 _progressBBID;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("timerBB")] 
		public CHandle<gameIBlackboard> TimerBB
		{
			get
			{
				if (_timerBB == null)
				{
					_timerBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "timerBB", cr2w, this);
				}
				return _timerBB;
			}
			set
			{
				if (_timerBB == value)
				{
					return;
				}
				_timerBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("timerDef")] 
		public CHandle<UIGameDataDef> TimerDef
		{
			get
			{
				if (_timerDef == null)
				{
					_timerDef = (CHandle<UIGameDataDef>) CR2WTypeManager.Create("handle:UIGameDataDef", "timerDef", cr2w, this);
				}
				return _timerDef;
			}
			set
			{
				if (_timerDef == value)
				{
					return;
				}
				_timerDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("activeBBID")] 
		public CUInt32 ActiveBBID
		{
			get
			{
				if (_activeBBID == null)
				{
					_activeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "activeBBID", cr2w, this);
				}
				return _activeBBID;
			}
			set
			{
				if (_activeBBID == value)
				{
					return;
				}
				_activeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("progressBBID")] 
		public CUInt32 ProgressBBID
		{
			get
			{
				if (_progressBBID == null)
				{
					_progressBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "progressBBID", cr2w, this);
				}
				return _progressBBID;
			}
			set
			{
				if (_progressBBID == value)
				{
					return;
				}
				_progressBBID = value;
				PropertySet(this);
			}
		}

		public TimerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
