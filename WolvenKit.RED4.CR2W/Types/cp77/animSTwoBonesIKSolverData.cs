using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSTwoBonesIKSolverData : CVariable
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
			get
			{
				if (_upperBone == null)
				{
					_upperBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "upperBone", cr2w, this);
				}
				return _upperBone;
			}
			set
			{
				if (_upperBone == value)
				{
					return;
				}
				_upperBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("jointBone")] 
		public animTransformIndex JointBone
		{
			get
			{
				if (_jointBone == null)
				{
					_jointBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "jointBone", cr2w, this);
				}
				return _jointBone;
			}
			set
			{
				if (_jointBone == value)
				{
					return;
				}
				_jointBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("subLowerBone")] 
		public animTransformIndex SubLowerBone
		{
			get
			{
				if (_subLowerBone == null)
				{
					_subLowerBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "subLowerBone", cr2w, this);
				}
				return _subLowerBone;
			}
			set
			{
				if (_subLowerBone == value)
				{
					return;
				}
				_subLowerBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lowerBone")] 
		public animTransformIndex LowerBone
		{
			get
			{
				if (_lowerBone == null)
				{
					_lowerBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "lowerBone", cr2w, this);
				}
				return _lowerBone;
			}
			set
			{
				if (_lowerBone == value)
				{
					return;
				}
				_lowerBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ikBone")] 
		public animTransformIndex IkBone
		{
			get
			{
				if (_ikBone == null)
				{
					_ikBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "ikBone", cr2w, this);
				}
				return _ikBone;
			}
			set
			{
				if (_ikBone == value)
				{
					return;
				}
				_ikBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("limitToLengthPercentage")] 
		public CFloat LimitToLengthPercentage
		{
			get
			{
				if (_limitToLengthPercentage == null)
				{
					_limitToLengthPercentage = (CFloat) CR2WTypeManager.Create("Float", "limitToLengthPercentage", cr2w, this);
				}
				return _limitToLengthPercentage;
			}
			set
			{
				if (_limitToLengthPercentage == value)
				{
					return;
				}
				_limitToLengthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reverseBend")] 
		public CBool ReverseBend
		{
			get
			{
				if (_reverseBend == null)
				{
					_reverseBend = (CBool) CR2WTypeManager.Create("Bool", "reverseBend", cr2w, this);
				}
				return _reverseBend;
			}
			set
			{
				if (_reverseBend == value)
				{
					return;
				}
				_reverseBend = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("allowToLock")] 
		public CBool AllowToLock
		{
			get
			{
				if (_allowToLock == null)
				{
					_allowToLock = (CBool) CR2WTypeManager.Create("Bool", "allowToLock", cr2w, this);
				}
				return _allowToLock;
			}
			set
			{
				if (_allowToLock == value)
				{
					return;
				}
				_allowToLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("autoSetupDirs")] 
		public CBool AutoSetupDirs
		{
			get
			{
				if (_autoSetupDirs == null)
				{
					_autoSetupDirs = (CBool) CR2WTypeManager.Create("Bool", "autoSetupDirs", cr2w, this);
				}
				return _autoSetupDirs;
			}
			set
			{
				if (_autoSetupDirs == value)
				{
					return;
				}
				_autoSetupDirs = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("jointSideWeightUpper")] 
		public CFloat JointSideWeightUpper
		{
			get
			{
				if (_jointSideWeightUpper == null)
				{
					_jointSideWeightUpper = (CFloat) CR2WTypeManager.Create("Float", "jointSideWeightUpper", cr2w, this);
				}
				return _jointSideWeightUpper;
			}
			set
			{
				if (_jointSideWeightUpper == value)
				{
					return;
				}
				_jointSideWeightUpper = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("jointSideWeightJoint")] 
		public CFloat JointSideWeightJoint
		{
			get
			{
				if (_jointSideWeightJoint == null)
				{
					_jointSideWeightJoint = (CFloat) CR2WTypeManager.Create("Float", "jointSideWeightJoint", cr2w, this);
				}
				return _jointSideWeightJoint;
			}
			set
			{
				if (_jointSideWeightJoint == value)
				{
					return;
				}
				_jointSideWeightJoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("jointSideWeightLower")] 
		public CFloat JointSideWeightLower
		{
			get
			{
				if (_jointSideWeightLower == null)
				{
					_jointSideWeightLower = (CFloat) CR2WTypeManager.Create("Float", "jointSideWeightLower", cr2w, this);
				}
				return _jointSideWeightLower;
			}
			set
			{
				if (_jointSideWeightLower == value)
				{
					return;
				}
				_jointSideWeightLower = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Joint to-next dir in upper's BS")] 
		public Vector4 Joint_to_next_dir_in_upper_s_BS
		{
			get
			{
				if (_joint_to_next_dir_in_upper_s_BS == null)
				{
					_joint_to_next_dir_in_upper_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint to-next dir in upper's BS", cr2w, this);
				}
				return _joint_to_next_dir_in_upper_s_BS;
			}
			set
			{
				if (_joint_to_next_dir_in_upper_s_BS == value)
				{
					return;
				}
				_joint_to_next_dir_in_upper_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Joint to-next dir in joint's BS")] 
		public Vector4 Joint_to_next_dir_in_joint_s_BS
		{
			get
			{
				if (_joint_to_next_dir_in_joint_s_BS == null)
				{
					_joint_to_next_dir_in_joint_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint to-next dir in joint's BS", cr2w, this);
				}
				return _joint_to_next_dir_in_joint_s_BS;
			}
			set
			{
				if (_joint_to_next_dir_in_joint_s_BS == value)
				{
					return;
				}
				_joint_to_next_dir_in_joint_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("Joint to-next dir in lower's BS")] 
		public Vector4 Joint_to_next_dir_in_lower_s_BS
		{
			get
			{
				if (_joint_to_next_dir_in_lower_s_BS == null)
				{
					_joint_to_next_dir_in_lower_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint to-next dir in lower's BS", cr2w, this);
				}
				return _joint_to_next_dir_in_lower_s_BS;
			}
			set
			{
				if (_joint_to_next_dir_in_lower_s_BS == value)
				{
					return;
				}
				_joint_to_next_dir_in_lower_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("Joint side dir in upper's BS")] 
		public Vector4 Joint_side_dir_in_upper_s_BS
		{
			get
			{
				if (_joint_side_dir_in_upper_s_BS == null)
				{
					_joint_side_dir_in_upper_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint side dir in upper's BS", cr2w, this);
				}
				return _joint_side_dir_in_upper_s_BS;
			}
			set
			{
				if (_joint_side_dir_in_upper_s_BS == value)
				{
					return;
				}
				_joint_side_dir_in_upper_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("Joint side dir in joint's BS")] 
		public Vector4 Joint_side_dir_in_joint_s_BS
		{
			get
			{
				if (_joint_side_dir_in_joint_s_BS == null)
				{
					_joint_side_dir_in_joint_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint side dir in joint's BS", cr2w, this);
				}
				return _joint_side_dir_in_joint_s_BS;
			}
			set
			{
				if (_joint_side_dir_in_joint_s_BS == value)
				{
					return;
				}
				_joint_side_dir_in_joint_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("Joint side dir in lower's BS")] 
		public Vector4 Joint_side_dir_in_lower_s_BS
		{
			get
			{
				if (_joint_side_dir_in_lower_s_BS == null)
				{
					_joint_side_dir_in_lower_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint side dir in lower's BS", cr2w, this);
				}
				return _joint_side_dir_in_lower_s_BS;
			}
			set
			{
				if (_joint_side_dir_in_lower_s_BS == value)
				{
					return;
				}
				_joint_side_dir_in_lower_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Joint bend dir in upper's BS")] 
		public Vector4 Joint_bend_dir_in_upper_s_BS
		{
			get
			{
				if (_joint_bend_dir_in_upper_s_BS == null)
				{
					_joint_bend_dir_in_upper_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint bend dir in upper's BS", cr2w, this);
				}
				return _joint_bend_dir_in_upper_s_BS;
			}
			set
			{
				if (_joint_bend_dir_in_upper_s_BS == value)
				{
					return;
				}
				_joint_bend_dir_in_upper_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Joint bend dir in joint's BS")] 
		public Vector4 Joint_bend_dir_in_joint_s_BS
		{
			get
			{
				if (_joint_bend_dir_in_joint_s_BS == null)
				{
					_joint_bend_dir_in_joint_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint bend dir in joint's BS", cr2w, this);
				}
				return _joint_bend_dir_in_joint_s_BS;
			}
			set
			{
				if (_joint_bend_dir_in_joint_s_BS == value)
				{
					return;
				}
				_joint_bend_dir_in_joint_s_BS = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("Joint bend dir in lower's BS")] 
		public Vector4 Joint_bend_dir_in_lower_s_BS
		{
			get
			{
				if (_joint_bend_dir_in_lower_s_BS == null)
				{
					_joint_bend_dir_in_lower_s_BS = (Vector4) CR2WTypeManager.Create("Vector4", "Joint bend dir in lower's BS", cr2w, this);
				}
				return _joint_bend_dir_in_lower_s_BS;
			}
			set
			{
				if (_joint_bend_dir_in_lower_s_BS == value)
				{
					return;
				}
				_joint_bend_dir_in_lower_s_BS = value;
				PropertySet(this);
			}
		}

		public animSTwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
