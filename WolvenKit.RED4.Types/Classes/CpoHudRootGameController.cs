using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CpoHudRootGameController : gameuiWidgetGameController
	{
		private CWeakHandle<inkWidget> _hitIndicator;
		private CWeakHandle<inkWidget> _chatBox;
		private CWeakHandle<inkWidget> _playerList;
		private CWeakHandle<inkWidget> _narration_journal;
		private CWeakHandle<inkWidget> _narrative_plate;
		private CWeakHandle<inkWidget> _inventory;
		private CWeakHandle<inkWidget> _loadouts;

		[Ordinal(2)] 
		[RED("hitIndicator")] 
		public CWeakHandle<inkWidget> HitIndicator
		{
			get => GetProperty(ref _hitIndicator);
			set => SetProperty(ref _hitIndicator, value);
		}

		[Ordinal(3)] 
		[RED("chatBox")] 
		public CWeakHandle<inkWidget> ChatBox
		{
			get => GetProperty(ref _chatBox);
			set => SetProperty(ref _chatBox, value);
		}

		[Ordinal(4)] 
		[RED("playerList")] 
		public CWeakHandle<inkWidget> PlayerList
		{
			get => GetProperty(ref _playerList);
			set => SetProperty(ref _playerList, value);
		}

		[Ordinal(5)] 
		[RED("narration_journal")] 
		public CWeakHandle<inkWidget> Narration_journal
		{
			get => GetProperty(ref _narration_journal);
			set => SetProperty(ref _narration_journal, value);
		}

		[Ordinal(6)] 
		[RED("narrative_plate")] 
		public CWeakHandle<inkWidget> Narrative_plate
		{
			get => GetProperty(ref _narrative_plate);
			set => SetProperty(ref _narrative_plate, value);
		}

		[Ordinal(7)] 
		[RED("inventory")] 
		public CWeakHandle<inkWidget> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		[Ordinal(8)] 
		[RED("loadouts")] 
		public CWeakHandle<inkWidget> Loadouts
		{
			get => GetProperty(ref _loadouts);
			set => SetProperty(ref _loadouts, value);
		}
	}
}
