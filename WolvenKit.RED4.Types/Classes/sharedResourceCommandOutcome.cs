using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sharedResourceCommandOutcome : RedBaseClass
	{
		private CEnum<sharedCommandResult> _result;
		private CArray<CString> _modifiedFiles;
		private CString _message;

		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<sharedCommandResult> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		[Ordinal(1)] 
		[RED("modifiedFiles")] 
		public CArray<CString> ModifiedFiles
		{
			get => GetProperty(ref _modifiedFiles);
			set => SetProperty(ref _modifiedFiles, value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}
	}
}
