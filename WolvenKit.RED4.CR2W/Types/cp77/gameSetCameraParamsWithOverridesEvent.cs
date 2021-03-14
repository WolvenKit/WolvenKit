using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetCameraParamsWithOverridesEvent : redEvent
	{
		private CName _paramsName;
		private CFloat _yawMaxLeft;
		private CFloat _yawMaxRight;
		private CFloat _pitchMax;
		private CFloat _pitchMin;
		private CFloat _sensitivityMultX;
		private CFloat _sensitivityMultY;

		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get
			{
				if (_paramsName == null)
				{
					_paramsName = (CName) CR2WTypeManager.Create("CName", "paramsName", cr2w, this);
				}
				return _paramsName;
			}
			set
			{
				if (_paramsName == value)
				{
					return;
				}
				_paramsName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		public gameSetCameraParamsWithOverridesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
