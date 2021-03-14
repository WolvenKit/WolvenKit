using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMultipleParentConstraint_JsonEntry : CVariable
	{
		private CName _parentTransform;
		private CEnum<animConstraintWeightMode> _parentWeightMode;
		private CFloat _parentStaticWeight;
		private CName _parentTrackWeight;
		private CBool _useComplementWeight;
		private CBool _useOffset;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("parentTransform")] 
		public CName ParentTransform
		{
			get
			{
				if (_parentTransform == null)
				{
					_parentTransform = (CName) CR2WTypeManager.Create("CName", "parentTransform", cr2w, this);
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

		[Ordinal(1)] 
		[RED("parentWeightMode")] 
		public CEnum<animConstraintWeightMode> ParentWeightMode
		{
			get
			{
				if (_parentWeightMode == null)
				{
					_parentWeightMode = (CEnum<animConstraintWeightMode>) CR2WTypeManager.Create("animConstraintWeightMode", "parentWeightMode", cr2w, this);
				}
				return _parentWeightMode;
			}
			set
			{
				if (_parentWeightMode == value)
				{
					return;
				}
				_parentWeightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentStaticWeight")] 
		public CFloat ParentStaticWeight
		{
			get
			{
				if (_parentStaticWeight == null)
				{
					_parentStaticWeight = (CFloat) CR2WTypeManager.Create("Float", "parentStaticWeight", cr2w, this);
				}
				return _parentStaticWeight;
			}
			set
			{
				if (_parentStaticWeight == value)
				{
					return;
				}
				_parentStaticWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parentTrackWeight")] 
		public CName ParentTrackWeight
		{
			get
			{
				if (_parentTrackWeight == null)
				{
					_parentTrackWeight = (CName) CR2WTypeManager.Create("CName", "parentTrackWeight", cr2w, this);
				}
				return _parentTrackWeight;
			}
			set
			{
				if (_parentTrackWeight == value)
				{
					return;
				}
				_parentTrackWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useComplementWeight")] 
		public CBool UseComplementWeight
		{
			get
			{
				if (_useComplementWeight == null)
				{
					_useComplementWeight = (CBool) CR2WTypeManager.Create("Bool", "useComplementWeight", cr2w, this);
				}
				return _useComplementWeight;
			}
			set
			{
				if (_useComplementWeight == value)
				{
					return;
				}
				_useComplementWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useOffset")] 
		public CBool UseOffset
		{
			get
			{
				if (_useOffset == null)
				{
					_useOffset = (CBool) CR2WTypeManager.Create("Bool", "useOffset", cr2w, this);
				}
				return _useOffset;
			}
			set
			{
				if (_useOffset == value)
				{
					return;
				}
				_useOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (QsTransform) CR2WTypeManager.Create("QsTransform", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		public animMultipleParentConstraint_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
