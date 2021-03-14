using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTier3CameraSettings : CVariable
	{
		private CFloat _yawLeftLimit;
		private CFloat _yawRightLimit;
		private CFloat _pitchTopLimit;
		private CFloat _pitchBottomLimit;
		private CFloat _pitchSpeedMultiplier;
		private CFloat _yawSpeedMultiplier;

		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get
			{
				if (_yawLeftLimit == null)
				{
					_yawLeftLimit = (CFloat) CR2WTypeManager.Create("Float", "yawLeftLimit", cr2w, this);
				}
				return _yawLeftLimit;
			}
			set
			{
				if (_yawLeftLimit == value)
				{
					return;
				}
				_yawLeftLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get
			{
				if (_yawRightLimit == null)
				{
					_yawRightLimit = (CFloat) CR2WTypeManager.Create("Float", "yawRightLimit", cr2w, this);
				}
				return _yawRightLimit;
			}
			set
			{
				if (_yawRightLimit == value)
				{
					return;
				}
				_yawRightLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pitchTopLimit")] 
		public CFloat PitchTopLimit
		{
			get
			{
				if (_pitchTopLimit == null)
				{
					_pitchTopLimit = (CFloat) CR2WTypeManager.Create("Float", "pitchTopLimit", cr2w, this);
				}
				return _pitchTopLimit;
			}
			set
			{
				if (_pitchTopLimit == value)
				{
					return;
				}
				_pitchTopLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pitchBottomLimit")] 
		public CFloat PitchBottomLimit
		{
			get
			{
				if (_pitchBottomLimit == null)
				{
					_pitchBottomLimit = (CFloat) CR2WTypeManager.Create("Float", "pitchBottomLimit", cr2w, this);
				}
				return _pitchBottomLimit;
			}
			set
			{
				if (_pitchBottomLimit == value)
				{
					return;
				}
				_pitchBottomLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get
			{
				if (_pitchSpeedMultiplier == null)
				{
					_pitchSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "pitchSpeedMultiplier", cr2w, this);
				}
				return _pitchSpeedMultiplier;
			}
			set
			{
				if (_pitchSpeedMultiplier == value)
				{
					return;
				}
				_pitchSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get
			{
				if (_yawSpeedMultiplier == null)
				{
					_yawSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "yawSpeedMultiplier", cr2w, this);
				}
				return _yawSpeedMultiplier;
			}
			set
			{
				if (_yawSpeedMultiplier == value)
				{
					return;
				}
				_yawSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		public gameTier3CameraSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
