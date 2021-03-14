using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUIMeasurementController : inkWidgetLogicController
	{
		private CFloat _value;
		private CEnum<EMeasurementUnit> _unit;
		private inkTextWidgetReference _valueText;
		private inkTextWidgetReference _unitText;
		private inkWidgetReference _valueIncreaseButton;
		private inkWidgetReference _valueDecreaseButton;

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get
			{
				if (_unit == null)
				{
					_unit = (CEnum<EMeasurementUnit>) CR2WTypeManager.Create("EMeasurementUnit", "unit", cr2w, this);
				}
				return _unit;
			}
			set
			{
				if (_unit == value)
				{
					return;
				}
				_unit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get
			{
				if (_valueText == null)
				{
					_valueText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "valueText", cr2w, this);
				}
				return _valueText;
			}
			set
			{
				if (_valueText == value)
				{
					return;
				}
				_valueText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get
			{
				if (_unitText == null)
				{
					_unitText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unitText", cr2w, this);
				}
				return _unitText;
			}
			set
			{
				if (_unitText == value)
				{
					return;
				}
				_unitText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("valueIncreaseButton")] 
		public inkWidgetReference ValueIncreaseButton
		{
			get
			{
				if (_valueIncreaseButton == null)
				{
					_valueIncreaseButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "valueIncreaseButton", cr2w, this);
				}
				return _valueIncreaseButton;
			}
			set
			{
				if (_valueIncreaseButton == value)
				{
					return;
				}
				_valueIncreaseButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("valueDecreaseButton")] 
		public inkWidgetReference ValueDecreaseButton
		{
			get
			{
				if (_valueDecreaseButton == null)
				{
					_valueDecreaseButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "valueDecreaseButton", cr2w, this);
				}
				return _valueDecreaseButton;
			}
			set
			{
				if (_valueDecreaseButton == value)
				{
					return;
				}
				_valueDecreaseButton = value;
				PropertySet(this);
			}
		}

		public SampleUIMeasurementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
