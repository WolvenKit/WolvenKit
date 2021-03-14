using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMultipleParentConstraint_JsonProperties : ISerializable
	{
		private CArray<animMultipleParentConstraint_JsonEntry> _parentsTransforms;
		private CName _transformIndex;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private CName _weightFloatTrack;

		[Ordinal(0)] 
		[RED("parentsTransforms")] 
		public CArray<animMultipleParentConstraint_JsonEntry> ParentsTransforms
		{
			get
			{
				if (_parentsTransforms == null)
				{
					_parentsTransforms = (CArray<animMultipleParentConstraint_JsonEntry>) CR2WTypeManager.Create("array:animMultipleParentConstraint_JsonEntry", "parentsTransforms", cr2w, this);
				}
				return _parentsTransforms;
			}
			set
			{
				if (_parentsTransforms == value)
				{
					return;
				}
				_parentsTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transformIndex")] 
		public CName TransformIndex
		{
			get
			{
				if (_transformIndex == null)
				{
					_transformIndex = (CName) CR2WTypeManager.Create("CName", "transformIndex", cr2w, this);
				}
				return _transformIndex;
			}
			set
			{
				if (_transformIndex == value)
				{
					return;
				}
				_transformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get
			{
				if (_weightMode == null)
				{
					_weightMode = (CEnum<animConstraintWeightMode>) CR2WTypeManager.Create("animConstraintWeightMode", "weightMode", cr2w, this);
				}
				return _weightMode;
			}
			set
			{
				if (_weightMode == value)
				{
					return;
				}
				_weightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weightFloatTrack")] 
		public CName WeightFloatTrack
		{
			get
			{
				if (_weightFloatTrack == null)
				{
					_weightFloatTrack = (CName) CR2WTypeManager.Create("CName", "weightFloatTrack", cr2w, this);
				}
				return _weightFloatTrack;
			}
			set
			{
				if (_weightFloatTrack == value)
				{
					return;
				}
				_weightFloatTrack = value;
				PropertySet(this);
			}
		}

		public animMultipleParentConstraint_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
