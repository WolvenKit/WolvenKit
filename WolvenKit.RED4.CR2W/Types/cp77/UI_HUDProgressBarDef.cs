using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDProgressBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _timerID;
		private gamebbScriptID_String _header;
		private gamebbScriptID_Bool _active;
		private gamebbScriptID_Float _progress;

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
		[RED("Header")] 
		public gamebbScriptID_String Header
		{
			get
			{
				if (_header == null)
				{
					_header = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "Header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Active")] 
		public gamebbScriptID_Bool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public UI_HUDProgressBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
