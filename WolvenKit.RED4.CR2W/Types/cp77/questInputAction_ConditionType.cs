using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputAction_ConditionType : questISystemConditionType
	{
		private CBool _anyInputAction;
		private CName _inputAction;
		private CBool _checkIfButtonAlreadyPressed;
		private CBool _axisAction;
		private CFloat _valueLessThan;
		private CFloat _valueMoreThan;

		[Ordinal(0)] 
		[RED("anyInputAction")] 
		public CBool AnyInputAction
		{
			get
			{
				if (_anyInputAction == null)
				{
					_anyInputAction = (CBool) CR2WTypeManager.Create("Bool", "anyInputAction", cr2w, this);
				}
				return _anyInputAction;
			}
			set
			{
				if (_anyInputAction == value)
				{
					return;
				}
				_anyInputAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get
			{
				if (_inputAction == null)
				{
					_inputAction = (CName) CR2WTypeManager.Create("CName", "inputAction", cr2w, this);
				}
				return _inputAction;
			}
			set
			{
				if (_inputAction == value)
				{
					return;
				}
				_inputAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("checkIfButtonAlreadyPressed")] 
		public CBool CheckIfButtonAlreadyPressed
		{
			get
			{
				if (_checkIfButtonAlreadyPressed == null)
				{
					_checkIfButtonAlreadyPressed = (CBool) CR2WTypeManager.Create("Bool", "checkIfButtonAlreadyPressed", cr2w, this);
				}
				return _checkIfButtonAlreadyPressed;
			}
			set
			{
				if (_checkIfButtonAlreadyPressed == value)
				{
					return;
				}
				_checkIfButtonAlreadyPressed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("axisAction")] 
		public CBool AxisAction
		{
			get
			{
				if (_axisAction == null)
				{
					_axisAction = (CBool) CR2WTypeManager.Create("Bool", "axisAction", cr2w, this);
				}
				return _axisAction;
			}
			set
			{
				if (_axisAction == value)
				{
					return;
				}
				_axisAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("valueLessThan")] 
		public CFloat ValueLessThan
		{
			get
			{
				if (_valueLessThan == null)
				{
					_valueLessThan = (CFloat) CR2WTypeManager.Create("Float", "valueLessThan", cr2w, this);
				}
				return _valueLessThan;
			}
			set
			{
				if (_valueLessThan == value)
				{
					return;
				}
				_valueLessThan = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("valueMoreThan")] 
		public CFloat ValueMoreThan
		{
			get
			{
				if (_valueMoreThan == null)
				{
					_valueMoreThan = (CFloat) CR2WTypeManager.Create("Float", "valueMoreThan", cr2w, this);
				}
				return _valueMoreThan;
			}
			set
			{
				if (_valueMoreThan == value)
				{
					return;
				}
				_valueMoreThan = value;
				PropertySet(this);
			}
		}

		public questInputAction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
