using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlidingLadder : BaseAnimatedDevice
	{
		[Ordinal(102)] 
		[RED("offMeshConnectionDown")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionDown
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("offMeshConnectionUp")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionUp
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("ladderInteraction")] 
		public CHandle<gameinteractionsComponent> LadderInteraction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(105)] 
		[RED("wasShot")] 
		public CBool WasShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SlidingLadder()
		{
			ControllerTypeName = "SlidingLadderController";
		}
	}
}
