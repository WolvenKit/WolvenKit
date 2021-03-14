using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpacePoint : CVariable
	{
		private CName _animationName;
		private CBool _useFixedCoordinates;
		private CArray<CFloat> _fixedCoordinates;
		private CBool _useStaticPose;
		private CFloat _staticPoseTime;
		private CFloat _staticPoseProgress;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useFixedCoordinates")] 
		public CBool UseFixedCoordinates
		{
			get
			{
				if (_useFixedCoordinates == null)
				{
					_useFixedCoordinates = (CBool) CR2WTypeManager.Create("Bool", "useFixedCoordinates", cr2w, this);
				}
				return _useFixedCoordinates;
			}
			set
			{
				if (_useFixedCoordinates == value)
				{
					return;
				}
				_useFixedCoordinates = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fixedCoordinates")] 
		public CArray<CFloat> FixedCoordinates
		{
			get
			{
				if (_fixedCoordinates == null)
				{
					_fixedCoordinates = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "fixedCoordinates", cr2w, this);
				}
				return _fixedCoordinates;
			}
			set
			{
				if (_fixedCoordinates == value)
				{
					return;
				}
				_fixedCoordinates = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useStaticPose")] 
		public CBool UseStaticPose
		{
			get
			{
				if (_useStaticPose == null)
				{
					_useStaticPose = (CBool) CR2WTypeManager.Create("Bool", "useStaticPose", cr2w, this);
				}
				return _useStaticPose;
			}
			set
			{
				if (_useStaticPose == value)
				{
					return;
				}
				_useStaticPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("staticPoseTime")] 
		public CFloat StaticPoseTime
		{
			get
			{
				if (_staticPoseTime == null)
				{
					_staticPoseTime = (CFloat) CR2WTypeManager.Create("Float", "staticPoseTime", cr2w, this);
				}
				return _staticPoseTime;
			}
			set
			{
				if (_staticPoseTime == value)
				{
					return;
				}
				_staticPoseTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("staticPoseProgress")] 
		public CFloat StaticPoseProgress
		{
			get
			{
				if (_staticPoseProgress == null)
				{
					_staticPoseProgress = (CFloat) CR2WTypeManager.Create("Float", "staticPoseProgress", cr2w, this);
				}
				return _staticPoseProgress;
			}
			set
			{
				if (_staticPoseProgress == value)
				{
					return;
				}
				_staticPoseProgress = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendSpace_InternalsBlendSpacePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
