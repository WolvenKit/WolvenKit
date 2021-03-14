using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workRandomList : workIContainerEntry
	{
		private CInt8 _minClips;
		private CInt8 _maxClips;
		private CFloat _pauseBetweenLength;
		private CFloat _pauseLengthDeviation;
		private CArray<CFloat> _weights;
		private CFloat _pauseBlendOutTime;
		private CInt8 _dontRepeatLastAnims;

		[Ordinal(4)] 
		[RED("minClips")] 
		public CInt8 MinClips
		{
			get
			{
				if (_minClips == null)
				{
					_minClips = (CInt8) CR2WTypeManager.Create("Int8", "minClips", cr2w, this);
				}
				return _minClips;
			}
			set
			{
				if (_minClips == value)
				{
					return;
				}
				_minClips = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxClips")] 
		public CInt8 MaxClips
		{
			get
			{
				if (_maxClips == null)
				{
					_maxClips = (CInt8) CR2WTypeManager.Create("Int8", "maxClips", cr2w, this);
				}
				return _maxClips;
			}
			set
			{
				if (_maxClips == value)
				{
					return;
				}
				_maxClips = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("pauseBetweenLength")] 
		public CFloat PauseBetweenLength
		{
			get
			{
				if (_pauseBetweenLength == null)
				{
					_pauseBetweenLength = (CFloat) CR2WTypeManager.Create("Float", "pauseBetweenLength", cr2w, this);
				}
				return _pauseBetweenLength;
			}
			set
			{
				if (_pauseBetweenLength == value)
				{
					return;
				}
				_pauseBetweenLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("pauseLengthDeviation")] 
		public CFloat PauseLengthDeviation
		{
			get
			{
				if (_pauseLengthDeviation == null)
				{
					_pauseLengthDeviation = (CFloat) CR2WTypeManager.Create("Float", "pauseLengthDeviation", cr2w, this);
				}
				return _pauseLengthDeviation;
			}
			set
			{
				if (_pauseLengthDeviation == value)
				{
					return;
				}
				_pauseLengthDeviation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get
			{
				if (_weights == null)
				{
					_weights = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "weights", cr2w, this);
				}
				return _weights;
			}
			set
			{
				if (_weights == value)
				{
					return;
				}
				_weights = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("pauseBlendOutTime")] 
		public CFloat PauseBlendOutTime
		{
			get
			{
				if (_pauseBlendOutTime == null)
				{
					_pauseBlendOutTime = (CFloat) CR2WTypeManager.Create("Float", "pauseBlendOutTime", cr2w, this);
				}
				return _pauseBlendOutTime;
			}
			set
			{
				if (_pauseBlendOutTime == value)
				{
					return;
				}
				_pauseBlendOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("dontRepeatLastAnims")] 
		public CInt8 DontRepeatLastAnims
		{
			get
			{
				if (_dontRepeatLastAnims == null)
				{
					_dontRepeatLastAnims = (CInt8) CR2WTypeManager.Create("Int8", "dontRepeatLastAnims", cr2w, this);
				}
				return _dontRepeatLastAnims;
			}
			set
			{
				if (_dontRepeatLastAnims == value)
				{
					return;
				}
				_dontRepeatLastAnims = value;
				PropertySet(this);
			}
		}

		public workRandomList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
