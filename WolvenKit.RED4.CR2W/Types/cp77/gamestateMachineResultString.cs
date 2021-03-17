using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultString : CVariable
	{
		private CString _value;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}

		public gamestateMachineResultString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
