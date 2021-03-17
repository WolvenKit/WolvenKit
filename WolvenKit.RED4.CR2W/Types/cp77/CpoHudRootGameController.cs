using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoHudRootGameController : gameuiWidgetGameController
	{
		private CHandle<inkWidget> _hitIndicator;
		private CHandle<inkWidget> _chatBox;
		private CHandle<inkWidget> _playerList;
		private CHandle<inkWidget> _narration_journal;
		private CHandle<inkWidget> _narrative_plate;
		private CHandle<inkWidget> _inventory;
		private CHandle<inkWidget> _loadouts;

		[Ordinal(2)] 
		[RED("hitIndicator")] 
		public CHandle<inkWidget> HitIndicator
		{
			get => GetProperty(ref _hitIndicator);
			set => SetProperty(ref _hitIndicator, value);
		}

		[Ordinal(3)] 
		[RED("chatBox")] 
		public CHandle<inkWidget> ChatBox
		{
			get => GetProperty(ref _chatBox);
			set => SetProperty(ref _chatBox, value);
		}

		[Ordinal(4)] 
		[RED("playerList")] 
		public CHandle<inkWidget> PlayerList
		{
			get => GetProperty(ref _playerList);
			set => SetProperty(ref _playerList, value);
		}

		[Ordinal(5)] 
		[RED("narration_journal")] 
		public CHandle<inkWidget> Narration_journal
		{
			get => GetProperty(ref _narration_journal);
			set => SetProperty(ref _narration_journal, value);
		}

		[Ordinal(6)] 
		[RED("narrative_plate")] 
		public CHandle<inkWidget> Narrative_plate
		{
			get => GetProperty(ref _narrative_plate);
			set => SetProperty(ref _narrative_plate, value);
		}

		[Ordinal(7)] 
		[RED("inventory")] 
		public CHandle<inkWidget> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		[Ordinal(8)] 
		[RED("loadouts")] 
		public CHandle<inkWidget> Loadouts
		{
			get => GetProperty(ref _loadouts);
			set => SetProperty(ref _loadouts, value);
		}

		public CpoHudRootGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
