using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingShapeClassifierMetadata : audioAudioMetadata
	{
		private CBool _useAngle;
		private CFloat _minGroupSize;
		private CFloat _maxGroupSize;
		private CFloat _minGroupAngleSpread;
		private CFloat _maxGroupAngleSpread;
		private CBool _floorLimit;
		private CBool _ceilingLimit;
		private CName _minDistanceLimit;
		private CName _maxDistanceLimit;

		[Ordinal(1)] 
		[RED("useAngle")] 
		public CBool UseAngle
		{
			get
			{
				if (_useAngle == null)
				{
					_useAngle = (CBool) CR2WTypeManager.Create("Bool", "useAngle", cr2w, this);
				}
				return _useAngle;
			}
			set
			{
				if (_useAngle == value)
				{
					return;
				}
				_useAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minGroupSize")] 
		public CFloat MinGroupSize
		{
			get
			{
				if (_minGroupSize == null)
				{
					_minGroupSize = (CFloat) CR2WTypeManager.Create("Float", "minGroupSize", cr2w, this);
				}
				return _minGroupSize;
			}
			set
			{
				if (_minGroupSize == value)
				{
					return;
				}
				_minGroupSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxGroupSize")] 
		public CFloat MaxGroupSize
		{
			get
			{
				if (_maxGroupSize == null)
				{
					_maxGroupSize = (CFloat) CR2WTypeManager.Create("Float", "maxGroupSize", cr2w, this);
				}
				return _maxGroupSize;
			}
			set
			{
				if (_maxGroupSize == value)
				{
					return;
				}
				_maxGroupSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minGroupAngleSpread")] 
		public CFloat MinGroupAngleSpread
		{
			get
			{
				if (_minGroupAngleSpread == null)
				{
					_minGroupAngleSpread = (CFloat) CR2WTypeManager.Create("Float", "minGroupAngleSpread", cr2w, this);
				}
				return _minGroupAngleSpread;
			}
			set
			{
				if (_minGroupAngleSpread == value)
				{
					return;
				}
				_minGroupAngleSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxGroupAngleSpread")] 
		public CFloat MaxGroupAngleSpread
		{
			get
			{
				if (_maxGroupAngleSpread == null)
				{
					_maxGroupAngleSpread = (CFloat) CR2WTypeManager.Create("Float", "maxGroupAngleSpread", cr2w, this);
				}
				return _maxGroupAngleSpread;
			}
			set
			{
				if (_maxGroupAngleSpread == value)
				{
					return;
				}
				_maxGroupAngleSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("floorLimit")] 
		public CBool FloorLimit
		{
			get
			{
				if (_floorLimit == null)
				{
					_floorLimit = (CBool) CR2WTypeManager.Create("Bool", "floorLimit", cr2w, this);
				}
				return _floorLimit;
			}
			set
			{
				if (_floorLimit == value)
				{
					return;
				}
				_floorLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ceilingLimit")] 
		public CBool CeilingLimit
		{
			get
			{
				if (_ceilingLimit == null)
				{
					_ceilingLimit = (CBool) CR2WTypeManager.Create("Bool", "ceilingLimit", cr2w, this);
				}
				return _ceilingLimit;
			}
			set
			{
				if (_ceilingLimit == value)
				{
					return;
				}
				_ceilingLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("minDistanceLimit")] 
		public CName MinDistanceLimit
		{
			get
			{
				if (_minDistanceLimit == null)
				{
					_minDistanceLimit = (CName) CR2WTypeManager.Create("CName", "minDistanceLimit", cr2w, this);
				}
				return _minDistanceLimit;
			}
			set
			{
				if (_minDistanceLimit == value)
				{
					return;
				}
				_minDistanceLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxDistanceLimit")] 
		public CName MaxDistanceLimit
		{
			get
			{
				if (_maxDistanceLimit == null)
				{
					_maxDistanceLimit = (CName) CR2WTypeManager.Create("CName", "maxDistanceLimit", cr2w, this);
				}
				return _maxDistanceLimit;
			}
			set
			{
				if (_maxDistanceLimit == value)
				{
					return;
				}
				_maxDistanceLimit = value;
				PropertySet(this);
			}
		}

		public audioGroupingShapeClassifierMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
