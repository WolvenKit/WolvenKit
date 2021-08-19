using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilitiesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerAbilitiesRightPanel;
		private CHandle<redCallbackObject> _abilitiesCallbackID;
		private CBool _isValidAbilities;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

		[Ordinal(5)] 
		[RED("ScannerAbilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerAbilitiesRightPanel
		{
			get => GetProperty(ref _scannerAbilitiesRightPanel);
			set => SetProperty(ref _scannerAbilitiesRightPanel, value);
		}

		[Ordinal(6)] 
		[RED("abilitiesCallbackID")] 
		public CHandle<redCallbackObject> AbilitiesCallbackID
		{
			get => GetProperty(ref _abilitiesCallbackID);
			set => SetProperty(ref _abilitiesCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("isValidAbilities")] 
		public CBool IsValidAbilities
		{
			get => GetProperty(ref _isValidAbilities);
			set => SetProperty(ref _isValidAbilities, value);
		}

		[Ordinal(8)] 
		[RED("asyncSpawnRequests")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetProperty(ref _asyncSpawnRequests);
			set => SetProperty(ref _asyncSpawnRequests, value);
		}

		public ScannerAbilitiesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
