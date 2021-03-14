using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeParameter : CVariable
	{
		private CName _parameterName;
		private CUInt16 _parameterId;
		private CEnum<LibTreeEParameterType> _parameterType;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get
			{
				if (_parameterName == null)
				{
					_parameterName = (CName) CR2WTypeManager.Create("CName", "parameterName", cr2w, this);
				}
				return _parameterName;
			}
			set
			{
				if (_parameterName == value)
				{
					return;
				}
				_parameterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parameterId")] 
		public CUInt16 ParameterId
		{
			get
			{
				if (_parameterId == null)
				{
					_parameterId = (CUInt16) CR2WTypeManager.Create("Uint16", "parameterId", cr2w, this);
				}
				return _parameterId;
			}
			set
			{
				if (_parameterId == value)
				{
					return;
				}
				_parameterId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parameterType")] 
		public CEnum<LibTreeEParameterType> ParameterType
		{
			get
			{
				if (_parameterType == null)
				{
					_parameterType = (CEnum<LibTreeEParameterType>) CR2WTypeManager.Create("LibTreeEParameterType", "parameterType", cr2w, this);
				}
				return _parameterType;
			}
			set
			{
				if (_parameterType == value)
				{
					return;
				}
				_parameterType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CVariant Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CVariant) CR2WTypeManager.Create("Variant", "value", cr2w, this);
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

		public LibTreeParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
