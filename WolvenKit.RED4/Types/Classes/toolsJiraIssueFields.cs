using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraIssueFields : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("project")] 
		public toolsJiraProject Project
		{
			get => GetPropertyValue<toolsJiraProject>();
			set => SetPropertyValue<toolsJiraProject>(value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public toolsJiraStatus Status
		{
			get => GetPropertyValue<toolsJiraStatus>();
			set => SetPropertyValue<toolsJiraStatus>(value);
		}

		[Ordinal(2)] 
		[RED("resolution")] 
		public toolsJiraResolution Resolution
		{
			get => GetPropertyValue<toolsJiraResolution>();
			set => SetPropertyValue<toolsJiraResolution>(value);
		}

		[Ordinal(3)] 
		[RED("summary")] 
		public CString Summary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("issuetype")] 
		public toolsJiraIssueType Issuetype
		{
			get => GetPropertyValue<toolsJiraIssueType>();
			set => SetPropertyValue<toolsJiraIssueType>(value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public toolsJiraPriority Priority
		{
			get => GetPropertyValue<toolsJiraPriority>();
			set => SetPropertyValue<toolsJiraPriority>(value);
		}

		[Ordinal(6)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(7)] 
		[RED("flagPosition")] 
		public CString FlagPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("assignee")] 
		public toolsJiraCustomFieldName Assignee
		{
			get => GetPropertyValue<toolsJiraCustomFieldName>();
			set => SetPropertyValue<toolsJiraCustomFieldName>(value);
		}

		[Ordinal(9)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("cameraLocation")] 
		public CString CameraLocation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("customfield_18373")] 
		public CString Customfield_18373
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("customfield_10505")] 
		public toolsJiraCustomFieldValue Customfield_10505
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(13)] 
		[RED("customfield_29900")] 
		public toolsJiraCustomFieldValue Customfield_29900
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(14)] 
		[RED("customfield_18006")] 
		public CString Customfield_18006
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("fixVersions")] 
		public CArray<toolsJiraFixVersion> FixVersions
		{
			get => GetPropertyValue<CArray<toolsJiraFixVersion>>();
			set => SetPropertyValue<CArray<toolsJiraFixVersion>>(value);
		}

		[Ordinal(16)] 
		[RED("customfield_15306")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_15306
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(17)] 
		[RED("customfield_13009")] 
		public CString Customfield_13009
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(18)] 
		[RED("attachment")] 
		public CArray<toolsJiraAttachment> Attachment
		{
			get => GetPropertyValue<CArray<toolsJiraAttachment>>();
			set => SetPropertyValue<CArray<toolsJiraAttachment>>(value);
		}

		[Ordinal(19)] 
		[RED("customfield_25500")] 
		public toolsJiraCustomFieldValue Customfield_25500
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(20)] 
		[RED("customfield_10006")] 
		public CString Customfield_10006
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(21)] 
		[RED("customfield_31700")] 
		public CString Customfield_31700
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(22)] 
		[RED("versions")] 
		public CArray<toolsJiraAffectedVersion> Versions
		{
			get => GetPropertyValue<CArray<toolsJiraAffectedVersion>>();
			set => SetPropertyValue<CArray<toolsJiraAffectedVersion>>(value);
		}

		public toolsJiraIssueFields()
		{
			Project = new toolsJiraProject();
			Status = new toolsJiraStatus();
			Resolution = new toolsJiraResolution();
			Issuetype = new toolsJiraIssueType();
			Priority = new toolsJiraPriority();
			Labels = new();
			Assignee = new toolsJiraCustomFieldName();
			Customfield_10505 = new toolsJiraCustomFieldValue();
			Customfield_29900 = new toolsJiraCustomFieldValue();
			FixVersions = new();
			Customfield_15306 = new();
			Attachment = new();
			Customfield_25500 = new toolsJiraCustomFieldValue { Value = "NONE" };
			Versions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
