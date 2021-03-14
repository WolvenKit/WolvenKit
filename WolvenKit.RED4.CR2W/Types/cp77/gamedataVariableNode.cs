using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataVariableNode : gamedataDataNode
	{
		private CName _hashedName;
		private CString _type;
		private CString _name;
		private CBool _isForeignKey;
		private CBool _isArray;
		private CBool _hasArrayValues;
		private CBool _isAddition;
		private CEnum<gamedataTweakDBType> _typeEnum;
		private CArray<gamedataVariableNodeVariableValue> _values;

		[Ordinal(3)] 
		[RED("hashedName")] 
		public CName HashedName
		{
			get
			{
				if (_hashedName == null)
				{
					_hashedName = (CName) CR2WTypeManager.Create("CName", "hashedName", cr2w, this);
				}
				return _hashedName;
			}
			set
			{
				if (_hashedName == value)
				{
					return;
				}
				_hashedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CString Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CString) CR2WTypeManager.Create("String", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isForeignKey")] 
		public CBool IsForeignKey
		{
			get
			{
				if (_isForeignKey == null)
				{
					_isForeignKey = (CBool) CR2WTypeManager.Create("Bool", "isForeignKey", cr2w, this);
				}
				return _isForeignKey;
			}
			set
			{
				if (_isForeignKey == value)
				{
					return;
				}
				_isForeignKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isArray")] 
		public CBool IsArray
		{
			get
			{
				if (_isArray == null)
				{
					_isArray = (CBool) CR2WTypeManager.Create("Bool", "isArray", cr2w, this);
				}
				return _isArray;
			}
			set
			{
				if (_isArray == value)
				{
					return;
				}
				_isArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hasArrayValues")] 
		public CBool HasArrayValues
		{
			get
			{
				if (_hasArrayValues == null)
				{
					_hasArrayValues = (CBool) CR2WTypeManager.Create("Bool", "hasArrayValues", cr2w, this);
				}
				return _hasArrayValues;
			}
			set
			{
				if (_hasArrayValues == value)
				{
					return;
				}
				_hasArrayValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isAddition")] 
		public CBool IsAddition
		{
			get
			{
				if (_isAddition == null)
				{
					_isAddition = (CBool) CR2WTypeManager.Create("Bool", "isAddition", cr2w, this);
				}
				return _isAddition;
			}
			set
			{
				if (_isAddition == value)
				{
					return;
				}
				_isAddition = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("typeEnum")] 
		public CEnum<gamedataTweakDBType> TypeEnum
		{
			get
			{
				if (_typeEnum == null)
				{
					_typeEnum = (CEnum<gamedataTweakDBType>) CR2WTypeManager.Create("gamedataTweakDBType", "typeEnum", cr2w, this);
				}
				return _typeEnum;
			}
			set
			{
				if (_typeEnum == value)
				{
					return;
				}
				_typeEnum = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("values")] 
		public CArray<gamedataVariableNodeVariableValue> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (CArray<gamedataVariableNodeVariableValue>) CR2WTypeManager.Create("array:gamedataVariableNodeVariableValue", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		public gamedataVariableNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
