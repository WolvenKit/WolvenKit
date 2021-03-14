using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetVar_NodeType : questIFactsDBManagerNodeType
	{
		private CString _factName;
		private CInt32 _value;
		private CBool _setExactValue;

		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CString) CR2WTypeManager.Create("String", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
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
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get
			{
				if (_setExactValue == null)
				{
					_setExactValue = (CBool) CR2WTypeManager.Create("Bool", "setExactValue", cr2w, this);
				}
				return _setExactValue;
			}
			set
			{
				if (_setExactValue == value)
				{
					return;
				}
				_setExactValue = value;
				PropertySet(this);
			}
		}

		public questSetVar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
