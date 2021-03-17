using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleActivate : ActionBool
	{
		private CString _trueRecordName;
		private CString _falseRecordName;

		[Ordinal(25)] 
		[RED("TrueRecordName")] 
		public CString TrueRecordName
		{
			get => GetProperty(ref _trueRecordName);
			set => SetProperty(ref _trueRecordName, value);
		}

		[Ordinal(26)] 
		[RED("FalseRecordName")] 
		public CString FalseRecordName
		{
			get => GetProperty(ref _falseRecordName);
			set => SetProperty(ref _falseRecordName, value);
		}

		public ToggleActivate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
