using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTerm : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(95)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(96)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get => GetPropertyValue<CHandle<FastTravelComponent>>();
			set => SetPropertyValue<CHandle<FastTravelComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public DataTerm()
		{
			ControllerTypeName = "DataTermController";
			MappinID = new();
			ShortGlitchDelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
