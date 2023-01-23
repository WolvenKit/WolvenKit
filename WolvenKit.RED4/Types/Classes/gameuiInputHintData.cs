using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CName Action
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("tutorialAction")] 
		public CName TutorialAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("localizedLabel")] 
		public CString LocalizedLabel
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("queuePriority")] 
		public CInt32 QueuePriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("sortingPriority")] 
		public CInt32 SortingPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("tutorialActionCount")] 
		public CInt32 TutorialActionCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetPropertyValue<CEnum<inkInputHintHoldIndicationType>>();
			set => SetPropertyValue<CEnum<inkInputHintHoldIndicationType>>(value);
		}

		[Ordinal(9)] 
		[RED("enableHoldAnimation")] 
		public CBool EnableHoldAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiInputHintData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
