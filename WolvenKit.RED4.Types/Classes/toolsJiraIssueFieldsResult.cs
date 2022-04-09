using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraIssueFieldsResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("project")] 
		public CString Project
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("summary")] 
		public CString Summary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("issuetype")] 
		public CString Issuetype
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CString Priority
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(5)] 
		[RED("flagPosition")] 
		public CString FlagPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("assignee")] 
		public CString Assignee
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("cameraLocation")] 
		public CString CameraLocation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("customfield_18373")] 
		public CString Customfield_18373
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("customfield_10505")] 
		public CString Customfield_10505
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("fixVersions")] 
		public CArray<CString> FixVersions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(12)] 
		[RED("customfield_15306")] 
		public CArray<CString> Customfield_15306
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(13)] 
		[RED("customfield_13009")] 
		public CString Customfield_13009
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("attachment")] 
		public CArray<toolsJiraAttachment> Attachment
		{
			get => GetPropertyValue<CArray<toolsJiraAttachment>>();
			set => SetPropertyValue<CArray<toolsJiraAttachment>>(value);
		}

		[Ordinal(15)] 
		[RED("customfield_25500")] 
		public CString Customfield_25500
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraIssueFieldsResult()
		{
			Labels = new();
			FixVersions = new();
			Customfield_15306 = new();
			Attachment = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
