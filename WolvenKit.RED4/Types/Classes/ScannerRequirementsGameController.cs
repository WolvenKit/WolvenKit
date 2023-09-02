using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerRequirementsGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("ScannerRequirementsRightPanel")] 
		public inkCompoundWidgetReference ScannerRequirementsRightPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("requirementsCallbackID")] 
		public CHandle<redCallbackObject> RequirementsCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("isValidRequirements")] 
		public CBool IsValidRequirements
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

		public ScannerRequirementsGameController()
		{
			ScannerRequirementsRightPanel = new inkCompoundWidgetReference();
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
