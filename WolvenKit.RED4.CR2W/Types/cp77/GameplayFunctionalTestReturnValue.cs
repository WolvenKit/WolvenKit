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
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("errorInfo")] 
		public CString ErrorInfo
		{
			get => GetProperty(ref _errorInfo);
			set => SetProperty(ref _errorInfo, value);
		}

		public GameplayFunctionalTestReturnValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
