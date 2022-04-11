using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalMetaQuestScriptedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameJournalMetaQuestScriptedData()
		{
			Hidden = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
