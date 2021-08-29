using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TogglePower : ActionBool
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
	}
}
