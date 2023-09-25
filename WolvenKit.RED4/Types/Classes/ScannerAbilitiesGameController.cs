using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerAbilitiesGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("ScannerAbilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerAbilitiesRightPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("abilitiesCallbackID")] 
		public CHandle<redCallbackObject> AbilitiesCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("isValidAbilities")] 
		public CBool IsValidAbilities
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

		public ScannerAbilitiesGameController()
		{
			ScannerAbilitiesRightPanel = new inkCompoundWidgetReference();
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
