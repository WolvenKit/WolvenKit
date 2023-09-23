using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("defaultHighlightData")] 
		public CHandle<HighlightEditableData> DefaultHighlightData
		{
			get => GetPropertyValue<CHandle<HighlightEditableData>>();
			set => SetPropertyValue<CHandle<HighlightEditableData>>(value);
		}

		[Ordinal(5)] 
		[RED("forcedHighlights")] 
		public CArray<CHandle<FocusForcedHighlightData>> ForcedHighlights
		{
			get => GetPropertyValue<CArray<CHandle<FocusForcedHighlightData>>>();
			set => SetPropertyValue<CArray<CHandle<FocusForcedHighlightData>>>(value);
		}

		[Ordinal(6)] 
		[RED("activeForcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ActiveForcedHighlight
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(7)] 
		[RED("currentDefaultHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentDefaultHighlight
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(8)] 
		[RED("activeRevealRequests")] 
		public CArray<gameVisionModeSystemRevealIdentifier> ActiveRevealRequests
		{
			get => GetPropertyValue<CArray<gameVisionModeSystemRevealIdentifier>>();
			set => SetPropertyValue<CArray<gameVisionModeSystemRevealIdentifier>>(value);
		}

		[Ordinal(9)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("wasCleanedUp")] 
		public CBool WasCleanedUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("slaveObjectsToHighlight")] 
		public CArray<entEntityID> SlaveObjectsToHighlight
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public gameVisionModeComponent()
		{
			Name = "vision";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
