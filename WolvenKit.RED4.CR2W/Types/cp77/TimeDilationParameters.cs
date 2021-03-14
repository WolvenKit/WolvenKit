using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeDilationParameters : IScriptable
	{
		private CName _reason;
		private CFloat _timeDilation;
		private CFloat _playerTimeDilation;
		private CFloat _duration;
		private CName _easeInCurve;
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeDilation")] 
		public CFloat TimeDilation
		{
			get
			{
				if (_timeDilation == null)
				{
					_timeDilation = (CFloat) CR2WTypeManager.Create("Float", "timeDilation", cr2w, this);
				}
				return _timeDilation;
			}
			set
			{
				if (_timeDilation == value)
				{
					return;
				}
				_timeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerTimeDilation")] 
		public CFloat PlayerTimeDilation
		{
			get
			{
				if (_playerTimeDilation == null)
				{
					_playerTimeDilation = (CFloat) CR2WTypeManager.Create("Float", "playerTimeDilation", cr2w, this);
				}
				return _playerTimeDilation;
			}
			set
			{
				if (_playerTimeDilation == value)
				{
					return;
				}
				_playerTimeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get
			{
				if (_easeInCurve == null)
				{
					_easeInCurve = (CName) CR2WTypeManager.Create("CName", "easeInCurve", cr2w, this);
				}
				return _easeInCurve;
			}
			set
			{
				if (_easeInCurve == value)
				{
					return;
				}
				_easeInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get
			{
				if (_easeOutCurve == null)
				{
					_easeOutCurve = (CName) CR2WTypeManager.Create("CName", "easeOutCurve", cr2w, this);
				}
				return _easeOutCurve;
			}
			set
			{
				if (_easeOutCurve == value)
				{
					return;
				}
				_easeOutCurve = value;
				PropertySet(this);
			}
		}

		public TimeDilationParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
