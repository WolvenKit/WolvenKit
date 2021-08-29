using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVulnerabilitiesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerVulnerabilitiesRightPanel;
		private CHandle<redCallbackObject> _vulnerabilitiesCallbackID;
		private CBool _isValidVulnerabilities;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

		[Ordinal(5)] 
		[RED("ScannerVulnerabilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerVulnerabilitiesRightPanel
		{
			get => GetProperty(ref _scannerVulnerabilitiesRightPanel);
			set => SetProperty(ref _scannerVulnerabilitiesRightPanel, value);
		}

		[Ordinal(6)] 
		[RED("vulnerabilitiesCallbackID")] 
		public CHandle<redCallbackObject> VulnerabilitiesCallbackID
		{
			get => GetProperty(ref _vulnerabilitiesCallbackID);
			set => SetProperty(ref _vulnerabilitiesCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("isValidVulnerabilities")] 
		public CBool IsValidVulnerabilities
		{
			get => GetProperty(ref _isValidVulnerabilities);
			set => SetProperty(ref _isValidVulnerabilities, value);
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
