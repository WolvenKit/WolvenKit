using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerRequirementsGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerRequirementsRightPanel;
		private CHandle<redCallbackObject> _requirementsCallbackID;
		private CBool _isValidRequirements;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

		[Ordinal(5)] 
		[RED("ScannerRequirementsRightPanel")] 
		public inkCompoundWidgetReference ScannerRequirementsRightPanel
		{
			get => GetProperty(ref _scannerRequirementsRightPanel);
			set => SetProperty(ref _scannerRequirementsRightPanel, value);
		}

		[Ordinal(6)] 
		[RED("requirementsCallbackID")] 
		public CHandle<redCallbackObject> RequirementsCallbackID
		{
			get => GetProperty(ref _requirementsCallbackID);
			set => SetProperty(ref _requirementsCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("isValidRequirements")] 
		public CBool IsValidRequirements
		{
			get => GetProperty(ref _isValidRequirements);
			set => SetProperty(ref _isValidRequirements, value);
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
