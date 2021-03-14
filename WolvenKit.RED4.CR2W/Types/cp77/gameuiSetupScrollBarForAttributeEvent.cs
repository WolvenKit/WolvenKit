using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupScrollBarForAttributeEvent : redEvent
	{
		private CUInt32 _attribute;
		private CFloat _startValue;
		private CFloat _minValue;
		private CFloat _maxValue;
		private CFloat _step;

		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get
			{
				if (_attribute == null)
				{
					_attribute = (CUInt32) CR2WTypeManager.Create("Uint32", "attribute", cr2w, this);
				}
				return _attribute;
			}
			set
			{
				if (_attribute == value)
				{
					return;
				}
				_attribute = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (CFloat) CR2WTypeManager.Create("Float", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (CFloat) CR2WTypeManager.Create("Float", "minValue", cr2w, this);
				}
				return _minValue;
			}
			set
			{
				if (_minValue == value)
				{
					return;
				}
				_minValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CFloat) CR2WTypeManager.Create("Float", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("step")] 
		public CFloat Step
		{
			get
			{
				if (_step == null)
				{
					_step = (CFloat) CR2WTypeManager.Create("Float", "step", cr2w, this);
				}
				return _step;
			}
			set
			{
				if (_step == value)
				{
					return;
				}
				_step = value;
				PropertySet(this);
			}
		}

		public gameuiSetupScrollBarForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
