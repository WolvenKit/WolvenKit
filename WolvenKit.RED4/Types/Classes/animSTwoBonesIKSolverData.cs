using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSTwoBonesIKSolverData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("upperBone")] 
		public animTransformIndex UpperBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("jointBone")] 
		public animTransformIndex JointBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("subLowerBone")] 
		public animTransformIndex SubLowerBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("lowerBone")] 
		public animTransformIndex LowerBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("ikBone")] 
		public animTransformIndex IkBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("limitToLengthPercentage")] 
		public CFloat LimitToLengthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("reverseBend")] 
		public CBool ReverseBend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("allowToLock")] 
		public CBool AllowToLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("autoSetupDirs")] 
		public CBool AutoSetupDirs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("jointSideWeightUpper")] 
		public CFloat JointSideWeightUpper
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("jointSideWeightJoint")] 
		public CFloat JointSideWeightJoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("jointSideWeightLower")] 
		public CFloat JointSideWeightLower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("Joint to-next dir in upper's BS")] 
		public Vector4 Joint_to_next_dir_in_upper_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("Joint to-next dir in joint's BS")] 
		public Vector4 Joint_to_next_dir_in_joint_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(14)] 
		[RED("Joint to-next dir in lower's BS")] 
		public Vector4 Joint_to_next_dir_in_lower_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(15)] 
		[RED("Joint side dir in upper's BS")] 
		public Vector4 Joint_side_dir_in_upper_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(16)] 
		[RED("Joint side dir in joint's BS")] 
		public Vector4 Joint_side_dir_in_joint_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(17)] 
		[RED("Joint side dir in lower's BS")] 
		public Vector4 Joint_side_dir_in_lower_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(18)] 
		[RED("Joint bend dir in upper's BS")] 
		public Vector4 Joint_bend_dir_in_upper_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(19)] 
		[RED("Joint bend dir in joint's BS")] 
		public Vector4 Joint_bend_dir_in_joint_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(20)] 
		[RED("Joint bend dir in lower's BS")] 
		public Vector4 Joint_bend_dir_in_lower_s_BS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animSTwoBonesIKSolverData()
		{
			UpperBone = new animTransformIndex();
			JointBone = new animTransformIndex();
			SubLowerBone = new animTransformIndex();
			LowerBone = new animTransformIndex();
			IkBone = new animTransformIndex();
			LimitToLengthPercentage = 0.990000F;
			AutoSetupDirs = true;
			JointSideWeightUpper = 0.500000F;
			JointSideWeightJoint = 0.300000F;
			JointSideWeightLower = 0.200000F;
			Joint_to_next_dir_in_upper_s_BS = new Vector4 { X = 1.000000F };
			Joint_to_next_dir_in_joint_s_BS = new Vector4 { X = 1.000000F };
			Joint_to_next_dir_in_lower_s_BS = new Vector4 { X = 1.000000F };
			Joint_side_dir_in_upper_s_BS = new Vector4 { Z = 1.000000F };
			Joint_side_dir_in_joint_s_BS = new Vector4 { Z = 1.000000F };
			Joint_side_dir_in_lower_s_BS = new Vector4 { Z = 1.000000F };
			Joint_bend_dir_in_upper_s_BS = new Vector4 { Y = 1.000000F };
			Joint_bend_dir_in_joint_s_BS = new Vector4 { Y = 1.000000F };
			Joint_bend_dir_in_lower_s_BS = new Vector4 { Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
