using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAbilitiesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerAbilitiesRightPanel;
		private CHandle<redCallbackObject> _abilitiesCallbackID;
		private CBool _isValidAbilities;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

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
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetProperty(ref _asyncSpawnRequests);
			set => SetProperty(ref _asyncSpawnRequests, value);
		}
	}
}
