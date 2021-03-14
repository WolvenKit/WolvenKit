using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDSignalProgressBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _timerID;
		private gamebbScriptID_Uint32 _state;
		private gamebbScriptID_Float _progress;
		private gamebbScriptID_Float _signalStrength;
		private gamebbScriptID_Bool _isInRange;

		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get
			{
				if (_timerID == null)
				{
					_timerID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "TimerID", cr2w, this);
				}
				return _timerID;
			}
			set
			{
				if (_timerID == value)
				{
					return;
				}
				_timerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("State")] 
		public gamebbScriptID_Uint32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "State", cr2w, this);
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

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "Progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("SignalStrength")] 
		public gamebbScriptID_Float SignalStrength
		{
			get
			{
				if (_signalStrength == null)
				{
					_signalStrength = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SignalStrength", cr2w, this);
				}
				return _signalStrength;
			}
			set
			{
				if (_signalStrength == value)
				{
					return;
				}
				_signalStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("IsInRange")] 
		public gamebbScriptID_Bool IsInRange
		{
			get
			{
				if (_isInRange == null)
				{
					_isInRange = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInRange", cr2w, this);
				}
				return _isInRange;
			}
			set
			{
				if (_isInRange == value)
				{
					return;
				}
				_isInRange = value;
				PropertySet(this);
			}
		}

		public UI_HUDSignalProgressBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
