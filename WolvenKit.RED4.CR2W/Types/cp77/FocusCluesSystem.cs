using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusCluesSystem : gameScriptableSystem
	{
		private CArray<LinkedFocusClueData> _linkedClues;
		private CArray<CName> _disabledGroupes;
		private LinkedFocusClueData _activeLinkedClue;

		[Ordinal(0)] 
		[RED("linkedClues")] 
		public CArray<LinkedFocusClueData> LinkedClues
		{
			get => GetProperty(ref _linkedClues);
			set => SetProperty(ref _linkedClues, value);
		}

		[Ordinal(1)] 
		[RED("disabledGroupes")] 
		public CArray<CName> DisabledGroupes
		{
			get => GetProperty(ref _disabledGroupes);
			set => SetProperty(ref _disabledGroupes, value);
		}

		[Ordinal(2)] 
		[RED("activeLinkedClue")] 
		public LinkedFocusClueData ActiveLinkedClue
		{
			get => GetProperty(ref _activeLinkedClue);
			set => SetProperty(ref _activeLinkedClue, value);
		}

		public FocusCluesSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
