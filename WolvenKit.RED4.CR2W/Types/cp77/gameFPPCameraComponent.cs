using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponent : gameCameraComponent
	{
		private CFloat _pitchMin;
		private CFloat _pitchMax;
		private CFloat _yawMaxLeft;
		private CFloat _yawMaxRight;
		private CBool _headingLocked;
		private CFloat _sensitivityMultX;
		private CFloat _sensitivityMultY;
		private CName _timeDilationCurveName;

		[Ordinal(35)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get
			{
				if (_pitchMin == null)
				{
					_pitchMin = (CFloat) CR2WTypeManager.Create("Float", "pitchMin", cr2w, this);
				}
				return _pitchMin;
			}
			set
			{
				if (_pitchMin == value)
				{
					return;
				}
				_pitchMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get
			{
				if (_pitchMax == null)
				{
					_pitchMax = (CFloat) CR2WTypeManager.Create("Float", "pitchMax", cr2w, this);
				}
				return _pitchMax;
			}
			set
			{
				if (_pitchMax == value)
				{
					return;
				}
				_pitchMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get
			{
				if (_yawMaxLeft == null)
				{
					_yawMaxLeft = (CFloat) CR2WTypeManager.Create("Float", "yawMaxLeft", cr2w, this);
				}
				return _yawMaxLeft;
			}
			set
			{
				if (_yawMaxLeft == value)
				{
					return;
				}
				_yawMaxLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get
			{
				if (_yawMaxRight == null)
				{
					_yawMaxRight = (CFloat) CR2WTypeManager.Create("Float", "yawMaxRight", cr2w, this);
				}
				return _yawMaxRight;
			}
			set
			{
				if (_yawMaxRight == value)
				{
					return;
				}
				_yawMaxRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("headingLocked")] 
		public CBool HeadingLocked
		{
			get
			{
				if (_headingLocked == null)
				{
					_headingLocked = (CBool) CR2WTypeManager.Create("Bool", "headingLocked", cr2w, this);
				}
				return _headingLocked;
			}
			set
			{
				if (_headingLocked == value)
				{
					return;
				}
				_headingLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("sensitivityMultX")] 
		public CFloat SensitivityMultX
		{
			get
			{
				if (_sensitivityMultX == null)
				{
					_sensitivityMultX = (CFloat) CR2WTypeManager.Create("Float", "sensitivityMultX", cr2w, this);
				}
				return _sensitivityMultX;
			}
			set
			{
				if (_sensitivityMultX == value)
				{
					return;
				}
				_sensitivityMultX = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("sensitivityMultY")] 
		public CFloat SensitivityMultY
		{
			get
			{
				if (_sensitivityMultY == null)
				{
					_sensitivityMultY = (CFloat) CR2WTypeManager.Create("Float", "sensitivityMultY", cr2w, this);
				}
				return _sensitivityMultY;
			}
			set
			{
				if (_sensitivityMultY == value)
				{
					return;
				}
				_sensitivityMultY = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("timeDilationCurveName")] 
		public CName TimeDilationCurveName
		{
			get
			{
				if (_timeDilationCurveName == null)
				{
					_timeDilationCurveName = (CName) CR2WTypeManager.Create("CName", "timeDilationCurveName", cr2w, this);
				}
				return _timeDilationCurveName;
			}
			set
			{
				if (_timeDilationCurveName == value)
				{
					return;
				}
				_timeDilationCurveName = value;
				PropertySet(this);
			}
		}

		public gameFPPCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
