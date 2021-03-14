using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdvanceChangeLightEvent : redEvent
	{
		private EditableGameLightSettings _settings;
		private CFloat _time;
		private CName _curve;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("settings")] 
		public EditableGameLightSettings Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (EditableGameLightSettings) CR2WTypeManager.Create("EditableGameLightSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("curve")] 
		public CName Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (CName) CR2WTypeManager.Create("CName", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		public AdvanceChangeLightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
