using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartsDependency_ : CVariable
	{
		private CName _masterPart;
		private CName _slavePart;
		private CFloat _angle;
		private CFloat _speedToTargetFactor;
		private curveData<CFloat> _speedToTargetByAngleCurve;
		private CFloat _verticalPullSpeedFactor;
		private curveData<CFloat> _verticalPullSpeedByAngleCurve;
		private CFloat _horizontalPullSpeedFactor;
		private curveData<CFloat> _horizontalPullSpeedByAngleCurve;
		private CFloat _pullScaleBySquareSizeFactor;
		private curveData<CFloat> _pullScaleBySquareSizeCurve;
		private CFloat _innerSquareScale;

		[Ordinal(0)] 
		[RED("masterPart")] 
		public CName MasterPart
		{
			get
			{
				if (_masterPart == null)
				{
					_masterPart = (CName) CR2WTypeManager.Create("CName", "masterPart", cr2w, this);
				}
				return _masterPart;
			}
			set
			{
				if (_masterPart == value)
				{
					return;
				}
				_masterPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slavePart")] 
		public CName SlavePart
		{
			get
			{
				if (_slavePart == null)
				{
					_slavePart = (CName) CR2WTypeManager.Create("CName", "slavePart", cr2w, this);
				}
				return _slavePart;
			}
			set
			{
				if (_slavePart == value)
				{
					return;
				}
				_slavePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("speedToTargetFactor")] 
		public CFloat SpeedToTargetFactor
		{
			get
			{
				if (_speedToTargetFactor == null)
				{
					_speedToTargetFactor = (CFloat) CR2WTypeManager.Create("Float", "speedToTargetFactor", cr2w, this);
				}
				return _speedToTargetFactor;
			}
			set
			{
				if (_speedToTargetFactor == value)
				{
					return;
				}
				_speedToTargetFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("speedToTargetByAngleCurve")] 
		public curveData<CFloat> SpeedToTargetByAngleCurve
		{
			get
			{
				if (_speedToTargetByAngleCurve == null)
				{
					_speedToTargetByAngleCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "speedToTargetByAngleCurve", cr2w, this);
				}
				return _speedToTargetByAngleCurve;
			}
			set
			{
				if (_speedToTargetByAngleCurve == value)
				{
					return;
				}
				_speedToTargetByAngleCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("verticalPullSpeedFactor")] 
		public CFloat VerticalPullSpeedFactor
		{
			get
			{
				if (_verticalPullSpeedFactor == null)
				{
					_verticalPullSpeedFactor = (CFloat) CR2WTypeManager.Create("Float", "verticalPullSpeedFactor", cr2w, this);
				}
				return _verticalPullSpeedFactor;
			}
			set
			{
				if (_verticalPullSpeedFactor == value)
				{
					return;
				}
				_verticalPullSpeedFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("verticalPullSpeedByAngleCurve")] 
		public curveData<CFloat> VerticalPullSpeedByAngleCurve
		{
			get
			{
				if (_verticalPullSpeedByAngleCurve == null)
				{
					_verticalPullSpeedByAngleCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "verticalPullSpeedByAngleCurve", cr2w, this);
				}
				return _verticalPullSpeedByAngleCurve;
			}
			set
			{
				if (_verticalPullSpeedByAngleCurve == value)
				{
					return;
				}
				_verticalPullSpeedByAngleCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("horizontalPullSpeedFactor")] 
		public CFloat HorizontalPullSpeedFactor
		{
			get
			{
				if (_horizontalPullSpeedFactor == null)
				{
					_horizontalPullSpeedFactor = (CFloat) CR2WTypeManager.Create("Float", "horizontalPullSpeedFactor", cr2w, this);
				}
				return _horizontalPullSpeedFactor;
			}
			set
			{
				if (_horizontalPullSpeedFactor == value)
				{
					return;
				}
				_horizontalPullSpeedFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("horizontalPullSpeedByAngleCurve")] 
		public curveData<CFloat> HorizontalPullSpeedByAngleCurve
		{
			get
			{
				if (_horizontalPullSpeedByAngleCurve == null)
				{
					_horizontalPullSpeedByAngleCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "horizontalPullSpeedByAngleCurve", cr2w, this);
				}
				return _horizontalPullSpeedByAngleCurve;
			}
			set
			{
				if (_horizontalPullSpeedByAngleCurve == value)
				{
					return;
				}
				_horizontalPullSpeedByAngleCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("pullScaleBySquareSizeFactor")] 
		public CFloat PullScaleBySquareSizeFactor
		{
			get
			{
				if (_pullScaleBySquareSizeFactor == null)
				{
					_pullScaleBySquareSizeFactor = (CFloat) CR2WTypeManager.Create("Float", "pullScaleBySquareSizeFactor", cr2w, this);
				}
				return _pullScaleBySquareSizeFactor;
			}
			set
			{
				if (_pullScaleBySquareSizeFactor == value)
				{
					return;
				}
				_pullScaleBySquareSizeFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("pullScaleBySquareSizeCurve")] 
		public curveData<CFloat> PullScaleBySquareSizeCurve
		{
			get
			{
				if (_pullScaleBySquareSizeCurve == null)
				{
					_pullScaleBySquareSizeCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "pullScaleBySquareSizeCurve", cr2w, this);
				}
				return _pullScaleBySquareSizeCurve;
			}
			set
			{
				if (_pullScaleBySquareSizeCurve == value)
				{
					return;
				}
				_pullScaleBySquareSizeCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("innerSquareScale")] 
		public CFloat InnerSquareScale
		{
			get
			{
				if (_innerSquareScale == null)
				{
					_innerSquareScale = (CFloat) CR2WTypeManager.Create("Float", "innerSquareScale", cr2w, this);
				}
				return _innerSquareScale;
			}
			set
			{
				if (_innerSquareScale == value)
				{
					return;
				}
				_innerSquareScale = value;
				PropertySet(this);
			}
		}

		public animLookAtPartsDependency_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
