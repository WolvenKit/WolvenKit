using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedResourceCommandOutcome : CVariable
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

		public sharedResourceCommandOutcome(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
