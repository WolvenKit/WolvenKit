using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAirtime_ConditionType : questIVehicleConditionType
	{
		private CFloat _seconds;

		[Ordinal(0)] 
		[RED("seconds")] 
		public CFloat Seconds
		{
			get
			{
				if (_seconds == null)
				{
					_seconds = (CFloat) CR2WTypeManager.Create("Float", "seconds", cr2w, this);
				}
				return _seconds;
			}
			set
			{
				if (_seconds == value)
				{
					return;
				}
				_seconds = value;
				PropertySet(this);
			}
		}

		public questVehicleAirtime_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
