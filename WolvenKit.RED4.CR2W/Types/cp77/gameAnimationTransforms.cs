using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationTransforms : CVariable
	{
		private CArray<Transform> _extractedMotion;
		private Transform _gatePosition;
		private Transform _boneOffset;
		private CUInt64 _animsetHash;

		[Ordinal(0)] 
		[RED("extractedMotion")] 
		public CArray<Transform> ExtractedMotion
		{
			get
			{
				if (_extractedMotion == null)
				{
					_extractedMotion = (CArray<Transform>) CR2WTypeManager.Create("array:Transform", "extractedMotion", cr2w, this);
				}
				return _extractedMotion;
			}
			set
			{
				if (_extractedMotion == value)
				{
					return;
				}
				_extractedMotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gatePosition")] 
		public Transform GatePosition
		{
			get
			{
				if (_gatePosition == null)
				{
					_gatePosition = (Transform) CR2WTypeManager.Create("Transform", "gatePosition", cr2w, this);
				}
				return _gatePosition;
			}
			set
			{
				if (_gatePosition == value)
				{
					return;
				}
				_gatePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("boneOffset")] 
		public Transform BoneOffset
		{
			get
			{
				if (_boneOffset == null)
				{
					_boneOffset = (Transform) CR2WTypeManager.Create("Transform", "boneOffset", cr2w, this);
				}
				return _boneOffset;
			}
			set
			{
				if (_boneOffset == value)
				{
					return;
				}
				_boneOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get
			{
				if (_animsetHash == null)
				{
					_animsetHash = (CUInt64) CR2WTypeManager.Create("Uint64", "animsetHash", cr2w, this);
				}
				return _animsetHash;
			}
			set
			{
				if (_animsetHash == value)
				{
					return;
				}
				_animsetHash = value;
				PropertySet(this);
			}
		}

		public gameAnimationTransforms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
