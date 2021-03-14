using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCrosswalkEvent : redEvent
	{
		private CEnum<worldTrafficLightColor> _trafficLightColor;
		private CEnum<worldTrafficLightColor> _oldTrafficLightColor;
		private CFloat _totalDistance;
		private CFloat _distanceLeft;

		[Ordinal(0)] 
		[RED("trafficLightColor")] 
		public CEnum<worldTrafficLightColor> TrafficLightColor
		{
			get
			{
				if (_trafficLightColor == null)
				{
					_trafficLightColor = (CEnum<worldTrafficLightColor>) CR2WTypeManager.Create("worldTrafficLightColor", "trafficLightColor", cr2w, this);
				}
				return _trafficLightColor;
			}
			set
			{
				if (_trafficLightColor == value)
				{
					return;
				}
				_trafficLightColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("oldTrafficLightColor")] 
		public CEnum<worldTrafficLightColor> OldTrafficLightColor
		{
			get
			{
				if (_oldTrafficLightColor == null)
				{
					_oldTrafficLightColor = (CEnum<worldTrafficLightColor>) CR2WTypeManager.Create("worldTrafficLightColor", "oldTrafficLightColor", cr2w, this);
				}
				return _oldTrafficLightColor;
			}
			set
			{
				if (_oldTrafficLightColor == value)
				{
					return;
				}
				_oldTrafficLightColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("totalDistance")] 
		public CFloat TotalDistance
		{
			get
			{
				if (_totalDistance == null)
				{
					_totalDistance = (CFloat) CR2WTypeManager.Create("Float", "totalDistance", cr2w, this);
				}
				return _totalDistance;
			}
			set
			{
				if (_totalDistance == value)
				{
					return;
				}
				_totalDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distanceLeft")] 
		public CFloat DistanceLeft
		{
			get
			{
				if (_distanceLeft == null)
				{
					_distanceLeft = (CFloat) CR2WTypeManager.Create("Float", "distanceLeft", cr2w, this);
				}
				return _distanceLeft;
			}
			set
			{
				if (_distanceLeft == value)
				{
					return;
				}
				_distanceLeft = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCrosswalkEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
