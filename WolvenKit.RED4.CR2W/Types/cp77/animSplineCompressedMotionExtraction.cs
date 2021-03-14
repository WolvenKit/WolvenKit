using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSplineCompressedMotionExtraction : animIMotionExtraction
	{
		private CFloat _duration;
		private CArray<CUInt8> _posKeysData;
		private CArray<CUInt8> _rotKeysData;

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
		[RED("posKeysData")] 
		public CArray<CUInt8> PosKeysData
		{
			get
			{
				if (_posKeysData == null)
				{
					_posKeysData = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "posKeysData", cr2w, this);
				}
				return _posKeysData;
			}
			set
			{
				if (_posKeysData == value)
				{
					return;
				}
				_posKeysData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotKeysData")] 
		public CArray<CUInt8> RotKeysData
		{
			get
			{
				if (_rotKeysData == null)
				{
					_rotKeysData = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "rotKeysData", cr2w, this);
				}
				return _rotKeysData;
			}
			set
			{
				if (_rotKeysData == value)
				{
					return;
				}
				_rotKeysData = value;
				PropertySet(this);
			}
		}

		public animSplineCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
