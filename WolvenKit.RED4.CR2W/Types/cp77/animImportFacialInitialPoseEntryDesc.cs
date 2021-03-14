using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialPoseEntryDesc : CVariable
	{
		private CName _poseName;
		private CInt16 _id;
		private CFloat _weight;
		private CUInt8 _type;
		private CUInt8 _side;
		private CBool _isCachable;
		private CFloat _initAnimationPoseMid;
		private CFloat _initAnimationPoseMin;
		private CFloat _initAnimationPoseMax;

		[Ordinal(0)] 
		[RED("poseName")] 
		public CName PoseName
		{
			get
			{
				if (_poseName == null)
				{
					_poseName = (CName) CR2WTypeManager.Create("CName", "poseName", cr2w, this);
				}
				return _poseName;
			}
			set
			{
				if (_poseName == value)
				{
					return;
				}
				_poseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt16) CR2WTypeManager.Create("Int16", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CUInt8) CR2WTypeManager.Create("Uint8", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
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

		[Ordinal(6)] 
		[RED("initAnimationPoseMid")] 
		public CFloat InitAnimationPoseMid
		{
			get
			{
				if (_initAnimationPoseMid == null)
				{
					_initAnimationPoseMid = (CFloat) CR2WTypeManager.Create("Float", "initAnimationPoseMid", cr2w, this);
				}
				return _initAnimationPoseMid;
			}
			set
			{
				if (_initAnimationPoseMid == value)
				{
					return;
				}
				_initAnimationPoseMid = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("initAnimationPoseMin")] 
		public CFloat InitAnimationPoseMin
		{
			get
			{
				if (_initAnimationPoseMin == null)
				{
					_initAnimationPoseMin = (CFloat) CR2WTypeManager.Create("Float", "initAnimationPoseMin", cr2w, this);
				}
				return _initAnimationPoseMin;
			}
			set
			{
				if (_initAnimationPoseMin == value)
				{
					return;
				}
				_initAnimationPoseMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("initAnimationPoseMax")] 
		public CFloat InitAnimationPoseMax
		{
			get
			{
				if (_initAnimationPoseMax == null)
				{
					_initAnimationPoseMax = (CFloat) CR2WTypeManager.Create("Float", "initAnimationPoseMax", cr2w, this);
				}
				return _initAnimationPoseMax;
			}
			set
			{
				if (_initAnimationPoseMax == value)
				{
					return;
				}
				_initAnimationPoseMax = value;
				PropertySet(this);
			}
		}

		public animImportFacialInitialPoseEntryDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
