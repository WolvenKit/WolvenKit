using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTerm : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(99)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(100)] 
		[RED("metroAnimationNode")] 
		public NodeRef MetroAnimationNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(101)] 
		[RED("SubwayGateBroken")] 
		public CBool SubwayGateBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get => GetPropertyValue<CHandle<FastTravelComponent>>();
			set => SetPropertyValue<CHandle<FastTravelComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(105)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(107)] 
		[RED("hologramMeshGreen")] 
		public CHandle<entIPlacedComponent> HologramMeshGreen
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(108)] 
		[RED("hologramMeshRed")] 
		public CHandle<entIPlacedComponent> HologramMeshRed
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public DataTerm()
		{
			ControllerTypeName = "DataTermController";
			MappinID = new gameNewMappinID();
			ShortGlitchDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
