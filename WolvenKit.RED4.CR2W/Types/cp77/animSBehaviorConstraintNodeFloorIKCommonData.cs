using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKCommonData : CVariable
	{
		private animTransformIndex _gravityCentreBone;
		private CFloat _rootRotationBlendTime;
		private CFloat _verticalVelocityOffsetUpBlendTime;
		private CFloat _verticalVelocityOffsetDownBlendTime;
		private CFloat _slidingOnSlopeBlendTime;

		[Ordinal(0)] 
		[RED("gravityCentreBone")] 
		public animTransformIndex GravityCentreBone
		{
			get
			{
				if (_gravityCentreBone == null)
				{
					_gravityCentreBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "gravityCentreBone", cr2w, this);
				}
				return _gravityCentreBone;
			}
			set
			{
				if (_gravityCentreBone == value)
				{
					return;
				}
				_gravityCentreBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rootRotationBlendTime")] 
		public CFloat RootRotationBlendTime
		{
			get
			{
				if (_rootRotationBlendTime == null)
				{
					_rootRotationBlendTime = (CFloat) CR2WTypeManager.Create("Float", "rootRotationBlendTime", cr2w, this);
				}
				return _rootRotationBlendTime;
			}
			set
			{
				if (_rootRotationBlendTime == value)
				{
					return;
				}
				_rootRotationBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("verticalVelocityOffsetUpBlendTime")] 
		public CFloat VerticalVelocityOffsetUpBlendTime
		{
			get
			{
				if (_verticalVelocityOffsetUpBlendTime == null)
				{
					_verticalVelocityOffsetUpBlendTime = (CFloat) CR2WTypeManager.Create("Float", "verticalVelocityOffsetUpBlendTime", cr2w, this);
				}
				return _verticalVelocityOffsetUpBlendTime;
			}
			set
			{
				if (_verticalVelocityOffsetUpBlendTime == value)
				{
					return;
				}
				_verticalVelocityOffsetUpBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("verticalVelocityOffsetDownBlendTime")] 
		public CFloat VerticalVelocityOffsetDownBlendTime
		{
			get
			{
				if (_verticalVelocityOffsetDownBlendTime == null)
				{
					_verticalVelocityOffsetDownBlendTime = (CFloat) CR2WTypeManager.Create("Float", "verticalVelocityOffsetDownBlendTime", cr2w, this);
				}
				return _verticalVelocityOffsetDownBlendTime;
			}
			set
			{
				if (_verticalVelocityOffsetDownBlendTime == value)
				{
					return;
				}
				_verticalVelocityOffsetDownBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slidingOnSlopeBlendTime")] 
		public CFloat SlidingOnSlopeBlendTime
		{
			get
			{
				if (_slidingOnSlopeBlendTime == null)
				{
					_slidingOnSlopeBlendTime = (CFloat) CR2WTypeManager.Create("Float", "slidingOnSlopeBlendTime", cr2w, this);
				}
				return _slidingOnSlopeBlendTime;
			}
			set
			{
				if (_slidingOnSlopeBlendTime == value)
				{
					return;
				}
				_slidingOnSlopeBlendTime = value;
				PropertySet(this);
			}
		}

		public animSBehaviorConstraintNodeFloorIKCommonData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
