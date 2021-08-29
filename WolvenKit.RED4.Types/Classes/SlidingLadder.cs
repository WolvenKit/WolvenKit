using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlidingLadder : BaseAnimatedDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionDown;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionUp;
		private CHandle<gameinteractionsComponent> _ladderInteraction;
		private CBool _wasShot;

		[Ordinal(102)] 
		[RED("offMeshConnectionDown")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionDown
		{
			get => GetProperty(ref _offMeshConnectionDown);
			set => SetProperty(ref _offMeshConnectionDown, value);
		}

		[Ordinal(103)] 
		[RED("offMeshConnectionUp")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionUp
		{
			get => GetProperty(ref _offMeshConnectionUp);
			set => SetProperty(ref _offMeshConnectionUp, value);
		}

		[Ordinal(104)] 
		[RED("ladderInteraction")] 
		public CHandle<gameinteractionsComponent> LadderInteraction
		{
			get => GetProperty(ref _ladderInteraction);
			set => SetProperty(ref _ladderInteraction, value);
		}

		[Ordinal(105)] 
		[RED("wasShot")] 
		public CBool WasShot
		{
			get => GetProperty(ref _wasShot);
			set => SetProperty(ref _wasShot, value);
		}
	}
}
