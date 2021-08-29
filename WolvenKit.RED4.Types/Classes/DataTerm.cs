using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataTerm : InteractiveDevice
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private NodeRef _exitNode;
		private CHandle<FastTravelComponent> _fastTravelComponent;
		private CHandle<entIPlacedComponent> _lockColiderComponent;
		private gameNewMappinID _mappinID;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(97)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetProperty(ref _linkedFastTravelPoint);
			set => SetProperty(ref _linkedFastTravelPoint, value);
		}

		[Ordinal(98)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetProperty(ref _exitNode);
			set => SetProperty(ref _exitNode, value);
		}

		[Ordinal(99)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get => GetProperty(ref _fastTravelComponent);
			set => SetProperty(ref _fastTravelComponent, value);
		}

		[Ordinal(100)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get => GetProperty(ref _lockColiderComponent);
			set => SetProperty(ref _lockColiderComponent, value);
		}

		[Ordinal(101)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(102)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(103)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}
	}
}
