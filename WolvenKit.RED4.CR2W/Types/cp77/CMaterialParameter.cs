using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameter : ISerializable
	{
		private CName _parameterName;
		private CUInt32 _register;

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
		[RED("register")] 
		public CUInt32 Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CUInt32) CR2WTypeManager.Create("Uint32", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		public CMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
