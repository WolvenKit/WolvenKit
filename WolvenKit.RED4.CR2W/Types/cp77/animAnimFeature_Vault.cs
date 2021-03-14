using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Vault : animAnimFeature_Climb
	{
		private Vector4 _landPosition;
		private CFloat _travellingTime;
		private CFloat _obstacleDepth;

		[Ordinal(10)] 
		[RED("landPosition")] 
		public Vector4 LandPosition
		{
			get
			{
				if (_landPosition == null)
				{
					_landPosition = (Vector4) CR2WTypeManager.Create("Vector4", "landPosition", cr2w, this);
				}
				return _landPosition;
			}
			set
			{
				if (_landPosition == value)
				{
					return;
				}
				_landPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("travellingTime")] 
		public CFloat TravellingTime
		{
			get
			{
				if (_travellingTime == null)
				{
					_travellingTime = (CFloat) CR2WTypeManager.Create("Float", "travellingTime", cr2w, this);
				}
				return _travellingTime;
			}
			set
			{
				if (_travellingTime == value)
				{
					return;
				}
				_travellingTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get
			{
				if (_obstacleDepth == null)
				{
					_obstacleDepth = (CFloat) CR2WTypeManager.Create("Float", "obstacleDepth", cr2w, this);
				}
				return _obstacleDepth;
			}
			set
			{
				if (_obstacleDepth == value)
				{
					return;
				}
				_obstacleDepth = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Vault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
