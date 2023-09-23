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
		[RED("assignee")] 
		public toolsJiraCustomFieldName Assignee
		{
			get => GetPropertyValue<toolsJiraCustomFieldName>();
			set => SetPropertyValue<toolsJiraCustomFieldName>(value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("versions")] 
		public CArray<toolsJiraCustomFieldId> Versions
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldId>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldId>>(value);
		}

		[Ordinal(10)] 
		[RED("fixVersions")] 
		public CArray<toolsJiraFixVersion> FixVersions
		{
			get => GetPropertyValue<CArray<toolsJiraFixVersion>>();
			set => SetPropertyValue<CArray<toolsJiraFixVersion>>(value);
		}

		[Ordinal(11)] 
		[RED("flagPosition")] 
		public CString FlagPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("components")] 
		public CArray<toolsJiraCustomFieldName> Components
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldName>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldName>>(value);
		}

		[Ordinal(13)] 
		[RED("attachment")] 
		public CArray<toolsJiraAttachment> Attachment
		{
			get => GetPropertyValue<CArray<toolsJiraAttachment>>();
			set => SetPropertyValue<CArray<toolsJiraAttachment>>(value);
		}

		[Ordinal(14)] 
		[RED("customfield_17400")] 
		public toolsJiraCustomFieldId Customfield_17400
		{
			get => GetPropertyValue<toolsJiraCustomFieldId>();
			set => SetPropertyValue<toolsJiraCustomFieldId>(value);
		}

		[Ordinal(15)] 
		[RED("customfield_18373")] 
		public CString Customfield_18373
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(16)] 
		[RED("customfield_34100")] 
		public toolsJiraCustomFieldValue Customfield_34100
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(17)] 
		[RED("customfield_15306")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_15306
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(18)] 
		[RED("customfield_13009")] 
		public CString Customfield_13009
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("customfield_10013")] 
		public CString Customfield_10013
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(20)] 
		[RED("customfield_10503")] 
		public CString Customfield_10503
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(21)] 
		[RED("customfield_10502")] 
		public CString Customfield_10502
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(22)] 
		[RED("customfield_34718")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_34718
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(23)] 
		[RED("customfield_36106")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_36106
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(24)] 
		[RED("customfield_10006")] 
		public CString Customfield_10006
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(25)] 
		[RED("customfield_10505")] 
		public toolsJiraCustomFieldValue Customfield_10505
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(26)] 
		[RED("customfield_10603")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_10603
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(27)] 
		[RED("customfield_24700")] 
		public CString Customfield_24700
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(28)] 
		[RED("customfield_34706")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_34706
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(29)] 
		[RED("customfield_25500")] 
		public toolsJiraCustomFieldValue Customfield_25500
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(30)] 
		[RED("customfield_15808")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_15808
		{
			get => GetPropertyValue<CArray<toolsJiraCustomFieldValue>>();
			set => SetPropertyValue<CArray<toolsJiraCustomFieldValue>>(value);
		}

		[Ordinal(31)] 
		[RED("customfield_33701")] 
		public CString Customfield_33701
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(32)] 
		[RED("customfield_18006")] 
		public CString Customfield_18006
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(33)] 
		[RED("customfield_29900")] 
		public toolsJiraCustomFieldValue Customfield_29900
		{
			get => GetPropertyValue<toolsJiraCustomFieldValue>();
			set => SetPropertyValue<toolsJiraCustomFieldValue>(value);
		}

		[Ordinal(34)] 
		[RED("customfield_10005")] 
		public CString Customfield_10005
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(35)] 
		[RED("customfield_10606")] 
		public CString Customfield_10606
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(36)] 
		[RED("customfield_31700")] 
		public CString Customfield_31700
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
			Versions = new();
			FixVersions = new();
			Components = new();
			Attachment = new();
			Customfield_17400 = new toolsJiraCustomFieldId();
			Customfield_34100 = new toolsJiraCustomFieldValue();
			Customfield_15306 = new();
			Customfield_34718 = new();
			Customfield_36106 = new();
			Customfield_10505 = new toolsJiraCustomFieldValue();
			Customfield_10603 = new();
			Customfield_34706 = new();
			Customfield_25500 = new toolsJiraCustomFieldValue { Value = "NONE" };
			Customfield_15808 = new();
			Customfield_29900 = new toolsJiraCustomFieldValue();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
