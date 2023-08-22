using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FocusCluesSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("linkedClues")] 
		public CArray<LinkedFocusClueData> LinkedClues
		{
			get => GetPropertyValue<CArray<LinkedFocusClueData>>();
			set => SetPropertyValue<CArray<LinkedFocusClueData>>(value);
		}

		[Ordinal(1)] 
		[RED("disabledGroupes")] 
		public CArray<CName> DisabledGroupes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("activeLinkedClue")] 
		public LinkedFocusClueData ActiveLinkedClue
		{
			get => GetPropertyValue<LinkedFocusClueData>();
			set => SetPropertyValue<LinkedFocusClueData>(value);
		}

		public FocusCluesSystem()
		{
			LinkedClues = new();
			DisabledGroupes = new();
			ActiveLinkedClue = new LinkedFocusClueData { OwnerID = new entEntityID(), ExtendedClueRecords = new(), PsData = new PSOwnerData { Id = new gamePersistentID() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
