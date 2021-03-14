using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleTemperatureSettings : CVariable
	{
		private CFloat _rpmThreshold;
		private CFloat _timeToActivateTemperature;
		private CFloat _cooldownTime;

		[Ordinal(0)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get
			{
				if (_rpmThreshold == null)
				{
					_rpmThreshold = (CFloat) CR2WTypeManager.Create("Float", "rpmThreshold", cr2w, this);
				}
				return _rpmThreshold;
			}
			set
			{
				if (_rpmThreshold == value)
				{
					return;
				}
				_rpmThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeToActivateTemperature")] 
		public CFloat TimeToActivateTemperature
		{
			get
			{
				if (_timeToActivateTemperature == null)
				{
					_timeToActivateTemperature = (CFloat) CR2WTypeManager.Create("Float", "timeToActivateTemperature", cr2w, this);
				}
				return _timeToActivateTemperature;
			}
			set
			{
				if (_timeToActivateTemperature == value)
				{
					return;
				}
				_timeToActivateTemperature = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get
			{
				if (_cooldownTime == null)
				{
					_cooldownTime = (CFloat) CR2WTypeManager.Create("Float", "cooldownTime", cr2w, this);
				}
				return _cooldownTime;
			}
			set
			{
				if (_cooldownTime == value)
				{
					return;
				}
				_cooldownTime = value;
				PropertySet(this);
			}
		}

		public audioVehicleTemperatureSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
