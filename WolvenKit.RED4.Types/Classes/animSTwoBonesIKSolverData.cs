using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSTwoBonesIKSolverData : RedBaseClass
	{
		private animTransformIndex _upperBone;
		private animTransformIndex _jointBone;
		private animTransformIndex _subLowerBone;
		private animTransformIndex _lowerBone;
		private animTransformIndex _ikBone;
		private CFloat _limitToLengthPercentage;
		private CBool _reverseBend;
		private CBool _allowToLock;
		private CBool _autoSetupDirs;
		private CFloat _jointSideWeightUpper;
		private CFloat _jointSideWeightJoint;
		private CFloat _jointSideWeightLower;
		private Vector4 _joint_to_next_dir_in_upper_s_BS;
		private Vector4 _joint_to_next_dir_in_joint_s_BS;
		private Vector4 _joint_to_next_dir_in_lower_s_BS;
		private Vector4 _joint_side_dir_in_upper_s_BS;
		private Vector4 _joint_side_dir_in_joint_s_BS;
		private Vector4 _joint_side_dir_in_lower_s_BS;
		private Vector4 _joint_bend_dir_in_upper_s_BS;
		private Vector4 _joint_bend_dir_in_joint_s_BS;
		private Vector4 _joint_bend_dir_in_lower_s_BS;

		[Ordinal(0)] 
		[RED("upperBone")] 
		public animTransformIndex UpperBone
		{
			get => GetProperty(ref _upperBone);
			set => SetProperty(ref _upperBone, value);
		}

		[Ordinal(1)] 
		[RED("jointBone")] 
		public animTransformIndex JointBone
		{
			get => GetProperty(ref _jointBone);
			set => SetProperty(ref _jointBone, value);
		}

		[Ordinal(2)] 
		[RED("subLowerBone")] 
		public animTransformIndex SubLowerBone
		{
			get => GetProperty(ref _subLowerBone);
			set => SetProperty(ref _subLowerBone, value);
		}

		[Ordinal(3)] 
		[RED("lowerBone")] 
		public animTransformIndex LowerBone
		{
			get => GetProperty(ref _lowerBone);
			set => SetProperty(ref _lowerBone, value);
		}

		[Ordinal(4)] 
		[RED("ikBone")] 
		public animTransformIndex IkBone
		{
			get => GetProperty(ref _ikBone);
			set => SetProperty(ref _ikBone, value);
		}

		[Ordinal(5)] 
		[RED("limitToLengthPercentage")] 
		public CFloat LimitToLengthPercentage
		{
			get => GetProperty(ref _limitToLengthPercentage);
			set => SetProperty(ref _limitToLengthPercentage, value);
		}

		[Ordinal(6)] 
		[RED("reverseBend")] 
		public CBool ReverseBend
		{
			get => GetProperty(ref _reverseBend);
			set => SetProperty(ref _reverseBend, value);
		}

		[Ordinal(7)] 
		[RED("allowToLock")] 
		public CBool AllowToLock
		{
			get => GetProperty(ref _allowToLock);
			set => SetProperty(ref _allowToLock, value);
		}

		[Ordinal(8)] 
		[RED("autoSetupDirs")] 
		public CBool AutoSetupDirs
		{
			get => GetProperty(ref _autoSetupDirs);
			set => SetProperty(ref _autoSetupDirs, value);
		}

		[Ordinal(9)] 
		[RED("jointSideWeightUpper")] 
		public CFloat JointSideWeightUpper
		{
			get => GetProperty(ref _jointSideWeightUpper);
			set => SetProperty(ref _jointSideWeightUpper, value);
		}

		[Ordinal(10)] 
		[RED("jointSideWeightJoint")] 
		public CFloat JointSideWeightJoint
		{
			get => GetProperty(ref _jointSideWeightJoint);
			set => SetProperty(ref _jointSideWeightJoint, value);
		}

		[Ordinal(11)] 
		[RED("jointSideWeightLower")] 
		public CFloat JointSideWeightLower
		{
			get => GetProperty(ref _jointSideWeightLower);
			set => SetProperty(ref _jointSideWeightLower, value);
		}

		[Ordinal(12)] 
		[RED("Joint to-next dir in upper's BS")] 
		public Vector4 Joint_to_next_dir_in_upper_s_BS
		{
			get => GetProperty(ref _joint_to_next_dir_in_upper_s_BS);
			set => SetProperty(ref _joint_to_next_dir_in_upper_s_BS, value);
		}

		[Ordinal(13)] 
		[RED("Joint to-next dir in joint's BS")] 
		public Vector4 Joint_to_next_dir_in_joint_s_BS
		{
			get => GetProperty(ref _joint_to_next_dir_in_joint_s_BS);
			set => SetProperty(ref _joint_to_next_dir_in_joint_s_BS, value);
		}

		[Ordinal(14)] 
		[RED("Joint to-next dir in lower's BS")] 
		public Vector4 Joint_to_next_dir_in_lower_s_BS
		{
			get => GetProperty(ref _joint_to_next_dir_in_lower_s_BS);
			set => SetProperty(ref _joint_to_next_dir_in_lower_s_BS, value);
		}

		[Ordinal(15)] 
		[RED("Joint side dir in upper's BS")] 
		public Vector4 Joint_side_dir_in_upper_s_BS
		{
			get => GetProperty(ref _joint_side_dir_in_upper_s_BS);
			set => SetProperty(ref _joint_side_dir_in_upper_s_BS, value);
		}

		[Ordinal(16)] 
		[RED("Joint side dir in joint's BS")] 
		public Vector4 Joint_side_dir_in_joint_s_BS
		{
			get => GetProperty(ref _joint_side_dir_in_joint_s_BS);
			set => SetProperty(ref _joint_side_dir_in_joint_s_BS, value);
		}

		[Ordinal(17)] 
		[RED("Joint side dir in lower's BS")] 
		public Vector4 Joint_side_dir_in_lower_s_BS
		{
			get => GetProperty(ref _joint_side_dir_in_lower_s_BS);
			set => SetProperty(ref _joint_side_dir_in_lower_s_BS, value);
		}

		[Ordinal(18)] 
		[RED("Joint bend dir in upper's BS")] 
		public Vector4 Joint_bend_dir_in_upper_s_BS
		{
			get => GetProperty(ref _joint_bend_dir_in_upper_s_BS);
			set => SetProperty(ref _joint_bend_dir_in_upper_s_BS, value);
		}

		[Ordinal(19)] 
		[RED("Joint bend dir in joint's BS")] 
		public Vector4 Joint_bend_dir_in_joint_s_BS
		{
			get => GetProperty(ref _joint_bend_dir_in_joint_s_BS);
			set => SetProperty(ref _joint_bend_dir_in_joint_s_BS, value);
		}

		[Ordinal(20)] 
		[RED("Joint bend dir in lower's BS")] 
		public Vector4 Joint_bend_dir_in_lower_s_BS
		{
			get => GetProperty(ref _joint_bend_dir_in_lower_s_BS);
			set => SetProperty(ref _joint_bend_dir_in_lower_s_BS, value);
		}
	}
}
