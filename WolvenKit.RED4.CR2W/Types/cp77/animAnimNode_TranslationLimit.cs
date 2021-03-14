using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animTransformIndex _parentTransform;
		private animFloatClamp _limitOnXAxis;
		private animFloatClamp _limitOnYAxis;
		private animFloatClamp _limitOnZAxis;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get
			{
				if (_parentTransform == null)
				{
					_parentTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "parentTransform", cr2w, this);
				}
				return _parentTransform;
			}
			set
			{
				if (_parentTransform == value)
				{
					return;
				}
				_parentTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("limitOnXAxis")] 
		public animFloatClamp LimitOnXAxis
		{
			get
			{
				if (_limitOnXAxis == null)
				{
					_limitOnXAxis = (animFloatClamp) CR2WTypeManager.Create("animFloatClamp", "limitOnXAxis", cr2w, this);
				}
				return _limitOnXAxis;
			}
			set
			{
				if (_limitOnXAxis == value)
				{
					return;
				}
				_limitOnXAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("limitOnYAxis")] 
		public animFloatClamp LimitOnYAxis
		{
			get
			{
				if (_limitOnYAxis == null)
				{
					_limitOnYAxis = (animFloatClamp) CR2WTypeManager.Create("animFloatClamp", "limitOnYAxis", cr2w, this);
				}
				return _limitOnYAxis;
			}
			set
			{
				if (_limitOnYAxis == value)
				{
					return;
				}
				_limitOnYAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("limitOnZAxis")] 
		public animFloatClamp LimitOnZAxis
		{
			get
			{
				if (_limitOnZAxis == null)
				{
					_limitOnZAxis = (animFloatClamp) CR2WTypeManager.Create("animFloatClamp", "limitOnZAxis", cr2w, this);
				}
				return _limitOnZAxis;
			}
			set
			{
				if (_limitOnZAxis == value)
				{
					return;
				}
				_limitOnZAxis = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
