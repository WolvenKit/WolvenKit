using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableEnum : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get
			{
				if (_exportAsProperty == null)
				{
					_exportAsProperty = (CBool) CR2WTypeManager.Create("Bool", "exportAsProperty", cr2w, this);
				}
				return _exportAsProperty;
			}
			set
			{
				if (_exportAsProperty == value)
				{
					return;
				}
				_exportAsProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get
			{
				if (_enumClass == null)
				{
					_enumClass = (CName) CR2WTypeManager.Create("CName", "enumClass", cr2w, this);
				}
				return _enumClass;
			}
			set
			{
				if (_enumClass == value)
				{
					return;
				}
				_enumClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CInt64) CR2WTypeManager.Create("Int64", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTreeVariableEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
