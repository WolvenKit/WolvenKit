using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		private CFloat _firstValue;
		private CFloat _secondValue;
		private CFloat _trueValue;
		private CFloat _falseValue;
		private CEnum<animEAnimGraphCompareFunc> _operation;
		private animFloatLink _firstInputLink;
		private animFloatLink _secondInputLink;
		private animFloatLink _trueInputLink;
		private animFloatLink _falseInputLink;

		[Ordinal(11)] 
		[RED("firstValue")] 
		public CFloat FirstValue
		{
			get
			{
				if (_firstValue == null)
				{
					_firstValue = (CFloat) CR2WTypeManager.Create("Float", "firstValue", cr2w, this);
				}
				return _firstValue;
			}
			set
			{
				if (_firstValue == value)
				{
					return;
				}
				_firstValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("secondValue")] 
		public CFloat SecondValue
		{
			get
			{
				if (_secondValue == null)
				{
					_secondValue = (CFloat) CR2WTypeManager.Create("Float", "secondValue", cr2w, this);
				}
				return _secondValue;
			}
			set
			{
				if (_secondValue == value)
				{
					return;
				}
				_secondValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("trueValue")] 
		public CFloat TrueValue
		{
			get
			{
				if (_trueValue == null)
				{
					_trueValue = (CFloat) CR2WTypeManager.Create("Float", "trueValue", cr2w, this);
				}
				return _trueValue;
			}
			set
			{
				if (_trueValue == value)
				{
					return;
				}
				_trueValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("falseValue")] 
		public CFloat FalseValue
		{
			get
			{
				if (_falseValue == null)
				{
					_falseValue = (CFloat) CR2WTypeManager.Create("Float", "falseValue", cr2w, this);
				}
				return _falseValue;
			}
			set
			{
				if (_falseValue == value)
				{
					return;
				}
				_falseValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("operation")] 
		public CEnum<animEAnimGraphCompareFunc> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<animEAnimGraphCompareFunc>) CR2WTypeManager.Create("animEAnimGraphCompareFunc", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("firstInputLink")] 
		public animFloatLink FirstInputLink
		{
			get
			{
				if (_firstInputLink == null)
				{
					_firstInputLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "firstInputLink", cr2w, this);
				}
				return _firstInputLink;
			}
			set
			{
				if (_firstInputLink == value)
				{
					return;
				}
				_firstInputLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("secondInputLink")] 
		public animFloatLink SecondInputLink
		{
			get
			{
				if (_secondInputLink == null)
				{
					_secondInputLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "secondInputLink", cr2w, this);
				}
				return _secondInputLink;
			}
			set
			{
				if (_secondInputLink == value)
				{
					return;
				}
				_secondInputLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("trueInputLink")] 
		public animFloatLink TrueInputLink
		{
			get
			{
				if (_trueInputLink == null)
				{
					_trueInputLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "trueInputLink", cr2w, this);
				}
				return _trueInputLink;
			}
			set
			{
				if (_trueInputLink == value)
				{
					return;
				}
				_trueInputLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("falseInputLink")] 
		public animFloatLink FalseInputLink
		{
			get
			{
				if (_falseInputLink == null)
				{
					_falseInputLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "falseInputLink", cr2w, this);
				}
				return _falseInputLink;
			}
			set
			{
				if (_falseInputLink == value)
				{
					return;
				}
				_falseInputLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatComparator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
