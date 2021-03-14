using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintLink : animIDyngConstraint
	{
		private animTransformIndex _bone1;
		private animTransformIndex _bone2;
		private CEnum<animDyngConstraintLinkType> _linkType;
		private CFloat _lengthLowerBoundRatioPercentage;
		private CFloat _lengthUpperBoundRatioPercentage;
		private Vector3 _lookAtAxis;

		[Ordinal(1)] 
		[RED("bone1")] 
		public animTransformIndex Bone1
		{
			get
			{
				if (_bone1 == null)
				{
					_bone1 = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone1", cr2w, this);
				}
				return _bone1;
			}
			set
			{
				if (_bone1 == value)
				{
					return;
				}
				_bone1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bone2")] 
		public animTransformIndex Bone2
		{
			get
			{
				if (_bone2 == null)
				{
					_bone2 = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone2", cr2w, this);
				}
				return _bone2;
			}
			set
			{
				if (_bone2 == value)
				{
					return;
				}
				_bone2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("linkType")] 
		public CEnum<animDyngConstraintLinkType> LinkType
		{
			get
			{
				if (_linkType == null)
				{
					_linkType = (CEnum<animDyngConstraintLinkType>) CR2WTypeManager.Create("animDyngConstraintLinkType", "linkType", cr2w, this);
				}
				return _linkType;
			}
			set
			{
				if (_linkType == value)
				{
					return;
				}
				_linkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lengthLowerBoundRatioPercentage")] 
		public CFloat LengthLowerBoundRatioPercentage
		{
			get
			{
				if (_lengthLowerBoundRatioPercentage == null)
				{
					_lengthLowerBoundRatioPercentage = (CFloat) CR2WTypeManager.Create("Float", "lengthLowerBoundRatioPercentage", cr2w, this);
				}
				return _lengthLowerBoundRatioPercentage;
			}
			set
			{
				if (_lengthLowerBoundRatioPercentage == value)
				{
					return;
				}
				_lengthLowerBoundRatioPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lengthUpperBoundRatioPercentage")] 
		public CFloat LengthUpperBoundRatioPercentage
		{
			get
			{
				if (_lengthUpperBoundRatioPercentage == null)
				{
					_lengthUpperBoundRatioPercentage = (CFloat) CR2WTypeManager.Create("Float", "lengthUpperBoundRatioPercentage", cr2w, this);
				}
				return _lengthUpperBoundRatioPercentage;
			}
			set
			{
				if (_lengthUpperBoundRatioPercentage == value)
				{
					return;
				}
				_lengthUpperBoundRatioPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lookAtAxis")] 
		public Vector3 LookAtAxis
		{
			get
			{
				if (_lookAtAxis == null)
				{
					_lookAtAxis = (Vector3) CR2WTypeManager.Create("Vector3", "lookAtAxis", cr2w, this);
				}
				return _lookAtAxis;
			}
			set
			{
				if (_lookAtAxis == value)
				{
					return;
				}
				_lookAtAxis = value;
				PropertySet(this);
			}
		}

		public animDyngConstraintLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
