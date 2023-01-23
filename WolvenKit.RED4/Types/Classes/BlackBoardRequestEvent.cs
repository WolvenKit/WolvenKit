using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlackBoardRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("blackBoard")] 
		public CWeakHandle<gameIBlackboard> BlackBoard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("storageClass")] 
		public CEnum<gameScriptedBlackboardStorage> StorageClass
		{
			get => GetPropertyValue<CEnum<gameScriptedBlackboardStorage>>();
			set => SetPropertyValue<CEnum<gameScriptedBlackboardStorage>>(value);
		}

		[Ordinal(2)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BlackBoardRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
