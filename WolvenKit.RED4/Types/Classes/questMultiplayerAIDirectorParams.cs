using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerAIDirectorParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questMultiplayerAIDirectorFunction> Function
		{
			get => GetPropertyValue<CEnum<questMultiplayerAIDirectorFunction>>();
			set => SetPropertyValue<CEnum<questMultiplayerAIDirectorFunction>>(value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<questMultiplayerAIDirectorStatus> Status
		{
			get => GetPropertyValue<CEnum<questMultiplayerAIDirectorStatus>>();
			set => SetPropertyValue<CEnum<questMultiplayerAIDirectorStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("pathRef")] 
		public NodeRef PathRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("scheduleEntryName")] 
		public CString ScheduleEntryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("scheduleName")] 
		public CString ScheduleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public questMultiplayerAIDirectorParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
