using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectionComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("slot")] 
		public CString Slot
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("cumulatedObjRotationX")] 
		public CFloat CumulatedObjRotationX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("cumulatedObjRotationY")] 
		public CFloat CumulatedObjRotationY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("maxObjOffset")] 
		public CFloat MaxObjOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("minObjOffset")] 
		public CFloat MinObjOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("isPlayerInspecting")] 
		public CBool IsPlayerInspecting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("activeClue")] 
		public CString ActiveClue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("isScanAvailable")] 
		public CBool IsScanAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("scanningInProgress")] 
		public CBool ScanningInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("objectScanned")] 
		public CBool ObjectScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Inspection> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_Inspection>>();
			set => SetPropertyValue<CHandle<AnimFeature_Inspection>>(value);
		}

		[Ordinal(18)] 
		[RED("listener")] 
		public CHandle<IScriptable> Listener
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(19)] 
		[RED("lastInspectedObjID")] 
		public entEntityID LastInspectedObjID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public InspectionComponent()
		{
			LastInspectedObjID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
