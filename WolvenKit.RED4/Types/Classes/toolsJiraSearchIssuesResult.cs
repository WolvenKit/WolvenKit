using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraSearchIssuesResult : ISerializable
	{
		[Ordinal(0)] 
		[RED("startAt")] 
		public CUInt32 StartAt
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("maxResults")] 
		public CUInt32 MaxResults
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("issues")] 
		public CArray<toolsJiraIssue> Issues
		{
			get => GetPropertyValue<CArray<toolsJiraIssue>>();
			set => SetPropertyValue<CArray<toolsJiraIssue>>(value);
		}

		[Ordinal(4)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(5)] 
		[RED("warningMessages")] 
		public CArray<CString> WarningMessages
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public toolsJiraSearchIssuesResult()
		{
			Issues = new();
			ErrorMessages = new();
			WarningMessages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
