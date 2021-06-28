using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveBase : gameJournalContainerEntry
	{
		private LocalizationString _description;
		private CUInt32 _counter;
		private CBool _optional;
		private NodeRef _locationPrefabRef;
		private TweakDBID _itemID;
		private CString _districtID;

		[Ordinal(2)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("counter")] 
		public CUInt32 Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(4)] 
		[RED("optional")] 
		public CBool Optional
		{
			get => GetProperty(ref _optional);
			set => SetProperty(ref _optional, value);
		}

		[Ordinal(5)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetProperty(ref _locationPrefabRef);
			set => SetProperty(ref _locationPrefabRef, value);
		}

		[Ordinal(6)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(7)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}

		public gameJournalQuestObjectiveBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
