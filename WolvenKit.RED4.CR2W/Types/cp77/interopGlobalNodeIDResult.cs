using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopGlobalNodeIDResult : CVariable
	{
		private CString _errorMessage;
		private CString _result;
		private CBool _isValid;

		[Ordinal(0)] 
		[RED("errorMessage")] 
		public CString ErrorMessage
		{
			get
			{
				if (_errorMessage == null)
				{
					_errorMessage = (CString) CR2WTypeManager.Create("String", "errorMessage", cr2w, this);
				}
				return _errorMessage;
			}
			set
			{
				if (_errorMessage == value)
				{
					return;
				}
				_errorMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CString Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CString) CR2WTypeManager.Create("String", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		public interopGlobalNodeIDResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
