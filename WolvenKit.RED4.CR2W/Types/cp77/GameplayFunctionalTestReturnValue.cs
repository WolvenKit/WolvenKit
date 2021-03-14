using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayFunctionalTestReturnValue : CVariable
	{
		private CString _value;
		private CString _errorInfo;

		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CString) CR2WTypeManager.Create("String", "value", cr2w, this);
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

		[Ordinal(1)] 
		[RED("errorInfo")] 
		public CString ErrorInfo
		{
			get
			{
				if (_errorInfo == null)
				{
					_errorInfo = (CString) CR2WTypeManager.Create("String", "errorInfo", cr2w, this);
				}
				return _errorInfo;
			}
			set
			{
				if (_errorInfo == value)
				{
					return;
				}
				_errorInfo = value;
				PropertySet(this);
			}
		}

		public GameplayFunctionalTestReturnValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
