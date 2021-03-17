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
			get => GetProperty(ref _errorMessage);
			set => SetProperty(ref _errorMessage, value);
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CString Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		[Ordinal(2)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		public interopGlobalNodeIDResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
