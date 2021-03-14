using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseLimitWeights : CVariable
	{
		private CFloat _min;
		private CFloat _mid;
		private CFloat _max;
		private CInt16 _poseTrackIndex;
		private CUInt8 _type;
		private CBool _isCachable;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mid")] 
		public CFloat Mid
		{
			get
			{
				if (_mid == null)
				{
					_mid = (CFloat) CR2WTypeManager.Create("Float", "mid", cr2w, this);
				}
				return _mid;
			}
			set
			{
				if (_mid == value)
				{
					return;
				}
				_mid = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("poseTrackIndex")] 
		public CInt16 PoseTrackIndex
		{
			get
			{
				if (_poseTrackIndex == null)
				{
					_poseTrackIndex = (CInt16) CR2WTypeManager.Create("Int16", "poseTrackIndex", cr2w, this);
				}
				return _poseTrackIndex;
			}
			set
			{
				if (_poseTrackIndex == value)
				{
					return;
				}
				_poseTrackIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CUInt8) CR2WTypeManager.Create("Uint8", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get
			{
				if (_isCachable == null)
				{
					_isCachable = (CBool) CR2WTypeManager.Create("Bool", "isCachable", cr2w, this);
				}
				return _isCachable;
			}
			set
			{
				if (_isCachable == value)
				{
					return;
				}
				_isCachable = value;
				PropertySet(this);
			}
		}

		public animPoseLimitWeights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
