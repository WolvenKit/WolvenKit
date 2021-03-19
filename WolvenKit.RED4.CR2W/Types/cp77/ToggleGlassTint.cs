using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleGlassTint : ActionBool
	{
		private CString _trueRecord;
		private CString _falseRecord;

		[Ordinal(25)] 
		[RED("TrueRecord")] 
		public CString TrueRecord
		{
			get => GetProperty(ref _trueRecord);
			set => SetProperty(ref _trueRecord, value);
		}

		[Ordinal(26)] 
		[RED("FalseRecord")] 
		public CString FalseRecord
		{
			get => GetProperty(ref _falseRecord);
			set => SetProperty(ref _falseRecord, value);
		}

		public ToggleGlassTint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
