using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintEllipsoid_ : animIDyngConstraint
	{
		private animTransformIndex _bone;
		private QsTransform _ellipsoidTransformLS;
		private CFloat _constraintRadius;
		private CFloat _constraintScale1;
		private CFloat _constraintScale2;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("ellipsoidTransformLS")] 
		public QsTransform EllipsoidTransformLS
		{
			get
			{
				if (_ellipsoidTransformLS == null)
				{
					_ellipsoidTransformLS = (QsTransform) CR2WTypeManager.Create("QsTransform", "ellipsoidTransformLS", cr2w, this);
				}
				return _ellipsoidTransformLS;
			}
			set
			{
				if (_ellipsoidTransformLS == value)
				{
					return;
				}
				_ellipsoidTransformLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("constraintRadius")] 
		public CFloat ConstraintRadius
		{
			get
			{
				if (_constraintRadius == null)
				{
					_constraintRadius = (CFloat) CR2WTypeManager.Create("Float", "constraintRadius", cr2w, this);
				}
				return _constraintRadius;
			}
			set
			{
				if (_constraintRadius == value)
				{
					return;
				}
				_constraintRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get
			{
				if (_constraintScale1 == null)
				{
					_constraintScale1 = (CFloat) CR2WTypeManager.Create("Float", "constraintScale1", cr2w, this);
				}
				return _constraintScale1;
			}
			set
			{
				if (_constraintScale1 == value)
				{
					return;
				}
				_constraintScale1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get
			{
				if (_constraintScale2 == null)
				{
					_constraintScale2 = (CFloat) CR2WTypeManager.Create("Float", "constraintScale2", cr2w, this);
				}
				return _constraintScale2;
			}
			set
			{
				if (_constraintScale2 == value)
				{
					return;
				}
				_constraintScale2 = value;
				PropertySet(this);
			}
		}

		public animDyngConstraintEllipsoid_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
