using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraCreateIssueResult : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CString Key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(3)] 
		[RED("errors")] 
		public toolsJiraIssueFieldsResult Errors
		{
			get => GetPropertyValue<toolsJiraIssueFieldsResult>();
			set => SetPropertyValue<toolsJiraIssueFieldsResult>(value);
		}

		public toolsJiraCreateIssueResult()
		{
			ErrorMessages = new();
			Errors = new() { Labels = new(), FixVersions = new(), Customfield_15306 = new(), Attachment = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
