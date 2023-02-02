using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sharedResourceCommandOutcome : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<sharedCommandResult> Result
		{
			get => GetPropertyValue<CEnum<sharedCommandResult>>();
			set => SetPropertyValue<CEnum<sharedCommandResult>>(value);
		}

		[Ordinal(1)] 
		[RED("modifiedFiles")] 
		public CArray<CString> ModifiedFiles
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public sharedResourceCommandOutcome()
		{
			Result = Enums.sharedCommandResult.Fail;
			ModifiedFiles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
