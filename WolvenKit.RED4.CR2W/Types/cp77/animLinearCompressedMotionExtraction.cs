using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLinearCompressedMotionExtraction : animIMotionExtraction
	{
		private CFloat _duration;
		private CArray<Quaternion> _rotFrames;
		private CArray<Vector3> _posFrames;
		private CArray<CFloat> _rotTime;
		private CArray<CFloat> _posTime;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rotFrames")] 
		public CArray<Quaternion> RotFrames
		{
			get
			{
				if (_rotFrames == null)
				{
					_rotFrames = (CArray<Quaternion>) CR2WTypeManager.Create("array:Quaternion", "rotFrames", cr2w, this);
				}
				return _rotFrames;
			}
			set
			{
				if (_rotFrames == value)
				{
					return;
				}
				_rotFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("posFrames")] 
		public CArray<Vector3> PosFrames
		{
			get
			{
				if (_posFrames == null)
				{
					_posFrames = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "posFrames", cr2w, this);
				}
				return _posFrames;
			}
			set
			{
				if (_posFrames == value)
				{
					return;
				}
				_posFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotTime")] 
		public CArray<CFloat> RotTime
		{
			get
			{
				if (_rotTime == null)
				{
					_rotTime = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "rotTime", cr2w, this);
				}
				return _rotTime;
			}
			set
			{
				if (_rotTime == value)
				{
					return;
				}
				_rotTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("posTime")] 
		public CArray<CFloat> PosTime
		{
			get
			{
				if (_posTime == null)
				{
					_posTime = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "posTime", cr2w, this);
				}
				return _posTime;
			}
			set
			{
				if (_posTime == value)
				{
					return;
				}
				_posTime = value;
				PropertySet(this);
			}
		}

		public animLinearCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
