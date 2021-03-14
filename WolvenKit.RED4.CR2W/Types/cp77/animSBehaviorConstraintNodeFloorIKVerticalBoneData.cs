using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKVerticalBoneData : CVariable
	{
		private animTransformIndex _bone;
		private CFloat _min_offset;
		private CFloat _max_offset;
		private CFloat _offsetToDesiredBlendTime;
		private CFloat _verticalOffsetBlendTime;
		private CFloat _stiffness;

		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone", cr2w, this);
				}
				return _bone;
			}
			set
			{
				if (_bone == value)
				{
					return;
				}
				_bone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Min offset")] 
		public CFloat Min_offset
		{
			get
			{
				if (_min_offset == null)
				{
					_min_offset = (CFloat) CR2WTypeManager.Create("Float", "Min offset", cr2w, this);
				}
				return _min_offset;
			}
			set
			{
				if (_min_offset == value)
				{
					return;
				}
				_min_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Max offset")] 
		public CFloat Max_offset
		{
			get
			{
				if (_max_offset == null)
				{
					_max_offset = (CFloat) CR2WTypeManager.Create("Float", "Max offset", cr2w, this);
				}
				return _max_offset;
			}
			set
			{
				if (_max_offset == value)
				{
					return;
				}
				_max_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetToDesiredBlendTime")] 
		public CFloat OffsetToDesiredBlendTime
		{
			get
			{
				if (_offsetToDesiredBlendTime == null)
				{
					_offsetToDesiredBlendTime = (CFloat) CR2WTypeManager.Create("Float", "offsetToDesiredBlendTime", cr2w, this);
				}
				return _offsetToDesiredBlendTime;
			}
			set
			{
				if (_offsetToDesiredBlendTime == value)
				{
					return;
				}
				_offsetToDesiredBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("verticalOffsetBlendTime")] 
		public CFloat VerticalOffsetBlendTime
		{
			get
			{
				if (_verticalOffsetBlendTime == null)
				{
					_verticalOffsetBlendTime = (CFloat) CR2WTypeManager.Create("Float", "verticalOffsetBlendTime", cr2w, this);
				}
				return _verticalOffsetBlendTime;
			}
			set
			{
				if (_verticalOffsetBlendTime == value)
				{
					return;
				}
				_verticalOffsetBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get
			{
				if (_stiffness == null)
				{
					_stiffness = (CFloat) CR2WTypeManager.Create("Float", "stiffness", cr2w, this);
				}
				return _stiffness;
			}
			set
			{
				if (_stiffness == value)
				{
					return;
				}
				_stiffness = value;
				PropertySet(this);
			}
		}

		public animSBehaviorConstraintNodeFloorIKVerticalBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
