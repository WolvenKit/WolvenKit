using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsJiraEditIssueResult : ISerializable
	{
		[Ordinal(0)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(1)] 
		[RED("errors")] 
		public toolsJiraIssueFieldsResult Errors
		{
			get => GetPropertyValue<toolsJiraIssueFieldsResult>();
			set => SetPropertyValue<toolsJiraIssueFieldsResult>(value);
		}

		public toolsJiraEditIssueResult()
		{
			ErrorMessages = new();
			Errors = new() { Labels = new(), FixVersions = new(), Customfield_15306 = new(), Attachment = new() };
		}
	}
}
