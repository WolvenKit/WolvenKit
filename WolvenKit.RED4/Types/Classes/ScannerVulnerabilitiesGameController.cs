using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVulnerabilitiesGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("ScannerVulnerabilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerVulnerabilitiesRightPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("vulnerabilitiesCallbackID")] 
		public CHandle<redCallbackObject> VulnerabilitiesCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("isValidVulnerabilities")] 
		public CBool IsValidVulnerabilities
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		public ScannerVulnerabilitiesGameController()
		{
			ScannerVulnerabilitiesRightPanel = new inkCompoundWidgetReference();
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
