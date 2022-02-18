using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsJiraCommentIssueResult : ISerializable
	{
		[Ordinal(0)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public toolsJiraCommentIssueResult()
		{
			ErrorMessages = new();
		}
	}
}
