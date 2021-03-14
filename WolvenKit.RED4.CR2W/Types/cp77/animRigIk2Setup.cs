using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigIk2Setup : animIRigIkSetup
	{
		private CName _firstBone;
		private CName _secondBone;
		private CName _endBone;
		private CEnum<animAxis> _hingeAxis;
		private CInt16 _firstBoneIdx;
		private CInt16 _secondBoneIdx;
		private CInt16 _endBoneIdx;

		[Ordinal(1)] 
		[RED("firstBone")] 
		public CName FirstBone
		{
			get
			{
				if (_firstBone == null)
				{
					_firstBone = (CName) CR2WTypeManager.Create("CName", "firstBone", cr2w, this);
				}
				return _firstBone;
			}
			set
			{
				if (_firstBone == value)
				{
					return;
				}
				_firstBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("secondBone")] 
		public CName SecondBone
		{
			get
			{
				if (_secondBone == null)
				{
					_secondBone = (CName) CR2WTypeManager.Create("CName", "secondBone", cr2w, this);
				}
				return _secondBone;
			}
			set
			{
				if (_secondBone == value)
				{
					return;
				}
				_secondBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endBone")] 
		public CName EndBone
		{
			get
			{
				if (_endBone == null)
				{
					_endBone = (CName) CR2WTypeManager.Create("CName", "endBone", cr2w, this);
				}
				return _endBone;
			}
			set
			{
				if (_endBone == value)
				{
					return;
				}
				_endBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get
			{
				if (_hingeAxis == null)
				{
					_hingeAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "hingeAxis", cr2w, this);
				}
				return _hingeAxis;
			}
			set
			{
				if (_hingeAxis == value)
				{
					return;
				}
				_hingeAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("firstBoneIdx")] 
		public CInt16 FirstBoneIdx
		{
			get
			{
				if (_firstBoneIdx == null)
				{
					_firstBoneIdx = (CInt16) CR2WTypeManager.Create("Int16", "firstBoneIdx", cr2w, this);
				}
				return _firstBoneIdx;
			}
			set
			{
				if (_firstBoneIdx == value)
				{
					return;
				}
				_firstBoneIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("secondBoneIdx")] 
		public CInt16 SecondBoneIdx
		{
			get
			{
				if (_secondBoneIdx == null)
				{
					_secondBoneIdx = (CInt16) CR2WTypeManager.Create("Int16", "secondBoneIdx", cr2w, this);
				}
				return _secondBoneIdx;
			}
			set
			{
				if (_secondBoneIdx == value)
				{
					return;
				}
				_secondBoneIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("endBoneIdx")] 
		public CInt16 EndBoneIdx
		{
			get
			{
				if (_endBoneIdx == null)
				{
					_endBoneIdx = (CInt16) CR2WTypeManager.Create("Int16", "endBoneIdx", cr2w, this);
				}
				return _endBoneIdx;
			}
			set
			{
				if (_endBoneIdx == value)
				{
					return;
				}
				_endBoneIdx = value;
				PropertySet(this);
			}
		}

		public animRigIk2Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
