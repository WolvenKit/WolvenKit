using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MetaQuestStatus : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("MetaQuest1Hidden")] 
		public CBool MetaQuest1Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("MetaQuest1Value")] 
		public CInt32 MetaQuest1Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("MetaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("MetaQuest2Hidden")] 
		public CBool MetaQuest2Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("MetaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("MetaQuest2Value")] 
		public CInt32 MetaQuest2Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("MetaQuest3Hidden")] 
		public CBool MetaQuest3Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("MetaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public CInt32 MetaQuest3Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MetaQuestStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
