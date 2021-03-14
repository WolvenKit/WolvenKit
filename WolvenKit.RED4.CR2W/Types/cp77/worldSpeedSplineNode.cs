using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNode : worldSplineNode
	{
		private CArray<worldSpeedSplineNodeSpeedChangeSection> _speedChangeSections;
		private CBool _useDeprecated;
		private CArray<worldSpeedSplineNodeSpeedRestriction> _deprecatedSpeedRestrictions;
		private CFloat _deprecatedDefaultSpeed;
		private CFloat _deprecatedDefaultAdjustTime;
		private CArray<worldSpeedSplineNodeOrientationChangeSection> _orientationChangeSections;
		private CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> _roadAdjustmentFactorChangeSections;
		private CBool _ignoreTerrain;

		[Ordinal(9)] 
		[RED("speedChangeSections")] 
		public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections
		{
			get
			{
				if (_speedChangeSections == null)
				{
					_speedChangeSections = (CArray<worldSpeedSplineNodeSpeedChangeSection>) CR2WTypeManager.Create("array:worldSpeedSplineNodeSpeedChangeSection", "speedChangeSections", cr2w, this);
				}
				return _speedChangeSections;
			}
			set
			{
				if (_speedChangeSections == value)
				{
					return;
				}
				_speedChangeSections = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("useDeprecated")] 
		public CBool UseDeprecated
		{
			get
			{
				if (_useDeprecated == null)
				{
					_useDeprecated = (CBool) CR2WTypeManager.Create("Bool", "useDeprecated", cr2w, this);
				}
				return _useDeprecated;
			}
			set
			{
				if (_useDeprecated == value)
				{
					return;
				}
				_useDeprecated = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("deprecatedSpeedRestrictions")] 
		public CArray<worldSpeedSplineNodeSpeedRestriction> DeprecatedSpeedRestrictions
		{
			get
			{
				if (_deprecatedSpeedRestrictions == null)
				{
					_deprecatedSpeedRestrictions = (CArray<worldSpeedSplineNodeSpeedRestriction>) CR2WTypeManager.Create("array:worldSpeedSplineNodeSpeedRestriction", "deprecatedSpeedRestrictions", cr2w, this);
				}
				return _deprecatedSpeedRestrictions;
			}
			set
			{
				if (_deprecatedSpeedRestrictions == value)
				{
					return;
				}
				_deprecatedSpeedRestrictions = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("deprecatedDefaultSpeed")] 
		public CFloat DeprecatedDefaultSpeed
		{
			get
			{
				if (_deprecatedDefaultSpeed == null)
				{
					_deprecatedDefaultSpeed = (CFloat) CR2WTypeManager.Create("Float", "deprecatedDefaultSpeed", cr2w, this);
				}
				return _deprecatedDefaultSpeed;
			}
			set
			{
				if (_deprecatedDefaultSpeed == value)
				{
					return;
				}
				_deprecatedDefaultSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("deprecatedDefaultAdjustTime")] 
		public CFloat DeprecatedDefaultAdjustTime
		{
			get
			{
				if (_deprecatedDefaultAdjustTime == null)
				{
					_deprecatedDefaultAdjustTime = (CFloat) CR2WTypeManager.Create("Float", "deprecatedDefaultAdjustTime", cr2w, this);
				}
				return _deprecatedDefaultAdjustTime;
			}
			set
			{
				if (_deprecatedDefaultAdjustTime == value)
				{
					return;
				}
				_deprecatedDefaultAdjustTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("orientationChangeSections")] 
		public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections
		{
			get
			{
				if (_orientationChangeSections == null)
				{
					_orientationChangeSections = (CArray<worldSpeedSplineNodeOrientationChangeSection>) CR2WTypeManager.Create("array:worldSpeedSplineNodeOrientationChangeSection", "orientationChangeSections", cr2w, this);
				}
				return _orientationChangeSections;
			}
			set
			{
				if (_orientationChangeSections == value)
				{
					return;
				}
				_orientationChangeSections = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("roadAdjustmentFactorChangeSections")] 
		public CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection> RoadAdjustmentFactorChangeSections
		{
			get
			{
				if (_roadAdjustmentFactorChangeSections == null)
				{
					_roadAdjustmentFactorChangeSections = (CArray<worldSpeedSplineNodeRoadAdjustmentFactorChangeSection>) CR2WTypeManager.Create("array:worldSpeedSplineNodeRoadAdjustmentFactorChangeSection", "roadAdjustmentFactorChangeSections", cr2w, this);
				}
				return _roadAdjustmentFactorChangeSections;
			}
			set
			{
				if (_roadAdjustmentFactorChangeSections == value)
				{
					return;
				}
				_roadAdjustmentFactorChangeSections = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ignoreTerrain")] 
		public CBool IgnoreTerrain
		{
			get
			{
				if (_ignoreTerrain == null)
				{
					_ignoreTerrain = (CBool) CR2WTypeManager.Create("Bool", "ignoreTerrain", cr2w, this);
				}
				return _ignoreTerrain;
			}
			set
			{
				if (_ignoreTerrain == value)
				{
					return;
				}
				_ignoreTerrain = value;
				PropertySet(this);
			}
		}

		public worldSpeedSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
