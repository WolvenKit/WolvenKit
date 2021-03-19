using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharParamTimeout : AITimeoutCondition
	{
		private CString _timeoutParamName;

		[Ordinal(1)] 
		[RED("timeoutParamName")] 
		public CString TimeoutParamName
		{
			get => GetProperty(ref _timeoutParamName);
			set => SetProperty(ref _timeoutParamName, value);
		}

		public CharParamTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
