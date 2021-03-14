using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleController : gameComponent
	{
		private CName _alarmCurve;
		private CFloat _alarmTime;

		[Ordinal(4)] 
		[RED("alarmCurve")] 
		public CName AlarmCurve
		{
			get
			{
				if (_alarmCurve == null)
				{
					_alarmCurve = (CName) CR2WTypeManager.Create("CName", "alarmCurve", cr2w, this);
				}
				return _alarmCurve;
			}
			set
			{
				if (_alarmCurve == value)
				{
					return;
				}
				_alarmCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("alarmTime")] 
		public CFloat AlarmTime
		{
			get
			{
				if (_alarmTime == null)
				{
					_alarmTime = (CFloat) CR2WTypeManager.Create("Float", "alarmTime", cr2w, this);
				}
				return _alarmTime;
			}
			set
			{
				if (_alarmTime == value)
				{
					return;
				}
				_alarmTime = value;
				PropertySet(this);
			}
		}

		public vehicleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
